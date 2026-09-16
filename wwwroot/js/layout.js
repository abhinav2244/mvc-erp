document.addEventListener("DOMContentLoaded", function () {


    const appWrapper =
        document.getElementById("appWrapper");

    document.addEventListener("click", function (event) {

        const toggle = event.target.closest(".menu-toggle");

        if (!toggle) {
            return;
        }

        event.preventDefault();

        const menuId = toggle.dataset.menu;

        if (!menuId) {
            return;
        }

        const submenu = document.getElementById(menuId);

        if (!submenu) {
            console.log("Submenu not found:", menuId);
            return;
        }

        submenu.classList.toggle("open");
        toggle.classList.toggle("active");
    });

});
document.addEventListener("DOMContentLoaded", function () {

    /* =====================================================
       ELEMENT REFERENCES
       ===================================================== */

    const appWrapper = document.getElementById("appWrapper");


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

    /* =====================================================
       SIDEBAR TOGGLE
       
       Desktop:
       Collapse sidebar.

       Mobile:
       Open/close sidebar.
       ===================================================== */

    if (sidebarToggle) {

        sidebarToggle.addEventListener("click", function () {

            if (window.innerWidth <= 850) {

                // Mobile sidebar
                sidebar.classList.toggle("mobile-open");

                if (sidebarOverlay) {
                    sidebarOverlay.classList.toggle("active");
                }

            } else {

                // Desktop sidebar
                appWrapper.classList.toggle("sidebar-collapsed");

            }

        });

    }


    /* =====================================================
       MOBILE OVERLAY
       Clicking outside the sidebar closes it.
       ===================================================== */

    if (sidebarOverlay) {

        sidebarOverlay.addEventListener("click", function () {

            sidebar.classList.remove("mobile-open");

            sidebarOverlay.classList.remove("active");

        });

    }


    /* =====================================================
       SUBMENU TOGGLE
       ===================================================== */

    const menuToggles =
        document.querySelectorAll(".menu-toggle");

    menuToggles.forEach(function (toggle) {

        toggle.addEventListener("click", function () {

            const menuId =
                toggle.getAttribute("data-menu");


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



            // Close other submenus
            document
                .querySelectorAll(".sidebar-submenu.open")
                .forEach(function (otherMenu) {

                    if (otherMenu !== submenu) {

                        otherMenu.classList.remove("open");

                        const otherToggle =
                            document.querySelector(
                                `[data - menu= "${otherMenu.id}"]`
                            );

                        if (otherToggle) {
                            otherToggle.classList.remove("open");
                        }

                    }

                });


            // Toggle selected submenu
            submenu.classList.toggle("open");

            toggle.classList.toggle("open");

        });

    });


    /* =====================================================
       USER PROFILE DROPDOWN
       ===================================================== */

    if (userProfileButton && profileDropdown) {

        userProfileButton.addEventListener("click", function (event) {

            event.stopPropagation();

            userProfileButton.classList.toggle("open");

            profileDropdown.classList.toggle("open");

        });


        // Close dropdown when clicking elsewhere
        document.addEventListener("click", function () {

            userProfileButton.classList.remove("open");

            profileDropdown.classList.remove("open");

        });


        // Prevent dropdown click from closing itself
        profileDropdown.addEventListener("click", function (event) {

            event.stopPropagation();

        });

    }


    /* =====================================================
       CURRENT DATE AND TIME
       ===================================================== */


    function updateDateTime() {

        const dateTimeElement =

            document.getElementById(
                "currentDateTime"
            );

            document.getElementById("currentDateTime");


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

        const now = new Date();


        const date = now.toLocaleDateString(
            "en-IN",
            {
                day: "2-digit",
                month: "short",
                year: "numeric"
            }
        );


        const time = now.toLocaleTimeString(
            "en-IN",
            {
                hour: "2-digit",
                minute: "2-digit",
                second: "2-digit"
            }
        );


        dateTimeElement.textContent =
            `${ date } ${ time } `;

    }


    updateDateTime();

    // Update every second
    setInterval(updateDateTime, 1000);


    /* =====================================================
       PAGE LOADER
       
       Shows a thin blue progress bar while navigating.
       ===================================================== */

    function showPageLoader() {

        if (!pageLoader) {
            return;
        }

        pageLoader.classList.add("active");

    }


    function hidePageLoader() {

        if (!pageLoader) {
            return;
        }

        pageLoader.classList.remove("active");

    }


    // Hide loader after initial page load
    window.addEventListener("load", function () {

        hidePageLoader();

    });


    /* =====================================================
       LINK NAVIGATION LOADER
       ===================================================== */

    document.addEventListener("click", function (event) {

        const link =
            event.target.closest("a");

        if (!link) {
            return;
        }


        const href =
            link.getAttribute("href");


        // Ignore empty/hash/javascript links
        if (
            !href ||
            href === "#" ||
            href.startsWith("javascript:")
        ) {
            return;
        }


        // Ignore external links
        if (
            link.target === "_blank" ||
            link.origin !== window.location.origin
        ) {
            return;
        }


        showPageLoader();

    });


    /* =====================================================
       BACK BUTTON
       ===================================================== */

    if (backButton) {

        backButton.addEventListener("click", function () {

            if (window.history.length > 1) {

                window.history.back();

            } else {

                // Fallback if there is no browser history
                window.location.href = "/Dashboard/Index";

            }

        });

    }


    /* =====================================================
       MOBILE RESIZE HANDLING
       ===================================================== */

    window.addEventListener("resize", function () {

        if (window.innerWidth > 850) {

            sidebar.classList.remove("mobile-open");

            if (sidebarOverlay) {
                sidebarOverlay.classList.remove("active");
            }

        }

    });

});

