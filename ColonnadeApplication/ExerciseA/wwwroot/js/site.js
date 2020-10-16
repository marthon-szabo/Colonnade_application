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