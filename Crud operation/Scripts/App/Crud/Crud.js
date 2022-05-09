function get() {
    var requestUrl = getEndpointPrefix() + "Crud/GetCrud";

    $.ajax({
        type: "GET",
        url: requestUrl,
        success: function (result) {
            console.log(result)


            var data = result;
            var rowid = 0;
            var siteRows = "";

            if (result.length != 0) {
                $.each(data, function (i) {
                    siteRows += "<tr ><td class='text-center'>" +
                        "<input type='text'  id='Name " + rowid + "'  value = '" + data[i].Name + "' \"></td><td>" +
                        "<input type='text'  id='Email " + rowid + "' value = '" + data[i].Email + "' \"></td><td>";
                    rowid++;
                });
                $('#CrudListTable tbody').html(siteRows);

            }
            else {
                var row = "<tr><td colspan='8'><div class='text-center mt-3'><strong>No Data Available</strong></div></td></tr>";
                $('#CrudListTable tbody').html(row);
            }



        },
        error: function (error) {
            alert(error)
        },
    });

}