


var indexList = function () {
    
    $.get("Home/ShowContacts", function (data) {

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
           
           

            rows += "</tr>";
            
        });
        
        
        return rows;
    }
    function generateRemoveButton(item) {
        //var buttonID = ;
        return  "<button onclick = 'indexList.deleteItem(" + '"'+ item.id + '"' + ")' class='btn btn-danger'>" + "delete" + "</button>";
    }
 
    function _deteleItem(id) {
        
        $.ajax({
            url: '/Home/Delete/' + id,
            type: 'DELETE',
            success: function (resp) {

            }
        });
    }


    return {
        deleteItem: _deteleItem
        
    };
}(); // IIFE imediately invoke function expression
