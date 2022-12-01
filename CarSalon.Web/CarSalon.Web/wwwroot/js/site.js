// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    const btnBra = document.getElementById('btnBra');
    btnBra.addEventListener('click', () => {
        const form = document.getElementById('formBra');
        if (form.classList.contains("d-none")) {
            form.classList.remove("d-none");
            } else {
            form.classList.add("d-none");
            }
    });

    const btnMod = document.getElementById('btnMod');
    btnMod.addEventListener('click', () => {
        const form = document.getElementById('formMod');
        if (form.classList.contains("d-none")) {
            form.classList.remove("d-none");
            } else {
            form.classList.add("d-none");
            }
    });
    const btnEqu = document.getElementById('btnEqu');
    btnEqu.addEventListener('click', () => {
        const form = document.getElementById('formEqu');
        if (form.classList.contains("d-none")) {
            form.classList.remove("d-none");
            } else {
            form.classList.add("d-none");
            }
    });
    const btnEqmo = document.getElementById('btn');
    btnEqmo.addEventListener('click', () => {   
        const form = document.getElementById('form_eqmo');
        if (form.classList.contains("d-none")) {

            form.classList.remove("d-none");
            } else {
            form.classList.add("d-none");
            }
    });
