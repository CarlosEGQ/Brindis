create database Miniproyecto
use Miniproyecto


create table Users(
Id int Identity(1,1 )not null primary key , 
Nickname nvarchar(100) not null,
Password nvarchar(50) not null,
Rol int not null
)

create table Category(
Id int identity (1,1) not null primary key, 
Description nvarchar(100) not null
)

create table Clients(
Id int not null primary key identity(1,1),
Name nvarchar(100) not null,
Address nvarchar(200) not null,
BirthDate Date not null,
RFC nvarchar(20) not null,
CategoryId int not null, 
FOREIGN KEY (CategoryId) REFERENCES Category(Id)
)

insert into Users values('sa','uts',1);
