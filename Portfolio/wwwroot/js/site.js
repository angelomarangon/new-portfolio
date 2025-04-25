// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(() => {
    document.addEventListener("DOMContentLoaded", () => {
        let text = document.getElementById("typewriter-text");

        setInterval(() => {
            const newText = text.cloneNode(true);
            text.parentNode.replaceChild(newText, text);
            text = newText; // 🔁 Actualizamos la referencia para la próxima repetición
        }, 10000); // 10 segundos
    });


    document.addEventListener("DOMContentLoaded", () => {
        const cards = document.querySelectorAll('.animate-card-left, .animate-card-right');

        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add('visible');
                }
            });
        }, {
            threshold: 0.5
        });

        cards.forEach(card => observer.observe(card));
    });


    
})();
