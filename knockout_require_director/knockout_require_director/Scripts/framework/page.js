define(['knockout'], function (ko) {
    var page = {};
    page.name = ko.observable('Login-html');
    page.data = ko.observable('Login-js');

    page.changePage = function (pageName) {
        require([pageName + '-js'], function (viewModel) {
            page.name(pageName + '-html');
            page.data(viewModel);
        });
    }

    return page;
})