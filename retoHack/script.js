function recoverPage() {
    document.getElementById('error-container').style.display = 'none';
    let landing = document.getElementById('landing');
    landing.style.display = 'block';
    setTimeout(() => {
        landing.style.opacity = '1';
    }, 50);
    localStorage.setItem('pageRecovered', 'true');
}

window.onload = function() {
    if (localStorage.getItem('pageRecovered') === 'true') {
        document.getElementById('error-container').style.display = 'none';
        let landing = document.getElementById('landing');
        landing.style.display = 'block';
        setTimeout(() => {
            landing.style.opacity = '1';
        }, 50);
    }
};
document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector('form');
    form.addEventListener('submit', function (e) {
        e.preventDefault();
        alert("¡Tu mensaje ha sido enviado! ¡Gracias por ponerte en contacto con nosotros!");
        this.reset();
    });

    // Modo claro/oscuro
    const modeToggle = document.getElementById('mode-toggle');
    const body = document.body;

    // Chequear si ya hay una preferencia guardada
    if (localStorage.getItem('theme') === 'light') {
        body.classList.add('light-mode');
        modeToggle.textContent = 'Modo Oscuro';
    }

    modeToggle.addEventListener('click', function() {
        body.classList.toggle('light-mode');
        
        if (body.classList.contains('light-mode')) {
            modeToggle.textContent = 'Modo Oscuro';
            localStorage.setItem('theme', 'light');
        } else {
            modeToggle.textContent = 'Modo Claro';
            localStorage.removeItem('theme');
        }
    });
    
});
// Función para mostrar una sección específica y ocultar las demás
function showSection(sectionId) {
    // Ocultar todas las secciones
    const sections = document.querySelectorAll('.section-content');
    sections.forEach(section => {
        section.classList.remove('active');
    });

    // Mostrar la sección seleccionada
    const selectedSection = document.getElementById(sectionId);
    if (selectedSection) {
        selectedSection.classList.add('active');
    }
}

// Al cargar la página, mostrar la primera sección
document.addEventListener('DOMContentLoaded', function() {
    showSection('inicio');
});

let mostrador = document.getElementById("mostrador");
let seleccion = document.getElementById("seleccion");
let imgSeleccionada = document.getElementById("img");
let modeloSeleccionado = document.getElementById("modelo");
let descripSeleccionada = document.getElementById("descripcion");
let precioSeleccionado = document.getElementById("precio");

function cargar(item){
    quitarBordes();
    mostrador.style.width = "60%";
    seleccion.style.width = "40%";
    seleccion.style.opacity = "1";
    item.style.border = "2px solid red";

    imgSeleccionada.src = item.getElementsByTagName("img")[0].src;

    modeloSeleccionado.innerHTML =  item.getElementsByTagName("p")[0].innerHTML;

    descripSeleccionada.innerHTML = "Descripción del modelo ";

    precioSeleccionado.innerHTML =  item.getElementsByTagName("span")[0].innerHTML;


}
function cerrar(){
    mostrador.style.width = "100%";
    seleccion.style.width = "0%";
    seleccion.style.opacity = "0";
    quitarBordes();
}
function quitarBordes(){
    var items = document.getElementsByClassName("item");
    for(i=0;i <items.length; i++){
        items[i].style.border = "none";
    }
}