use master
go

if (exists(select * from sys.databases where name = 'ExemploSenai'))
	drop database ExemploSenai
	go

create database ExemploSenai

go

use ExemploSenai

create table Usuario(
ID int identity primary key,
Nome varchar(200) not null,
Senha varchar(1000) not null
);
go

create table Post(
	ID int identity primary key,
	Publicante int references Usuario(ID),
	Conteudo varchar(MAX) not null,
	Momento datetime not null

);
go

create table Follow(
	ID int primary key identity,
	seguido int references Usuario(ID),
	seguindo int references Usuario(ID),
);
go


select * from Follow
select * from Usuario
select * from Post