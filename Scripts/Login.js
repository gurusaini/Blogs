$(document).ready(function () {
    $('#AppLogin').click(function () {
        
        if ($("#txtUsername").val() == "" || $("#txtPassword").val() == "") {
            $("#dvMsg").append('<div class="alert alert-danger"><strong>Info!</strong> Username/Password is required</div>');
            return false;
        }
        var data = {
            "userid": $("#txtUsername").val(),
            "password": $("#txtPassword").val()
        };
        $.ajax({
            url: "/Account/ValidateUser",
            //url: "https://localhost:44372/api/Login",
            type: "POST",
            data: JSON.stringify(data),
            dataType: "json",
            contentType: "application/json",
            success: function (response) {
                if (response.Success) {
                    var Path = window.location.origin;
                    window.location.href = Path + "/Blogs/MyBlogs";
                }
                else {
                    alert("Invalid Username/Password");
                }
            },
            error: function () {
                console.log('Login Fail!!!');
            }
        });
    });
});