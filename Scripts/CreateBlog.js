$(document).ready(function () {
    var Path = window.location.origin;
    var BlogImage = "", BlogVideo = "";
    $("#spnTitle").hide();
    $("#spnContent").hide();
    $("#btnCreateBlog").click(function () {
        if ($("#txtTitle").val() == "") { $("#spnTitle").show(); return false; } else { $("#spnTitle").hide(); }
        if ($("#txtContent").val() == "") { $("#spnContent").show(); return false; } else { $("#spnContent").hide(); }
        
        var data = {
            "Author": $("#AuthorId").val(),
            "Title": $("#txtTitle").val(),
            "BlogContent": $("#txtContent").val(),
            "Status": $('#chkStatus').is(":checked"),
            "BlogImage": BlogImage,
            "BlogVideo": BlogVideo
        };

        $.ajax({
            type: "POST",
            data: JSON.stringify(data),
            url: "https://localhost:44372/api/BlogDetails/CreateBlog",
            dataType: "json",
            contentType: "application/json",
            success: function (res) {
                $("#dvMsg").append('<div class="alert alert-success"><strong>Success!</strong> Saved successfully.</div>');
                setTimeout(window.location.href = Path + "/Blogs/MyBlogs", 10000);
            },
        });
    });
    $("#btnBack").click(function () {
        window.location.href = Path + "/Blogs/MyBlogs"
    });

    //Upload Blog Image: Start
    $('#fuBlogImage').change(function () {
        if ($('#fuBlogImage').val() == '') {
            alert('Please select file');
            return;
        }
        var formData = new FormData();
        var file = $('#fuBlogImage')[0];
        formData.append('file', file.files[0]);
        BlogImage = file.files[0].name;
        $.ajax({
            url: Path + '/api/UploadFiles',
            type: 'POST',
            data: formData,
            contentType: false,
            processData: false,
            success: function (d) {
                $("#dvImage").html('<span><img src="' + Path + '/Uploads/' + BlogImage + '" alt="' + BlogImage + '" style="height:100px; width:100px;">');
                $('#fuBlogImage').val(null);
            },
            error: function (xhr) {
                alert("Faild please try upload again" + xhr.responseText);
            }
        });
    });
    //Upload Blog Image: End
    //Upload Blog Video: Start
    $('#fuBlogVideo').change(function () {
        if ($('#fuBlogVideo').val() == '') {
            alert('Please select file');
            return;
        }
        var formData = new FormData();
        var file = $('#fuBlogVideo')[0];
        formData.append('file', file.files[0]);
        BlogVideo = file.files[0].name;
        $.ajax({
            url: Path + '/api/UploadFiles',
            type: 'POST',
            data: formData,
            contentType: false,
            processData: false,
            success: function (d) {
                $("#dvVideo").html('<span><video controls style="height:120px; width:120px"><source src="' + Path + '/Uploads/' + BlogVideo + '" type="video/mp4" /></video>');
                $('#fuBlogVideo').val(null);
            },
            error: function (xhr) {
                alert("Please try upload again. Error: " + xhr.responseText);
            }
        });
    });
    //Upload Blog Video: End
});