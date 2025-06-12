/*
Assignment - ICA06 
Author - Sanjay Kumar 
Date - 17 March, 2025 
Course - CMPE2000 Web Development
*/

// Select various HTML elements to interact with
let modelRadios = document.querySelectorAll("input[name=model]"); // All radio buttons for model selection
let systemCheckbox = document.querySelectorAll("input[type=checkbox]"); // All checkboxes for options
let downPaymentInput = document.querySelector("input[name=down_payment]"); // Down payment input field
let totalCost = document.querySelector("input[name=total_cost]"); // Hidden input to store total cost
let statusOutput = document.querySelector("#status_output"); // Output field for status messages
let form = document.querySelector("form"); // The form element to validate before submission

// This function runs once the page is loaded
window.onload = () => {
    console.log("ON page load");

    // Set up event handler to change the bike image when the dropdown value changes
    document.querySelector("#dropDown").onchange = AddPicture;

    // Initialize the state by unchecking all radios, checkboxes, and resetting down payment
    UpdateMake();

    // Bind the 'click' event to all model radio buttons to handle model selection
    modelRadios.forEach(radio => radio.addEventListener("click", updateModel));

    // Bind the 'click' event to all option checkboxes to invoke updateStatus when options are selected
    systemCheckbox.forEach(checkbox => checkbox.addEventListener("click", updateStatus));

    // Bind the 'change' event of the down payment field to invoke updateStatus
    downPaymentInput.addEventListener("change", () => updateStatus());

    // Bind the 'submit' event to validate the form before submission
    form.addEventListener("submit", validate);

    // Explicitly invoke updateStatus on page load to ensure the initial state is valid
    updateStatus();
}

// Function to change the bike image when the dropdown selection changes
function AddPicture() {
    console.log("inside drop down");
    console.log(this.value);

    // Remove any existing images before adding a new one
    let bikeImageContainer = document.querySelector("#bikeImage");

    // Clear all child elements except for the first (the container)
    while (bikeImageContainer.children.length > 1) {
        bikeImageContainer.removeChild(bikeImageContainer.lastChild);
    }

    // Create a new image element
    let image = new Image();

    // Check which brand was selected and set the corresponding image
    if (this.value === "Honda") {
        image.setAttribute("src", "image/Honda.avif");
        image.setAttribute("alt", "image is not available");
    } else if (this.value === "Ducati") {
        image.setAttribute("src", "image/Ducati.avif");
        image.setAttribute("alt", "image is not available");
    } else if (this.value === "Harley") {
        image.setAttribute("src", "image/Harley.avif");
        image.setAttribute("alt", "image is not available");
    }

    // Get the dropdown list to fetch its height for image sizing
    let DropdownList = document.querySelector("#dropDown");
    let listStyle = window.getComputedStyle(DropdownList);

    // Set the height of the image based on the dropdown list's height
    image.setAttribute("height", listStyle.getPropertyValue("height"));

    // Append the image to the bike image container
    bikeImageContainer.appendChild(image);
}

// Function to reset the state of the form (uncheck radios, checkboxes, reset down payment)
function UpdateMake() {
    console.log("Inside radio buttons");

    // Uncheck all model radio buttons
    modelRadios.forEach(radio => radio.checked = false);

    // Uncheck all system option checkboxes
    systemCheckbox.forEach(checkbox => checkbox.checked = false);

    // Clear the down payment input value
    downPaymentInput.textContent = "";

    // Update the status output
    updateStatus();
}

// Function to handle changes in model selection (radio buttons)
function updateModel() {
    console.log("Inside model radio");
    console.log(this.value);

    // If the selected model has a cost less than $10,000, disable the system options
    if (this.value < 10000) {
        systemCheckbox.forEach(checkbox => checkbox.checked = false);
        systemCheckbox.forEach(checkbox => checkbox.disabled = true); // Disable the options checkboxes
    } else {
        // If the model cost is $10,000 or more, enable the options checkboxes
        systemCheckbox.forEach(checkbox => checkbox.checked = false);
        systemCheckbox.forEach(checkbox => checkbox.disabled = false);
    }

    // Update the status after model selection
    updateStatus();
}

// Function to update the status based on the form inputs (selected brand, model, options, and down payment)
function updateStatus() {
    // Get the selected brand (dropdown)
    let selectedBrand = document.querySelector("select").value;

    // Get the selected model (radio button)
    let selectedModel = document.querySelector("input[name='model']:checked");

    // Get the selected options (checkboxes)
    let selectedOptions = Array.from(systemCheckbox).filter(opt => opt.checked);

    // Get the down payment value and trim any extra spaces
    let downPaymentValue = downPaymentInput.value.trim();

    // Check if the down payment input is empty or contains invalid characters (non-numeric)
    if (downPaymentValue === "" || isNaN(downPaymentValue)) {
        statusOutput.textContent = "Invalid Downpayment"; // Display an error message
        downPaymentInput.focus(); // Focus the down payment input field
        downPaymentInput.select(); // Select the text for easier correction
        return false; // Stop the function and prevent further validation
    }

    // Convert the down payment value to a float
    let downPayment = parseFloat(downPaymentValue);

    // Ensure the brand and model are selected
    if (!selectedBrand) {
        statusOutput.textContent = "No Make Selected"; // Error message for no brand selected
        return false; // Stop further execution
    }

    if (!selectedModel) {
        statusOutput.textContent = "No Model Selected"; // Error message for no model selected
        return false; // Stop further execution
    }

    // Get the model's cost and the total cost of selected options
    let modelCost = parseInt(selectedModel.value);
    let optionsCost = selectedOptions.reduce((sum, opt) => sum + parseInt(opt.value), 0);

    // Calculate the total cost including the model and options
    let totalCostInput = modelCost + optionsCost;

    // Calculate the remaining balance after the down payment
    let balance = totalCostInput - downPayment;

    // Check if the down payment is less than half of the total cost
    if (downPayment < totalCostInput / 2) {
        statusOutput.textContent = "Down payment must be at least half the total cost."; // Show an error if condition is met
        downPaymentInput.focus(); // Focus the down payment input for correction
        downPaymentInput.select(); // Select the text to allow user to easily correct it
        return false; // Stop further execution
    }

    // Set the hidden input field to hold the total cost (for form submission)
    totalCost.value = totalCostInput;

    // Display the status output with a summary of the selection and calculations
    statusOutput.textContent = `Selection: ${selectedBrand} : $${modelCost} : ${selectedOptions.length} options selected
        $${modelCost} + $${optionsCost} - $${downPayment} = $${balance}`;

    return true; // Return true to indicate that the validation passed
}

// Function to validate the form before submission
function validate(event) {
    // If the updateStatus function returns false (validation failed), prevent form submission
    if (!updateStatus()) {
        event.preventDefault(); // Prevent form submission
        return false; // Return false to indicate validation failed
    }
    return true; // Return true to allow form submission
}

