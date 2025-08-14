let users = new Map(JSON.parse(localStorage.getItem("UserInfo")) || []);
function signin(name,password){
    // debugger;
        if (users.has(name)) {
            if (users.get(name) === password) {
                // alert("Welcome back, " + name + "!");
                document.body.innerHTML=`
                <h1> Hi ${name}</h1>
                <a href="./homepage.html>`
            } else {
                alert("Incorrect password. Try again.");
            }
        } else {
            alert("User does not exist. Please sign up.");
        }
}

window.addEventListener("load", function (e) {
    e.preventDefault();
    document.getElementById("btnsignin").addEventListener("click", function () {
        let name = document.getElementById("username").value;
        let password = document.getElementById("password").value;
        signin(name, password);
    });
    document.getElementById("btnsignup").addEventListener("click", function () {
        let name = document.getElementById("username").value;
        let password = document.getElementById("password").value;
        signup(name, password);
    });
});

function signup(name, password) {
        if (users.has(name)) {
            alert("User with the name " + name + " already exists.");
        } else if (password.length < 6) {
            alert("Password should be a minimum of 6 characters!");
        } else {
            users.set(name, password);
            localStorage.setItem("UserInfo", JSON.stringify(Array.from(users.entries())));
            // alert("Sign up successful! Please log in.");
            document.body.innerHTML = `
                <h1>Hi ${name}</h1>
                <a href="./homepage.html">Go to Homepage</a>
            `;
            window.location.href = "homepage.html";
        }
  
}
