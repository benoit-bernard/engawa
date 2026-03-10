// Engawa — Scroll-triggered reveal animations via IntersectionObserver

window.scrollAnimations = (function () {
    'use strict';

    let observer = null;

    function createObserver() {
        return new IntersectionObserver(
            function (entries) {
                entries.forEach(function (entry) {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('revealed');
                        observer.unobserve(entry.target);
                    }
                });
            },
            { threshold: 0.12, rootMargin: '0px 0px -40px 0px' }
        );
    }

    function init() {
        if (observer) {
            observer.disconnect();
        }
        observer = createObserver();
        document.querySelectorAll('[data-reveal]').forEach(function (el) {
            observer.observe(el);
        });
    }

    function reinit() {
        init();
    }

    return { init: init, reinit: reinit };
})();

window.contactService = {
    sendMail: function (to, subject, body) {
        var href = 'mailto:' + to
            + '?subject=' + encodeURIComponent(subject)
            + '&body=' + encodeURIComponent(body);
        window.location.href = href;
    }
};
