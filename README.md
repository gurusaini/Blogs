# Blogs
This is a simple blog web application developer in MVC 5.2.7, Entity Framework 6.1.2, jQuery and other related technical stuff.
The goal is to develop a web application using MVC 5.2.7 Entity Framework 6.1.3, where guest user can visit blog list created by different bloggers and can see any blog detail by clicking on View Detail button. And a logged in user has access to see My Blogs, Create Blog and Update Blog apart from the guest user access. Also logged in user has access to delete any blog created by him/her.
System request(s) are generated through jQuery and processed through Web API controller(s).

Following is the database architecture

Database Tables
-----------
1. tblAuthor
2. tblBlogs


Stored Procedures created
------------------------------
1. LoginUser
2. ViewBlogs
3. Blogs_CreateUpdate
4. ViewBlogDetail
5. DeleteBlog
6. MyBlogs

Followings are the application steps:

1. View Blogs: For both guest and logged in users. Click on View Detail button to see the blog detail.

2. Blog Detail: For both guest and logged in users. Click on << Back button to go back on previous page

3. Login screen to login in the system. Username=admin, Password=admin

4. Once a user logged in successfully, user will be redirected to My Blogs page. Where logged in user can see the list of blogs created by him/her. Click on Edit button to edit the blog. And click on Delete button to delete the selected blog.

5. System will confirm from the user before to delete.

6. Blog Edit
Click on << Back button to go back on previous screen. Click on submit button to save the updates. 

7. User can create a new blog by clicking on Create Blog button on My Blogs page. User will be redirected to create blog screen when click on Create Blog button. Required field validation is implemented on some fields.

8. System will logout the user, after clicking on Logout button.


   
 




