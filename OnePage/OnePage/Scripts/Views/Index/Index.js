require('HomeApiController.cs')

const ShowContacts = window.Console

var indexList = function () {
    debugger
    $.get("HomeApiController/ShowContacts", function (data) {
        
        $("table").append(data)
    });
}(); // IIFE imediately invoke function expression
