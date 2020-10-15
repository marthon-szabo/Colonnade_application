// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const fields = document.querySelectorAll(".form-control");

for (let field of fields) {
    field.addEventListener('keypress', (e) => {
        if (e.key === 'Enter') {
            event.preventDefault();
            console.log(true);
            return false;
        };
    });
};