/*  Assignment - ICA08
    Author - Sanjay Kumar
    Date - 4 April, 2025 
    Course - CMPE2000 Web Development 
*/

// Global variables
let picNames = ["Staricase", "Park", "Mountain", "Beach/Mountain", "Beach"]; // Add your image filenames here
let picFrames = [];
let currentIndex = 0;
let auto = false;
let timerID = 0;

// PicFrame constructor (pseudo-class)
function PicFrame(displayName, imageNumber) {
  this.displayName = displayName;  // The display name of the image
  this.viewCount = 0;  // Number of times the image has been shown
  this.img = new Image();  // Create an Image object
  this.img.src = `images/pic_${imageNumber + 1}.jpg`;  // Assuming the images are stored in the "images" folder
}

// Initialize function to load pictures
function fInit() {
  for (let i = 0; i < picNames.length; i++) {
    picFrames[i] = new PicFrame(picNames[i], i);  // Initialize each PicFrame object
  }
  showPic();  // Show the first image initially
}

// Show picture function
function showPic() {
  let imgElement = $("#main-image");
  let viewCountElement = $("#view-count");

  // Get the selected transition effect
  let transitionEffect = $("#transitions").val();

  // Check for selected transition speed
  let transitionSpeed = $("input[name='transitionSpeed']:checked").val() || 500;
  transitionSpeed = transitionSpeed / 2; // Divide by 2 to account for total (in + out) transition time

  // Update the description text and view count
  imgElement.prop("alt", picFrames[currentIndex].displayName);
  viewCountElement.text(`${imgElement.prop("alt")} Views: ${picFrames[currentIndex].viewCount}`);

  // Increment the view count for the current image
  picFrames[currentIndex].viewCount++;

  // Apply transition effects based on the selected type
  if (transitionEffect === "fade") {
    // Fade out the current image, then fade in the new image
    imgElement.fadeOut(transitionSpeed, function() {
      imgElement.prop("src", picFrames[currentIndex].img.src);  // Change image source
      imgElement.fadeIn(transitionSpeed);  // Fade in the new image
    });
  } else if (transitionEffect === "slide") {
    // Slide up the current image, then slide down the new image
    imgElement.slideUp(transitionSpeed, function() {
      imgElement.prop("src", picFrames[currentIndex].img.src);  // Change image source
      imgElement.slideDown(transitionSpeed);  // Slide down the new image
    });
  }

  // Adjust the timer interval to account for transition times + viewing time
  let totalTransitionTime = (transitionSpeed * 2) + 500; // Two transition phases (fade or slide) + 500ms for viewing the image
  if (auto) {
    clearInterval(timerID);
    timerID = setInterval(fNext, totalTransitionTime);
  }
}

// Function to go to the next image
function fNext() {
  currentIndex = (currentIndex + 1) % picNames.length;  // Wrap around to the first image
  showPic();
}

// Function to go to the previous image
function fPrev() {
  currentIndex = (currentIndex - 1 + picNames.length) % picNames.length;  // Wrap around to the last image
  showPic();
}

// Function to start/pause the slideshow automatically
function fAuto() {
  let autoButton = $("#pauseResume");

  if (auto) {
    // Clear the interval to stop the slideshow
    clearInterval(timerID);
    auto = false;
    autoButton.text("Pause");  // Change the button text using val() method
  } else {
    // Set the interval to automatically change the image
    auto = true;
    showPic();  // Update the picture and set the correct interval based on transition time
    autoButton.text("Resume");  // Change the button text using val() method
  }
}

// Event listeners for the buttons using jQuery
$(document).ready(function () {
  // Binding event handlers to the buttons inside the ready() function
  $("#previous").click(fPrev);  // Explicit function for "Previous" button
  $("#next").click(function() {  // Anonymous function for "Next" button
    fNext();
  });
  $("#pauseResume").click(function() {  // Anonymous function for "Pause/Resume" button
    fAuto();
  });

  // Initialize the slideshow when the page loads
  fInit();
});
