/*  Assignment - ICA09
    Author - Sanjay Kumar
    Date - 14 April, 2025 
    Course - CMPE2000 Web Development 
*/

// URLs for API endpoints
let HobbyURL = "https://thor.cnt.sast.ca/~demo/cmpe2000/ica_Hobby.php";
let TableURL = "https://thor.cnt.sast.ca/~demo/cmpe2000/ica_Table.php";
let NumbersURL = "https://thor.cnt.sast.ca/~demo/cmpe2000/ica_Numbers.php";
let FailURL = "https://thor.cnt.sast.ca/~demo/cmpe200/ica_Numbers.php"; // Intentionally incorrect URL for testing error handling

// Initialize the page when the DOM is ready
$(document).ready(function ()
{
    console.log("On Page Load");

    // Handle 'Call with GET' button click event
    $('#getButton').click(function () 
    {
        console.log("GET Button Clicked");

        // Gather input values from form fields
        let name = $('#nameData').val();
        let hobby = $('#hobbyData').val();
        let like = $('#likeData').val();

        // Prepare the data object to send in the GET request
        let data = {
            Name: name,
            Hobby: hobby,
            HowMuch: like - 1 // Subtract 1 from the 'like' value to send
        };

        // Call MakeAjaxCall function to perform the GET request
        MakeAjaxCall(
            HobbyURL,
            data,
            "GET",           // Method type (GET)
            "html",          // Expected response type (HTML)
            successHobby,    // Success handler for the response
            errorHandler     // General error handler
        );
    });

    // Update the button text dynamically based on range input values
    $('#rowRange, #colRange').change(function () 
    {
        let rows = $('#rowRange').val();
        let cols = $('#colRange').val();
        $('#createTable').text(`Post to make ${rows}X${cols} table`);
    });

    // Handle button click to make a POST request and display a table
    $('#createTable').click(function () 
    {
        console.log("Create Table Button Clicked");

        // Prepare the data to be sent in the POST request
        let postData = {
            RowCount: $('#rowRange').val(),
            ColumnCount: $('#colRange').val()
        };

        // Make the AJAX call to create a table
        MakeAjaxCall(
            TableURL,
            postData,
            "POST",          // Method type (POST)
            "html",          // Expected response type (HTML)
            successTable,    // Success handler for the table response
            errorHandler     // General error handler
        );
    });

    // Generate an array of random numbers when the 'Generate Numbers' button is clicked
    let numbersArray = [];

    $('#generate').click(function () 
    {
        console.log("Generate Numbers clicked");

        // Clear previous array and populate it with 20 random integers between 0 and 20
        numbersArray = [];
        for (let i = 0; i < 20; i++) 
        {
            numbersArray.push(Math.floor(Math.random() * 21)); // Random number between 0 and 20
        }

        // Display the generated numbers as a comma-separated string
        $('#arrayDispaly').text('Generated Numbers: ' + numbersArray.join(', '));
    });

    // Handle 'Post and Show Modified' button click event
    $('#modify').click(function () 
    {
        console.log("Post and Show Modified clicked");

        // Prepare the data object with the generated numbers
        let postData = {
            Numbers: numbersArray
        };

        // Make the POST request to modify the numbers and show the result
        MakeAjaxCall(
            NumbersURL,
            postData,
            'POST',          // Method type (POST)
            'html',          // Expected response type (HTML)
            successModifiedNumbers, // Success handler for the modified numbers
            errorHandler     // General error handler
        );
    });

    // Handle 'Fail!' button click event to trigger an error condition
    $('#fail').click(function () 
    {
        console.log("Fail! button clicked");

        // Use the general-purpose Ajax call with an incorrect URL to force an error
        MakeAjaxCall(
            FailURL,
            {},               // No data is sent with the request
            "GET",            // Method type (GET)
            "html",           // Expected response type (HTML)
            failSuccess,      // Success function (should not be called)
            errorHandler      // Error handler
        );
    });
});

// Success handler for hobby GET request
function successHobby(response, textStatus)
{
    console.log("GET done: " + textStatus);

    // Update the HTML with the server's response (show the 'like' value)
    $('#likeValue').html(response);
}

// Success handler for table creation POST request
function successTable(data, textStatus)
{
    console.log("Table Load Success: " + textStatus);

    // Display the dynamically created table in the #ouputTable div
    $('#ouputTable').html(data);
}

// Success handler for modifying the numbers and displaying them
function successModifiedNumbers(response, textStatus)
{
    console.log("POST done: " + textStatus);

    // Display the modified numbers in the #modArray div
    $('#modArray').text('Modified Numbers: ' + response);
}

// Dummy success handler just in case (should not be triggered)
function failSuccess(jqXHR, response, textStatus)
{
    console.log("Unexpected success: " + textStatus);

    // Display the unexpected success response in the #serverResponse div
    $('#serverResponse').text("Unexpected Success: " + response);
}

// General error handler to handle any error in the AJAX requests
function errorHandler(ajaxReg, textStatus, errorThrown)
{
    console.log("Error: " + textStatus);
    console.log("Error details: " + errorThrown);

    // Display the error details in the #serverResponse div
    $('#serverResponse').html(`Error: ${textStatus}, ${errorThrown}`);
    $('#serverResponse').css("color", "red"); // Change text color to red to indicate an error
}

// Generic AJAX function to perform AJAX requests with given parameters
function MakeAjaxCall(serverURL, data, reqMethod, resDataType, successHandler, errorHandler)
{
    console.log("Inside Make Ajax call function");

    // AJAX request options
    let ajaxOption = {
        url: serverURL,     // URL for the server request
        data: data,         // Data to send with the request
        type: reqMethod,    // Request method (GET or POST)
        dataType: resDataType, // Expected response type (HTML, JSON, etc.)
        success: successHandler, // Function to call on successful response
        error: errorHandler    // Function to call on error response
    };

    console.log(ajaxOption); // Log the request options to the console for debugging

    // Make the actual AJAX request
    $.ajax(ajaxOption);
}
