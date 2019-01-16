/*================================================================================
	Item Name: Materialize - Material Design Admin Template
	Version: 4.0
	Author: PIXINVENT
	Author URL: https://themeforest.net/user/pixinvent/portfolio
================================================================================

NOTE:
------
PLACE HERE YOUR OWN JS CODES AND IF NEEDED.
WE WILL RELEASE FUTURE UPDATES SO IN ORDER TO NOT OVERWRITE YOUR CUSTOM SCRIPT IT'S BETTER LIKE THIS. */

var layoutMenuItem = {
    SetActiveMenuItem: function (id) {
        var menuItems = $("[id$='-menu-item']");
        menuItems.removeClass("active");
        if (id !== undefined && id !== "") {
            var menuItemActive = $("#" + id);
            if (menuItemActive.length > 0) {
                menuItemActive.addClass("active");
            }
        }
    },
    ClearActiveMenuItem: function () {
        var menuItems = $("[id$='-menu-item']");
        menuItems.removeClass("active");
    }
};