
//const ShowContacts = window.Console

var indexList = function () {
    
    $.get("HomeApi/ShowContacts", function (data) {

        var rowsHtml = generateRowHtml(data);
        appendRowsHtmlToTable(rowsHtml);
     
    });
    function appendRowsHtmlToTable(rows) { 

        $('#myTable > tbody:last-child').append(rows);

    }
    function generateRowHtml(data) {

        var rows = "";

        data.forEach(function (item, i) {

            var index = i + 1;
            rows += "<tr>";

            rows += "<td>" + index + "</td>";
            rows += "<td>" + item.name + "</td>";
            rows += "<td>" + item.lastName + "</td>";
            rows += "<td>" + genrateRemoveButton(item)+ "</td>";

            rows += "</tr>";

        });

        return rows;
    }
    function genrateRemoveButton(item) {
        return "<button class='btn btn-danger'>" + item.Id + "</button>";
    }
    //toddo delete functi[on
    function deleteItem(id) {
        window.console.log(id)
    }

}(); // IIFE imediately invoke function expression
//$.ajax({url:"/HomeApi/ShowContacts"})

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