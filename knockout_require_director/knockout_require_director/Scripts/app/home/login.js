define(['knockout'], function (ko) {
    function LoginViewModel() {
        var self = this;
        self.userName = ko.observable();
        self.password = ko.observable();
        self.login = function () {
            var result = confirm("User:" + self.userName() + " has not registered. Please sign up firstly.")
            if (!!result) {
                location.href = '#/signup';
            }
        }
    }

    return new LoginViewModel();
});