CREATE DATABASE BlogDB1
use BlogDB1
CREATE TABLE Catagories(
ID INT primary key Identity,
Name nvarchar(50) Not Null Unique
)

CREATE TABLE Tags(
ID int primary key Identity,
Name nvarchar(50) Not Null Unique
)

CREATE TABLE Users(
ID int primary key Identity,
UserName nvarchar(50) Not Null Unique,
FullName nvarchar(50) Not Null,
Age int Check ( Age Between 0 and 150 )
)

CREATE TABLE Blogs(
ID int primary key Identity,
Title nvarchar(50) not null,
Description nvarchar(250) not null,
UsersId int foreign key references Users(ID),
CatagoriesId int foreign key references Catagories(ID)
)

CREATE TABLE Comments(
ID int primary key Identity,
Content nvarchar(250) not null,
UsersId int foreign key references Users(ID),
BlogsId int foreign key references Blogs(ID)
)

CREATE TABLE Blogs_Tags(
ID int primary key Identity,
BlogsId int foreign key references Blogs(ID),
TagsId int foreign key references Tags(ID)
)

CREATE VIEW BlogUserDetails As
Select Blogs.Title, Users.UserName ,Users.FullName
from Blogs 
Join Users ON Blogs.UsersId = Users.ID

Select * from BlogUserDetails


CREATE VIEW BlogCatagoriesDetails As
Select Blogs.Title ,Catagories.Name
from Blogs
join Catagories on Blogs.CatagoriesId=Catagories.ID

Select * from BlogCatagoriesDetails


CREATE PROCEDURE usp_Get_Comment @userId int
as
Begin

Select Comments.ID,Comments.Content,Comments.BlogsId,Blogs.Title
from Comments
join Blogs on Comments.BlogsId = Blogs.ID
where 

End
