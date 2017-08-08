


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
            rows += "<td>" + generateRemoveButton(item) + "</td>";
            rows += "<td>" + generateEditButton(item) + "</td>";


            rows += "</tr>";
            rows +=  generateAddButton;
        });


        return rows;
    }
    function generateRemoveButton(item) {
        return "<button class='btn btn-danger'>" + item.Id + "</button>";
        
    }
   generateRemoveButton.onclick = function ()
    {
       
      // $.get("HomeApi/Delete", function (data) { }
        deleteItem();
    }
    //generateRemoveButton.addEventListener("click", function () {
    //    deleteItem(Id);
    //});
    function generateAddButton(item) {
        return "<button class='btn btn-success'>" + "Add" + "</button>";
    }  
    //toddo delete functi[on
    function deleteItem(Id) {
       
        window.console.log(Id);

    }
    function generateEditButton(item) {
        return "<button class='btn btn'>" + item.Id + "</button>";
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