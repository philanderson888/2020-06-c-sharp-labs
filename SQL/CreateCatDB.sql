use master

drop database if exists CatDB
go

create database CatDB
go

use CatDB
go

drop table if exists Cats
drop table if exists Breeds


create table Cats (
	CatId int not null identity primary key,
	CatName nvarchar(50),
	Age int,
	Description nvarchar(50)
)

create table Breeds (
	BreedID int not null identity primary key,
	BreedName nvarchar(50),
)

insert into Cats values ('Ozzie',15,'Mainecoon')
insert into Cats values ('Lucy',3,'Sphinx')
insert into Cats values ('Jasper',1,'Great cat')

insert into Breeds values ('Mainecoon')
insert into Breeds values ('Tabby')
insert into Breeds values ('Sphinx')

select * from Cats
select * from Breeds




