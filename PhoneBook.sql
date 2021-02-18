create database PhoneBook
go
use PhoneBook
go
create table Users
(UserID uniqueidentifier primary key,
UserName nvarchar(30) unique,
Password nvarchar(30) not null
)
insert into Users(UserID,UserName,Password) Values(NEWID(),'Demo','Demo')

create table Directory
(ID uniqueidentifier primary key,
Name nvarchar(30) not null,
Surname nvarchar(30)not null,
PhoneNumberI nvarchar(12),
PhoneNumberII nvarchar(12),
PhoneNumberIII nvarchar(12),
Email nvarchar(50),
WebAdress nvarchar(30),
Address nvarchar(100),
Description nvarchar(200)
)

create proc spNewDirectorySave
(@ID uniqueidentifier,
@Name nvarchar(30),
@Surname nvarchar(30),
@PhoneNumberI nvarchar(12),
@PhoneNumberII nvarchar(12),
@PhoneNumberIII nvarchar(12),
@Email nvarchar(50),
@WebAddress nvarchar(30),
@Address nvarchar(100),
@Description nvarchar(200)
)
as
begin
insert into Directory(ID,Name,Surname,PhoneNumberI,PhoneNumberII,PhoneNumberIII,Email,WebAdress,Address,Description) Values
(@ID,@Name,@Surname,@PhoneNumberI,@PhoneNumberII,@PhoneNumberIII,@Email,@WebAddress,@Address,@Description)
end
 
 create proc spUpdateDirectorySave
(@ID uniqueidentifier,
@Name nvarchar(30),
@Surname nvarchar(30),
@PhoneNumberI nvarchar(12),
@PhoneNumberII nvarchar(12),
@PhoneNumberIII nvarchar(12),
@Email nvarchar(50),
@WebAddress nvarchar(30),
@Address nvarchar(100),
@Description nvarchar(200)
)
as
begin
Update Directory
set
Name=@Name,
Surname=@Surname,
PhoneNumberI= @PhoneNumberI,
PhoneNumberII=@PhoneNumberII,
PhoneNumberIII=@PhoneNumberIII,
Email = @Email,
WebAdress=@WebAddress,
Address=@Address,
Description=@Description
where 
ID=@ID
end

create proc spDeleteDirectory
(@ID uniqueidentifier,
@Name nvarchar(30),
@Surname nvarchar(30),
@PhoneNumberI nvarchar(12),
@PhoneNumberII nvarchar(12),
@PhoneNumberIII nvarchar(12),
@Email nvarchar(50),
@WebAddress nvarchar(30),
@Address nvarchar(100),
@Description nvarchar(200)
)
as
begin
delete Directory where ID=@ID
end

create proc spDirectoryList
as
begin
select * from Directory
end

create proc spDirectoryID
(@ID uniqueidentifier
)
as
begin
select * from Directory where ID= @ID
end