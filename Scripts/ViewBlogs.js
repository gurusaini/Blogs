$(document).ready(function () {

    GetBlogList();
    function GetBlogList() {
        var Path = window.location.origin;
        $.ajax({
            type: "GET",
            url: "https://localhost:44372/api/BlogDetails",
            dataType: "json",
            success: function (data) {
                var datavalue = data;
                var myJsonObject = datavalue;
                contentType: "application/json";
                $.each(myJsonObject, function (i, mobj) {
                    $("#tblBlogs").append('<tr><td width="50px">' + mobj.Title +
                        '</td><td width="50px">' + mobj.Author +
                        '</td><td width="50px">' + mobj.Published_Date.split('T')[0] +
                        '</td>' + '</td><td width="50px"><a class="btn btn-success btn-xs rounded-0" href="' + Path + '/Blogs/BlogDetail/' + mobj.Id + '">View Detail</a></td></tr>');
                });
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    }
});