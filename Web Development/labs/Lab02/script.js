/***************************************************************************
 * Program:      Js Monopoly Game
 * Author:       Sanjay Kumar
 * Date:         31 March, 2025
 * Description: – Implementing Monopoly Game using JavaScript
 ***************************************************************************/
window.onload = function ()
{
    // Get all section elements
    const sections = document.querySelectorAll('section');

    // Loop through each section and modify its content
    sections.forEach(section =>
    {
        const text = section.textContent.trim();
        const value = section.getAttribute('val');
        if (value > 0)
        {
            // Update the section's content to display both text and val attribute
            section.textContent = `${text} $${value}`;
        }
    });

    // Adding color and class styling to specific sections based on their suite
    document.querySelector('[suite = "0102"]').classList.add("red", "bottom");
    document.querySelector('[suite = "0104"]').classList.add("red", "bottom");
    document.querySelector('[suite = "0105"]').classList.add("red", "bottom");
    document.querySelector('[suite = "0107"]').classList.add("yellow", "bottom");
    document.querySelector('[suite = "0108"]').classList.add("yellow", "bottom");
    document.querySelector('[suite = "0110"]').classList.add("yellow", "bottom");
    document.querySelector('[suite = "0311"]').classList.add("green", "left");
    document.querySelector('[suite = "0411"]').classList.add("green", "left");
    document.querySelector('[suite = "0611"]').classList.add("green", "left");
    document.querySelector('[suite = "0911"]').classList.add("blue", "left");
    document.querySelector('[suite = "1011"]').classList.add("blue", "left");
    document.querySelector('[suite = "1110"]').classList.add("brown", "top");
    document.querySelector('[suite = "1108"]').classList.add("brown", "top");
    document.querySelector('[suite = "1105"]').classList.add("lightblue", "top");
    document.querySelector('[suite = "1103"]').classList.add("lightblue", "top");
    document.querySelector('[suite = "1102"]').classList.add("lightblue", "top");
    document.querySelector('[suite = "1001"]').classList.add("purple", "right");
    document.querySelector('[suite = "0801"]').classList.add("purple", "right");
    document.querySelector('[suite = "0701"]').classList.add("purple", "right");
    document.querySelector('[suite = "0501"]').classList.add("orange", "right");
    document.querySelector('[suite = "0301"]').classList.add("orange", "right");
    document.querySelector('[suite = "0201"]').classList.add("orange", "right");

};

/***************************************************************************
 * Function:     startGame
 * Purpose:      Initializes the game state, prepares the players, and sets up initial values.
 * Parameters:   None
 * Returns:      Void
 ***************************************************************************/
$(document).ready(function ()
{
    // Game state variables
    let currentPlayer = 1; // Tracks whose turn it is (1 or 2)
    let playerPositions = [0, 0]; // Tracks positions of both players (starting at GO)
    let playerBalances = [3000, 3000]; // Starting balances for both players
    let diceRolling = false; // Flag to prevent rolling while animation is happening
    let propertiesOwned = [[], []]; // Tracks properties owned by each player
    let propertyRents = {}; // Tracks current rent values for colored properties

    // Community Chest and Chance card texts and values
    const takeAChanceText = [
        "Second Place in Beauty Contest: $10",
        "Bank Pays You Dividend of $50",
        "Repair your Properties. You owe $250",
        "Speeding Fine: $15",
        "Holiday Fund Matures: Receive $100",
        "Pay Hospital Fees: $100"
    ];
    const takeAChanceMoney = [10, 50, -250, -15, 100, -100];

    $('#player1').html('<img src="images/person1.webp" alt="Player 1">');
    $('#player2').html('<img src="images/person2.webp" alt="Player 2">');

    // Preload dice images
    const diceImages = [];
    for (let i = 1; i <= 6; i++)
    {
        diceImages.push(new Image());
        diceImages[i - 1].src = `images/dice ${i}.png`;
    }

    // Initialize player positions and active state
    updatePlayerPositionOnBoard(1, 0);
    updatePlayerPositionOnBoard(2, 0);
    $('#player1').addClass('player-active'); // Player 1 starts first

    // Initialize game - set player 1 as active
    $('#player1div').addClass('active');
    updatePlayerBalances();

    // Event listener for Roll Dice button
    $('#RollDice').click(rollDiceAndMove);

    /***************************************************************************
     * Function:     rollDiceAndMove
     * Purpose:      Handles the rolling of two dice, updates dice images, 
     *               and moves the player accordingly.
     * Parameters:   None
     * Returns:      Void
     ***************************************************************************/
    function rollDiceAndMove()
    {
        if (diceRolling) return; // Prevent rolling while animation is in progress

        // Roll two dice
        const die1 = Math.floor(Math.random() * 6) + 1;
        const die2 = Math.floor(Math.random() * 6) + 1;
        const total = die1 + die2;

        // Update dice images
        $('#die1 img').attr('src', `images/dice ${die1}.png`);
        $('#die2 img').attr('src', `images/dice ${die2}.png`);

        // Disable button during movement
        $('#RollDice').prop('disabled', true);
        diceRolling = true;

        // Move player
        movePlayerOnBoard(currentPlayer, total, die1, die2);
    }

    /***************************************************************************
     * Function:     movePlayerOnBoard
     * Purpose:      Moves the player on the board according to the dice roll.
     * Parameters:   player (Number)    - The player to move (1 or 2)
     *               steps (Number)     - The number of steps to move
     *               die1 (Number)      - The value of the first die
     *               die2 (Number)      - The value of the second die
     * Returns:      Void
     ***************************************************************************/
    function movePlayerOnBoard(player, steps, die1, die2)
    {
        let stepsRemaining = steps;
        let currentPos = playerPositions[player - 1];

        // Set a speed for moving (e.g., 300ms between each step)
        const moveInterval = setInterval(() =>
        {
            if (stepsRemaining <= 0)
            {
                clearInterval(moveInterval); // Stop moving once all steps are done
                // Handle what happens after the player stops moving (landing logic)
                handlePlayerLanding(player, currentPos, die1, die2);
                return;
            }

            // Move to the next position
            currentPos = (currentPos + 1) % 40; // Wrap around the board
            playerPositions[player - 1] = currentPos;

            // Update the visual representation of the player's position
            updatePlayerPositionOnBoard(player, currentPos);

            // Check if the player has passed GO
            if (currentPos === 0)
            {
                rewardPlayerForPassingGo(player); // Collect $200 when passing GO
            }

            stepsRemaining--;
        }, 300); // Move every 300ms (adjust the delay for your preference)
    }

    /***************************************************************************
     * Function:     updatePlayerPositionOnBoard
     * Purpose:      Updates the player's position on the game board visually.
     * Parameters:   player (Number)    - The player to update (1 or 2)
     *               position (Number)  - The new position of the player on the board
     * Returns:      Void
     ***************************************************************************/
    function updatePlayerPositionOnBoard(player, position)
    {
        const playerElement = $(`#player${player}`);
        const cell = $('section').eq(position);

        // Calculate position within the cell
        const cellOffset = cell.offset();
        const cellWidth = cell.width();
        const cellHeight = cell.height();

        let topPos, leftPos;

        if (cell.hasClass('corner'))
        {
            // Special positioning for corner squares
            topPos = cellHeight * 0.5;
            leftPos = cellWidth * 0.5;
        } else
        {
            // Regular squares - position based on player
            topPos = cellHeight * 0.5;
            leftPos = cellWidth * (player === 1 ? 0.3 : 0.7);
        }

        // Move the player
        playerElement.css({
            top: cellOffset.top + topPos - 15, // 15 is half of icon height
            left: cellOffset.left + leftPos - 15, // 15 is half of icon width
            position: 'absolute'
        });
    }

    /***************************************************************************
     * Function:     rewardPlayerForPassingGo
     * Purpose:      Handles the event when a player passes the GO square.
     * Parameters:   player (Number)    - The player passing GO (1 or 2)
     * Returns:      Void
     ***************************************************************************/
    function rewardPlayerForPassingGo(player)
    {
        playerBalances[player - 1] += 200;
        updatePlayerBalances();
        alert(`Player ${player} passed GO and collected $200!`);
    }

    /***************************************************************************
     * Function:     handlePlayerLanding
     * Purpose:      Handles the event when a player lands on a square.
     * Parameters:   player (Number)    - The player landing (1 or 2)
     *               position (Number)  - The position the player landed on
     *               die1 (Number)      - The value of the first die
     *               die2 (Number)      - The value of the second die
     * Returns:      Void
     ***************************************************************************/
    function handlePlayerLanding(player, position, die1, die2)
    {
        const cell = $('section').eq(position);
        const cellId = cell.attr('id');
        const cellClass = cell.attr('class');
        const cellVal = parseInt(cell.attr('val') || '0');

        // Check what type of square was landed on
        if (cellClass.includes('go'))
        {
            // Already handled passing GO during movement
        }
        else if (cellClass.includes('tax'))
        {
            // Tax square - deduct amount
            playerBalances[player - 1] -= cellVal;
            updatePlayerBalances();
            alert(`Player ${player} landed on ${cell.text()} and paid $${cellVal} in taxes!`);
        }
        else if (cellClass.includes('goToJail'))
        {
            // Go to Jail - move to jail immediately
            playerPositions[player - 1] = 10; // Jail position
            updatePlayerPositionOnBoard(player, 10);
            alert(`Player ${player} landed on Go To Jail and was sent to Jail!`);
        }
        else if (cellClass.includes('jail'))
        {
            // In Jail - pay $50
            playerBalances[player - 1] -= 50;
            updatePlayerBalances();
            alert(`Player ${player} is in Jail and paid $50 to get out!`);
        }
        else if (cellClass.includes('cc') || cellClass.includes('chance'))
        {
            // Community Chest or Chance
            const randomIndex = Math.floor(Math.random() * takeAChanceText.length);
            const amount = takeAChanceMoney[randomIndex];
            playerBalances[player - 1] += amount;
            updatePlayerBalances();
            alert(`Player ${player} landed on ${cell.text()}: ${takeAChanceText[randomIndex]}`);
        }
        else if (cellClass.includes('utility') || cellClass.includes('rr') ||
            cellClass.includes('brown') || cellClass.includes('lightblue') ||
            cellClass.includes('purple') || cellClass.includes('orange') ||
            cellClass.includes('red') || cellClass.includes('yellow') ||
            cellClass.includes('green') || cellClass.includes('blue'))
        {
            // Property square - handle purchasing or paying rent
            handlePropertyTransaction(player, cell, cellId, cellClass, cellVal, die1, die2);
        }

        // Check if player is bankrupt
        if (playerBalances[player - 1] < 0)
        {
            alert(`Player ${player} is bankrupt and loses the game!`);
            // Could add game over logic here
        }

        // Check for doubles
        if (die1 === die2)
        {
            alert(`Player ${player} rolled doubles and gets another turn!`);
            // Same player goes again
            $('#RollDice').prop('disabled', false);
            diceRolling = false;
        } else
        {
            // Switch players
            switchActivePlayer();
        }
    }

    /***************************************************************************
     * Function:     handlePropertyTransaction
     * Purpose:      Handles property-related actions such as purchase or rent.
     * Parameters:   player (Number)    - The player landing on the property (1 or 2)
     *               cell (Object)      - The jQuery cell object representing the square
     *               cellId (String)    - The unique ID of the cell
     *               cellClass (String) - The class of the cell
     *               cellVal (Number)   - The purchase price or rent value of the property
     *               die1 (Number)      - The value of the first die
     *               die2 (Number)      - The value of the second die
     * Returns:      Void
     ***************************************************************************/
    function handlePropertyTransaction(player, cell, cellId, cellClass, cellVal, die1, die2)
    {
        const otherPlayer = player === 1 ? 2 : 1;
        let owner = -1; // -1 means unowned

        // Check if property is owned
        if (propertiesOwned[0].includes(cellId)) owner = 1;
        else if (propertiesOwned[1].includes(cellId)) owner = 2;

        if (owner === -1)
        {
            // Property is unowned - purchase it
            playerBalances[player - 1] -= cellVal;
            propertiesOwned[player - 1].push(cellId);

            // Set property color to player's color
            cell.addClass(`p${player}`);

            // For colored properties, initialize rent
            if (!cellClass.includes('utility') && !cellClass.includes('rr'))
            {
                propertyRents[cellId] = Math.floor(cellVal * 0.1); // 10% of purchase price
            }

            updatePlayerBalances();
            alert(`Player ${player} purchased ${cell.text()} for $${cellVal}!`);
        }
        else if (owner !== player)
        {
            // Property is owned by other player - pay rent
            let rent = 0;

            if (cellClass.includes('utility'))
            {
                // Utility - rent is 5x dice roll
                rent = 5 * (die1 + die2);
            }
            else if (cellClass.includes('rr'))
            {
                // Railroad - $25 per RR owned
                const rrCount = propertiesOwned[owner - 1].filter(id =>
                    $('#' + id).hasClass('rr')).length;
                rent = 25 * rrCount;
            }
            else
            {
                // Colored property - get current rent and increase it
                rent = propertyRents[cellId];
                propertyRents[cellId] = Math.floor(rent * 1.2); // Increase by 20%
            }

            playerBalances[player - 1] -= rent;
            playerBalances[owner - 1] += rent;
            updatePlayerBalances();
            alert(`Player ${player} landed on ${cell.text()} and paid $${rent} rent to Player ${owner}!`);
        }
    }

    /***************************************************************************
     * Function:     switchActivePlayer
     * Purpose:      Switches the active player after each turn.
     * Parameters:   None
     * Returns:      Void
     ***************************************************************************/
    function switchActivePlayer()
    {
        currentPlayer = currentPlayer === 1 ? 2 : 1;

        // Update active player indicator
        $('#player1div').toggleClass('active');
        $('#player2div').toggleClass('active');

        // Update player borders
        $('#player1').toggleClass('player-active', currentPlayer === 1);
        $('#player2').toggleClass('player-active', currentPlayer === 2);

        // Re-enable dice button
        $('#RollDice').prop('disabled', false);
        diceRolling = false;
    }

    /***************************************************************************
     * Function:     updatePlayerBalances
     * Purpose:      Updates the display of each player's balance on the UI.
     * Parameters:   None
     * Returns:      Void
     ***************************************************************************/
    function updatePlayerBalances()
    {
        $('#player1amt').text(`$${playerBalances[0]}`);
        $('#player2amt').text(`$${playerBalances[1]}`);
    }
});
