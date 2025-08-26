function validate() {
    let nameInput = document.getElementById("usernameip");
    let name = nameInput.value.trim();
    let lblName = document.getElementById("lblname");

    if (name.length < 6 || name.length > 8) {
        lblName.innerHTML = "Username should be 6-8 characters.";
        return false;
    } else {
        lblName.innerHTML = "";
    }

    let pinInput = document.getElementById("pinip");
    let pin = pinInput.value.trim();
    let lblPin = document.getElementById("lblpin");

    if (!isAlphaNumeric(pin)) {
        lblPin.innerHTML = "Pin should be alphanumeric.";
        return false;
    } else {
        lblPin.innerHTML = "";
    }

    return true;
}

function isAlphaNumeric(str) {
    const letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const digits = "0123456789";
    for (let i = 0; i < str.length; i++) {
        let char = str[i];
        if (!letters.includes(char) && !digits.includes(char)) {
            return false;
        }
    }
    return true;
}

window.onload = function () {
    document.getElementById("btnsubmit").onclick = function () {
        let lbltxt = document.getElementById("lblvpin");
        if (!validate()) {
            lbltxt.innerHTML = "Please try again!";
        } else {
            window.location.href = "welcome.html"; // Redirect to welcome page
        }
    };
};
