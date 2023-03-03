use master 
go
drop database esoft
go
create database esoft
go
use esoft
go

create table Клиенты(
    _id  int identity(1,1) primary key,
    Фамилия varchar(60) not null,
    Имя varchar(60) not null,
    Отчество varchar(60) not null,
    Номер_телефона varchar(60),
    Электронная_Почта varchar(60),
)
GO

create table Риэлторы(
    _id  int identity(1,1) primary key,
    Фамилия varchar(60) not null,
    Имя varchar(60) not null,
    Отчество varchar(60) not null,
    Доля_комиссии int
)
GO

