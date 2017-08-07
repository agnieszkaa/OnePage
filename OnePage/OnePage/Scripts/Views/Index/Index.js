
//const ShowContacts = window.Console

var indexList = function () {
    debugger
    $.get("HomeApiController/ShowContacts", function (data) {
        debugger
        //$("table").append(data)
    });
}(); // IIFE imediately invoke function expression
$.ajax({url:"/HomeApi/ShowContacts"})

//<apex:page controller="HomeApiController.cs">
//    <script>

      
//  </script>
//</apex:page >

////$_SERVER
//require('HomeApiController.cs')

//const ShowContacts = window.Console
//$_SERVER['HTTPS'] = false;
//var indexList = function () {
//    debugger
//    $.get("HomeApiController/ShowContacts", function (data) {
//        debugger
//        $("table").append(data)
//    });
//}(); // IIFE imediately invoke function expression

////$(function () {
////    $.getJSON("/HomeApiController/ShowContacts", function (data) {
////        $("table").append(data)
////    });
////});