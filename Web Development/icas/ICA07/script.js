/*  Assignment - ICA07 
    Author - Sanjay Kumar 
    Date - 24 March,2025 
    Course - CMPE2000 Web Development 
*/

// Global variables
let picNames = ["Staricase", "Park", "Mountain", "Beach/Mountain", "Beach"]; // Add your image filenames here
let picFrames = [];
let currentIndex = 0;
let auto = false;
let timerID = 0;

// PicFrame constructor (pseudo-class)
function PicFrame(displayName, imageNumber)
{
  this.displayName = displayName;  // The display name of the image
  this.viewCount = 0;  // Number of times the image has been shown
  this.img = new Image();  // Create an Image object
  this.img.src = `images/pic_${imageNumber + 1}.jpg`;  // Assuming the images are stored in the "images" folder
}

// Initialize function to load pictures
function fInit()
{
  for (let i = 0; i < picNames.length; i++)
  {
    picFrames[i] = new PicFrame(picNames[i], i);  // Initialize each PicFrame object
  }
  showPic();  // Show the first image initially
}

// Show picture function
function showPic()
{
  let imgElement = document.getElementById("main-image");
  let viewCountElement = document.getElementById("view-count");

  // Set the src of the image
  imgElement.src = picFrames[currentIndex].img.src;

  // Update the description text and view count
  imgElement.alt = picFrames[currentIndex].displayName;
  viewCountElement.textContent = `${imgElement.alt} Views: ${picFrames[currentIndex].viewCount}`;

  // Increment the view count for the current image
  picFrames[currentIndex].viewCount++;
}

// Function to go to the next image
function fNext()
{
  currentIndex = (currentIndex + 1) % picNames.length;  // Wrap around to the first image
  showPic();
}

// Function to go to the previous image
function fPrev()
{
  currentIndex = (currentIndex - 1 + picNames.length) % picNames.length;  // Wrap around to the last image
  showPic();
}

// Function to start/pause the slideshow automatically
function fAuto()
{
  let autoButton = document.querySelector("#pauseResume");

  if (auto)
  {
    // Clear the interval to stop the slideshow
    clearInterval(timerID);
    auto = false;
    autoButton.textContent = "Pause";  // Change the button text
  } else
  {
    // Set the interval to automatically change the image every 500ms
    auto = true;
    timerID = setInterval(fNext, 500);
    autoButton.textContent = "Resume";  // Change the button text
  }
}

// Event listeners for the buttons
document.querySelector("#previous").addEventListener("click", fPrev);
document.querySelector("#next").addEventListener("click", fNext);
document.querySelector("#pauseResume").addEventListener("click", fAuto);

// Initialize the slideshow when the page loads
window.onload = fInit;
