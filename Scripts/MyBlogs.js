$(document).ready(function () {
    var Path = window.location.origin;
    GetBlogList();

    function GetBlogList() {
        var Author = $("#AuthorId").val();
        $.ajax({
            type: "GET",
            url: "https://localhost:44372/api/BlogDetails/MyBlogList/" + Author,
            dataType: "json",
            success: function (data) {
                var datavalue = data;
                var myJsonObject = datavalue;
                contentType: "application/json";
                var pDate, bStatus;
                $("#tblBlogs > tbody").empty();
                $("<tr class='bg-info'>" +
                    "<th> Blog Title</th>" +
                    "<th>Published Date</th>" +
                    "<th>Creation Date</th>" +
                    "<th>Status</th>" +
                    "<th>Action</th>" +
                    "</tr>").prependTo($("#tblBlogs>tbody"));
                $.each(myJsonObject, function (i, mobj) {
                    pDate = "";
                    if (mobj.Published_Date != null) {
                        pDate = mobj.Published_Date.split('T')[0];
                    }
                    bStatus = mobj.Status == true ? "Published" : "Draft";
                    $("#tblBlogs").append('<tr><td>' + mobj.Title +
                        '</td><td>' + pDate +
                        '</td><td>' + mobj.Creation_Date.split('T')[0] +
                        '</td><td>' + bStatus +
                        '</td>' + '</td><td><a class="btn btn-success btn-xs rounded-0" href="' + Path + '/Blogs/UpdateBlog/' + mobj.Id + '">Edit</a>&nbsp;&nbsp<button class="btn btn-danger btn-xs rounded-0 btnDelete" bid="' + mobj.Id + '"  type="button"  title="Delete">Delete</button></td></tr>');
                });
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    }
    $("#btnCreateBlog").click(function () {
        window.location.href = Path + "/Blogs/CreateBlog"
    });
    $(document).on('click', '.btnDelete', function () {
        var id = $(this).attr('bid');
        var res = confirm("Are you sure to delete selected blog?");
        if (res == false) {
            return false;
        }
        $.ajax({
            url: Path + '/api/BlogDetails/DeleteBlog/' + id,
            type: 'POST',
            dataType: "json",
            success: function (data) {
                GetBlogList();
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    });

});