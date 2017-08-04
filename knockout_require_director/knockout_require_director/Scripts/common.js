var paths = {
    'juqery': 'lib/jquery',
    'knockout': 'lib/knockout',
    'knockout-amd-helpers': 'lib/knockout-amd-helpers',
    'director': 'lib/director',
    'text':'lib/text',

    'page': 'framework/page',
    'router': 'framework/router',
    'configured-router': 'framework/configured-routers',

    'Login-html': '../templates/home/Login.html',
    'Login-js': 'app/home/Login',
    'SignUp-html': '../templates/home/SignUp.html',
    'SignUp-js':'app/home/SignUp'
}

var baseUrl = '/';

require.config({
    baeuUrl: baseUrl,
    paths: paths,
    shim: {
        '': {
            exports:''
        }
    }
})


require(['knockout', 'page', 'knockout-amd-helpers', 'text', 'router'], function (ko, page) {
    ko.applyBindings(page);
    //var urlNotAtRoot = window.location.pathname && (window.location.pathname != '/');

   

    //if (urlNotAtRoot) {
    //    router.init();
    //} else {
    //    router.init('/');
    //}
    location.href = '#/login';
});

//require(['login-html', 'login-js'], function (page, viewModel) {
//    page.data = ko.observable({ name: page, data: viewModel });
//});


//page.data = ko.observable({ name: 'login', data:  });


//function change(pageName) {
//    console.log("changing page");
//    require(['page', pageName + '-js'], function (page, viewModel) {
//        page.data({ name: pageName, data: viewModel });
//    });
//}


//change('aaa');



//{ key:'value'}
//change('aaaaa');



