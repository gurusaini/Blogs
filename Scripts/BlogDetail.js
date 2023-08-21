$(document).ready(function () {
    GetBlogDetail();

    function GetBlogDetail() {
        var id = $("#BlogId").val();
        $.ajax({
            url: 'https://localhost:44372/api/BlogDetails/' + id,
            type: 'GET',
            dataType: "json",
            success: function (data) {
                var datavalue = data;
                var myJsonObject = datavalue;
                $('<tr><th>Author</th><td>' + myJsonObject.Author + '</td><td></tr>' +
                    '<tr><th>Creation Date</th><td>' + myJsonObject.Creation_Date.split('T')[0] + '</td><td></tr>' +
                    '<tr><th>Published Date</th><td>' + myJsonObject.Published_Date.split('T')[0] + '</td><td></tr>' +
                    '<tr><th>Title</th><td>' + myJsonObject.Title + '</td><td></tr>' +
                    '<tr><th>Content</th><td>' + myJsonObject.BlogContent + '</td><td></tr>' +
                    '<tr><th>Image</th><td>' + myJsonObject.BlogImage + '</td><td></tr>' +
                    '<tr><th>Video</th><td>' + myJsonObject.BlogVideo + '</td><td></tr>'
                ).appendTo('#tblBlogDetail');
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    }
});