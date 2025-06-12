/*  Assignment - ICA10
    Author - Sanjay Kumar
    Date - 20 April, 2025 
    Course - CMPE2000 Web Development 
*/

// Wait for the DOM to be fully loaded
$(document).ready(() =>
{
    console.log("On page load");

    yearLoad();  // Load years from 1990 to 2017 into the dropdown

    // Attach click event to the button to trigger vehicle data fetch
    $("#invoke-Request").click(invoke);

    // Attach change event to the manufacturer dropdown to load corresponding vehicle types
    $("#list").change(loadVehicleTypes);
});

// Function to populate the "Year" dropdown with options from 1990 to 2017
function yearLoad()
{
    let yearDropdown = $("#Year");
    console.log(yearDropdown.length);  // Log the dropdown's length for debugging

    // Loop through years and append each as an option
    for (let year = 1990; year <= 2017; year++)
    {
        yearDropdown.append(`<option value="${year}">${year}</option>`);
    }

    console.log("Years populated");  // Confirmation log
}

// Function to load vehicle types for the selected manufacturer
function loadVehicleTypes()
{
    // Get the selected manufacturer from the dropdown
    const manufacturer = $("#list").val();
    const url = `https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMake/${manufacturer}?format=json`;

    // Make AJAX request to fetch vehicle types for the selected manufacturer
    $.ajax({
        url: url,
        type: 'GET',
        dataType: 'json',
        success: function (data)
        {
            console.log(data);  // Log entire response
            console.log("Available vehicle types for", manufacturer, data.Results);  // Log vehicle types

            const typesDropdown = $("#type");
            typesDropdown.empty();  // Clear current dropdown options

            // Add a default "Select Type" option
            typesDropdown.append(`<option value="">Select Type</option>`);

            // Loop through returned types and append each to the dropdown
            data.Results.forEach(type =>
            {
                typesDropdown.append(`<option value="${type.VehicleTypeName}">${type.VehicleTypeName}</option>`);
            });

            console.log("Vehicle types populated for manufacturer:", manufacturer);
        },
        error: function ()
        {
            console.log("Error loading vehicle types");  // Error log
            $("#status").text("Error loading vehicle types.");  // Show error to user
        }
    });
}

// Function to trigger when "Invoke" button is clicked
function invoke()
{
    console.log("Button clicked");

    // Get selected values from dropdowns
    const manufacturer = $("#list").val();
    const year = $("#Year").val();
    const type = $("#type").val();

    // Validate all required fields are selected
    if (!manufacturer || !year || !type || type === "undefined")
    {
        $("#status").text("Please select a valid Manufacturer, Year, and Type.");  // Show warning
        return;  // Stop execution if validation fails
    }

    // Construct API URL with selected values
    const url = `https://vpic.nhtsa.dot.gov/api/vehicles/getmodelsformakeyear/make/${manufacturer}/modelyear/${year}/vehicletype/${type}/?format=json`;

    const requestData = {
        format: 'json'  // Request format
    };

    // Update the status area with a loading message
    $("#status").text(`Request for: ${url} issued. Please wait...`);

    // Make the AJAX request to fetch vehicle models
    AjaxRequest(url, requestData, 'GET', 'json', populateModels, errorHandler);
}

// Generic AJAX request function
function AjaxRequest(serverURL, data, reqMethod, resDataType, successHandler, errorHandler)
{
    console.log("Inside AjaxRequest function");

    // Send AJAX request with provided parameters and handlers
    $.ajax({
        url: serverURL,
        data: data,
        type: reqMethod,
        dataType: resDataType,
        success: successHandler,
        error: errorHandler
    });
}

// Function to display fetched models in the UI
function populateModels(response)
{
    console.log("Response received", response);  // Log full response

    let vehicleType = $("#type").val();  // Get selected vehicle type

    // Show status info from the API response
    $("#status").html(`
            ${response.Message}<br>
            for search :- ${response.SearchCriteria}|VehicleType:${vehicleType}<br>
            ${response.Count} records returned
        `);

    const outputGrid = $("#output");
    outputGrid.empty();  // Clear previous results

    // Loop through models and create HTML elements for each
    response.Results.forEach(model =>
    {
        let modelDiv = $('<div class="model-container"></div>');  // Container for each model
        let radioButton = $(`<input type="radio" name="model" value="${model.Model_ID}">`);
        let label = $(`<label>${model.Model_Name}</label>`);

        // Append radio button and label to container
        radioButton.appendTo(modelDiv);
        label.appendTo(modelDiv);
        modelDiv.appendTo(outputGrid);

        // Add click event to radio button to display selected model ID
        radioButton.on('click', function ()
        {
            $("#status").text(`Selected Model ID: ${model.Model_ID}`);
        });
    });
}

// Function to handle AJAX errors
function errorHandler(xhr, status, error)
{
    console.log("Error occurred:", status, error);  // Log error details
    $("#status").text("There was an error processing your request.");  // Inform user
}
