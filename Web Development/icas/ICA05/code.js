
/**********************************************
*Function Name   : google
*Purpose         : To re-direct user to google.com
*Inputs          : No
*Output          : No
**********************************************/
function google()
{
    console.log("Inside location")
    window.location = "https://www.google.com/";
}
/**********************************************
*Function Name   : setBackground
*Purpose         : To change/set the background color chosen by user
*Inputs          : Pick Color as an Input
*Output          : No
**********************************************/
function setBackground()
{   
    var color = document.getElementById('color').value;
    document.body.style.backgroundColor = color;
}
/**********************************************
*Function Name   : showDimensions
*Purpose         : To show the dimensions of the page
*Inputs          : No
*Output          : No
**********************************************/
function showDimensions()
{
    width = window.innerWidth;
    height = window.innerHeight;

    const inputbox = document.getElementById("inputbox");

    inputbox.value = "["+ height + "," + width+ "]";
   
}

/*****************************************************************
*Function Name   : showTime
*Purpose         : To get current time and display on alert screen
*Inputs          : No
*Output          : No
******************************************************************/
function showTime()
{
    var currentTime = new Date();
    var timeString = currentTime.toTimeString();

    alert('Current Time: ' +timeString);

    document.getElementById('currenttime').textContext = 'Now: ['+timeString +']';
}

/**********************************************
*Function Name   : userAgent
*Purpose         : 
*Inputs          : No
*Output          : No
**********************************************/
function userAgent(button)
{
  var userAgent = navigator.userAgent;

  button.textContent = 'User Agent: '+userAgent;
}

/**********************************************
*Function Name   : promptTest
*Purpose         : To get value from user
*Inputs          : No
*Output          : No
**********************************************/
function promptTest(button)
{
    //get the curent button text
  var textButton = button.textContent;

    // creating prompt string
  var promptTesting = "Your clicked button with text: " +textButton;
 
  // Show the prompt with a default value of 5
  var userPrompt = window.prompt(promptTesting, 5);

  //check to see if the value entered is valid or not
  if(userPrompt === null || isNaN(userPrompt))

  { //output error to console
    console.error('['+userPrompt+'] is Null or Nan');
  }
  else
  { // if input is valud, replace the button text with new enetered value
    button.textContent = 'Prompt Test / [' +userPrompt+ ']';
  }
}

/**************************************************************************************
*Function Name   : createTux
*Purpose         : To increase the size of tux whith each mouse click increments of 20
*Inputs          : No
*Output          : No
***************************************************************************************/
let tuxHeight = 20;
let maxtuxHeight;

function createTux()
{
  
  var image = document.createElement('img');

  image.src = 'image/Tux.png';

  image.height = tuxHeight;

  let tuxLabel = document.getElementById('tuxLbl');
  tuxLabel.appendChild(image);
 
  maxtuxHeight = tuxHeight += 20; 
 
 if (maxtuxHeight > 120)
 { 
   tuxHeight = 20;
   while (tuxLabel.childNodes.length > 1) {
     tuxLabel.removeChild(tuxLabel.lastChild);
   }
 }
}

/**********************************************************************************
*Function Name   : dynamicWidth
*Purpose         : To get user input via slider and change the width of the button
*Inputs          : Input as a slider
*Output          : Change the width of the button according to the value it is at.
**********************************************************************************/
// Attach the mousemove event listener to the range input when the page loads
document.getElementById("rangecontrol").addEventListener("mousemove", dynamicWidth);

function dynamicWidth() {
  // 'this' refers to the range input element
  var rangeValue = this.value;  // Get the current value of the range input

  // Update the width of the button based on the range input value
  document.getElementById("dynamicBtn").style.width = rangeValue + "px";
}


/**********************************************************************************
*Function Name   : tablize()
*Purpose         : To get user input via slider and give table
*Inputs          : Input as a slider
*Output          : table of slider x slider
**********************************************************************************/
function tablize() {
  // Get the row and column values from the range inputs
  var rows = document.getElementById("rowRange").value;
  var cols = document.getElementById("colRange").value;

  // Validate input values
  if (isNaN(rows) || isNaN(cols) || rows <= 0 || cols <= 0) {
    // Show error message if values are invalid
    document.getElementById("output").innerHTML = "<p style='color: red;'>Error: Please enter valid positive numbers for rows and columns.</p>";
    return;
  }

  // Start constructing the multiplication table
  var tableString = "<table><thead><tr><th>X</th>";

  for (let i = 1; i <= cols; i++) {
    tableString += "<td>" + i + "</td>";
  }

  tableString += "</tr></thead><tbody>"

  // Loop through rows and columns to build the table
  for (var i = 1; i <= rows; i++) {
    tableString += "<tr>";
    tableString += "<td>" + i + "</td>";
    for (var j = 1; j <= cols; j++) {
      tableString += "<td>" + (i * j) + "</td>";
    }
    tableString += "</tr>";
  }

  tableString += "</tbody></table>";

  // Display the constructed table in the output div
  document.getElementById("output").innerHTML = tableString;
}


// Function to update the displayed value of the range inputs
function updateRangeValue() {
  var rowValue = document.getElementById("rowRange").value;
  var colValue = document.getElementById("colRange").value;

  // Update the displayed range values next to the sliders
  document.getElementById("rowValue").textContent = rowValue;
  document.getElementById("colValue").textContent = colValue;
}
