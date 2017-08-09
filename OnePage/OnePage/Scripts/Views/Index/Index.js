


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
            rows += "<td>" + generateAddButton() + "</td>";

            rows += "</tr>";
            
        });
        
        
        return rows;
    }
    function generateRemoveButton(item) {
        return  "<button onclick = 'indexList.deleteItem(" + item.id + ")' class='btn btn-danger'>" + item.id + "</button>";
    }
   
    
    function generateAddButton() {
        //var btn = document.createElement("BUTTON");        // Create a <button> element
        //var t = document.createTextNode("CLICK ME");       // Create a text node
        //btn.appendChild(t);                                // Append the text to <button>
        //document.body.appendChild(btn);                    // Append <button> to <body> 
        return "<button class='btn btn-success'> </button>";
    }  
    //toddo delete functi[on
    function _deteleItem(id) {
        $.ajax({
            url: '/HomeApi/Delete/' + id,
            type: 'DELETE',
            success: function (resp) {
                
            }
        });
       


    }
    function _addItem(id)
    {

    }
    function generateEditButton(item) {
        return "<button onclick = 'indexList.addItem(" + item.id + ")' class='btn btn'>" + item.id + "</button>";
    }


    return {
        deleteItem: _deteleItem
    };
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