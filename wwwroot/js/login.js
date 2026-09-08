
// This JavaScript file adds interactive behavior to the login page.
// The HTML/Razor file creates the page, CSS controls its appearance,
// and JavaScript controls what happens when the user interacts with it.
//
// Main features handled in this file:
// 1. Show / hide password
// 2. Show loading state when the login form is submitted
// 3. Prevent multiple login submissions
// 4. Add focus effects to input fields
// ============================================================


// ============================================================
// WAIT FOR THE HTML PAGE TO LOAD
// ============================================================
//
// "document" represents the complete HTML page loaded in the browser.
// "addEventListener()" listens for an event and runs the function when
// that event occurs. "DOMContentLoaded" occurs after the HTML structure
// has finished loading, so our JavaScript can safely find the elements.
//
// We use this because JavaScript needs to access elements such as the
// password textbox and login button. If the script runs before the HTML
// is created, those elements may not be found.
//

document.addEventListener("DOMContentLoaded", function () {


    // FIND THE PASSWORD INPUT

    // "const" creates a variable. A variable is a named place where
    // we store a value. Here, we create a variable called "passwordInput".
    //
    // "document.getElementById()" searches the HTML page for an element
    // having the specified ID. Our Razor input uses asp-for="Password",
    // so ASP.NET Core generates an HTML input with id="Password".
    //
    // Therefore, getElementById("Password") finds that password textbox
    // and stores the element inside the passwordInput variable.

    const passwordInput = document.getElementById("Password");


    // FIND THE PASSWORD TOGGLE BUTTON

    // We need the button that allows the user to show or hide the
    // password. Our HTML button has id="togglePassword".

    // getElementById() finds that button from the HTML page and stores
    // it inside the togglePassword variable for later use.

    const togglePassword = document.getElementById("togglePassword");


    // FIND THE LOGIN FORM

    // Our login form has id="loginForm". We find this form using
    // getElementById() so that we can listen for its submit event.

    // The submit event occurs when the user clicks Sign in or presses
    // Enter while working inside the login form.
    const loginForm = document.getElementById("loginForm");

    // FIND THE LOGIN BUTTON

    // Our Sign in button has id="loginButton". We find this button
    // so that JavaScript can change its state while logging in.

    // We will add a loading animation and disable the button to
    // prevent the user from submitting the login form multiple times.


    const loginButton = document.getElementById("loginButton");

    // SHOW / HIDE PASSWORD

    // "if" is used to make a decision. The code inside the braces
    // runs only when the condition is true.
    //
    // "&&" means AND, so this condition checks that both the
    // togglePassword button and passwordInput element exist.

    if (togglePassword && passwordInput) {


        // LISTEN FOR PASSWORD BUTTON CLICK

        // "addEventListener()" tells JavaScript to watch an HTML
        // element for a specific event. Here, we listen for "click".
        //
        // When the user clicks the password button, the function
        // inside addEventListener() is executed.

        togglePassword.addEventListener("click", function () {

            // CHECK THE CURRENT PASSWORD TYPE

            // Password inputs normally use type="password", which hides
            // the characters. Changing the type to "text" makes them visible.
            //
            // "===" means strictly equal to, so this checks whether the
            // current input type is exactly "password".

            const isPassword = passwordInput.type === "password";

            // CHANGE PASSWORD VISIBILITY

            // "? :" is called the ternary operator and is a shorter way
            // of writing an if/else condition.
            //
            // If isPassword is true, the input type becomes "text",
            // making the password visible. Otherwise it becomes
            // "password", hiding the password again.

            passwordInput.type = isPassword ? "text" : "password";

            // FIND THE EYE ICON

            // "querySelector()" searches inside an HTML element and
            // returns the first element matching the given selector.
            //
            // Our button contains an <i> element for the Font Awesome
            // icon, so querySelector("i") finds that icon.

            const icon = togglePassword.querySelector("i");

            // CHANGE THE EYE ICON

            // "classList" gives access to the CSS classes of an HTML
            // element. "remove()" removes a class and "add()" adds one.
            //
            // When the password becomes visible, we replace the normal
            // eye icon with the eye-slash icon.

            if (isPassword) {
                icon.classList.remove("fa-eye");
                icon.classList.add("fa-eye-slash");

                // "setAttribute()" adds or changes an HTML attribute.
                // aria-label helps screen readers understand what the
                // password button will do for the user.

                togglePassword.setAttribute("aria-label", "Hide password");
            }

            else {
                // When the password becomes hidden again, we remove the
                // eye-slash class and add the normal eye icon class.
                //
                icon.classList.remove("fa-eye-slash");
                icon.classList.add("fa-eye");


                // Update the accessibility label because clicking the
                // button will now show the password.

                togglePassword.setAttribute("aria-label", "Show password");
            }

        });
    }



    // LOGIN BUTTON LOADING STATE

    // We check that both the login form and login button exist before
    // adding the submit functionality.

    if (loginForm && loginButton) {

        // LISTEN FOR FORM SUBMISSION

        // The "submit" event occurs when the login form is submitted.
        // This can happen by clicking Sign in or pressing Enter.

        loginForm.addEventListener("submit", function () {

            // ADD LOADING CLASS

            // "classList.add()" adds a CSS class to an HTML element.
            // Here we add the "loading" class to the login button.
            //
            // Our CSS uses this class to hide the normal Sign in text,
            // show the spinner, and display "Signing in...".

            loginButton.classList.add("loading");

            // DISABLE LOGIN BUTTON

            // "disabled" is an HTML button property. Setting it to true
            // prevents the user from clicking the button again.
            //
            // This helps prevent multiple login requests from being
            // submitted accidentally.
            //
            loginButton.disabled = true;

        });
    }


    // FIND ALL INPUT FIELDS

    // "querySelectorAll()" searches the HTML page and returns all
    // elements matching the given CSS selector.
    //
    // ".form-control" is the CSS class used by our login inputs,
    // so this finds both the Username and Password input fields.

    const inputs = document.querySelectorAll(".form-control");


    // ADD FOCUS EFFECT TO INPUT FIELDS

    // "forEach()" runs the same code once for every element in a
    // collection. Therefore, the following code runs separately
    // for the Username input and the Password input.

    inputs.forEach(function (input) {

        // WHEN INPUT GETS FOCUS

        // The "focus" event occurs when the user clicks inside an input
        // or moves to it using the keyboard.
        //
        // "closest()" searches upward from the current element and finds
        // the nearest parent matching ".input-wrapper".
        //
        // "?.", called optional chaining, means the next operation is
        // performed only if the element exists; otherwise no error occurs.
        input.addEventListener("focus", function () {
            this.closest(".input-wrapper")?.classList.add("focused");
        });

      
        // WHEN INPUT LOSES FOCUS
       
        // The "blur" event occurs when the user leaves an input field
        // and moves the focus somewhere else.
        //
        // We remove the "focused" class so the input wrapper can return
        // to its normal appearance.
        //
        input.addEventListener("blur", function () {

            this.closest(".input-wrapper")
                ?.classList.remove("focused");

        });
    });
});