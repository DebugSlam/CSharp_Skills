function validatePassword(password) {
    // Rule 1: Length should be 6 - 10 characters (inclusive)
    let valid = true;
    if (password.length < 6 || password.length > 10) {
        console.log("Password must be between 6 and 10 characters");
        valid = false;
    }

    // Rule 2: It should consist only of letters and digits
    if (!/^[a-zA-Z0-9]+$/.test(password)) {
        console.log("Password must consist only of letters and digits");
        valid = false;
    }

    // Rule 3: It should have at least 2 digits
    let digitCount = 0;
    for (let char of password) {
        if (/\d/.test(char)) {
            digitCount++;
        }
    }
    if (digitCount < 2) {
        console.log("Password must have at least 2 digits");
        valid = false;
    }

    // If all rules are satisfied
    if (valid)
{

    console.log("Password is valid");

}

}

validatePassword("login"); // Valid password

