document.addEventListener("DOMContentLoaded", function () {

    const appWrapper =
        document.getElementById("appWrapper");

    const sidebarToggle =
        document.getElementById("sidebarToggle");

    const sidebar =
        document.getElementById("appSidebar");

    const sidebarOverlay =
        document.getElementById("sidebarOverlay");

    const userProfileButton =
        document.getElementById("userProfileButton");

    const profileDropdown =
        document.getElementById("profileDropdown");

    const backButton =
        document.getElementById("backButton");

    const pageLoader =
        document.getElementById("pageLoader");


    // Dynamic menu
    document.addEventListener(
        "click",
        function (event) {

            const toggle =
                event.target.closest(".menu-toggle");

            if (!toggle) {
                return;
            }

            event.preventDefault();

            const menuId =
                toggle.dataset.menu;

            if (!menuId) {
                return;
            }

            const submenu =
                document.getElementById(menuId);

            if (!submenu) {
                return;
            }

            submenu.classList.toggle("open");
            toggle.classList.toggle("active");
        }
    );


    // Sidebar toggle
    if (sidebarToggle) {

        sidebarToggle.addEventListener(
            "click",
            function () {

                if (window.innerWidth <= 850) {

                    sidebar?.classList.toggle(
                        "mobile-open"
                    );

                    sidebarOverlay?.classList.toggle(
                        "active"
                    );

                } else {

                    appWrapper?.classList.toggle(
                        "sidebar-collapsed"
                    );
                }
            }
        );
    }


    // Mobile overlay
    sidebarOverlay?.addEventListener(
        "click",
        function () {

            sidebar?.classList.remove(
                "mobile-open"
            );

            sidebarOverlay.classList.remove(
                "active"
            );
        }
    );


    // Profile
    if (userProfileButton &&
        profileDropdown) {

        userProfileButton.addEventListener(
            "click",
            function (event) {

                event.stopPropagation();

                userProfileButton
                    .classList
                    .toggle("open");

                profileDropdown
                    .classList
                    .toggle("open");
            }
        );

        document.addEventListener(
            "click",
            function () {

                userProfileButton
                    .classList
                    .remove("open");

                profileDropdown
                    .classList
                    .remove("open");
            }
        );

        profileDropdown.addEventListener(
            "click",
            function (event) {
                event.stopPropagation();
            }
        );
    }


    function updateDateTime() {

        const dateTimeElement =
            document.getElementById(
                "currentDateTime"
            );

        if (!dateTimeElement) {
            return;
        }

        const now = new Date();

        const date =
            now.toLocaleDateString(
                "en-IN",
                {
                    day: "2-digit",
                    month: "short",
                    year: "numeric"
                }
            );

        const time =
            now.toLocaleTimeString(
                "en-IN",
                {
                    hour: "2-digit",
                    minute: "2-digit",
                    second: "2-digit"
                }
            );

        dateTimeElement.textContent =
            `${date} ${time}`;
    }

    updateDateTime();
    setInterval(updateDateTime, 1000);


    if (backButton) {

        backButton.addEventListener(
            "click",
            function () {

                if (window.history.length > 1) {
                    window.history.back();
                } else {
                    window.location.href =
                        "/Dashboard/Index";
                }
            }
        );
    }

});