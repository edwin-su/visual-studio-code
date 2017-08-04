define(['director'], function () {
    var signUp = function () {
        console.log("go to signup page");
        require(['page'], function (page) {
            page.changePage('SignUp');
        });
    }

    var login = function () {
        console.log("go to login page");
        require(['page'], function (page) {
            page.changePage('Login');
        });
    }

    var routes = {
        '/': login,
        '/login': login,
        '/signup': signUp
    }

    var router = Router(routes);
    router.init();
    console.log("finish register router");
})