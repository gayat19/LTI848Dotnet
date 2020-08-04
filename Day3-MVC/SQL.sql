create database dbMovieShop

use dbMovieShop

create table tblMovie
(id int identity(1,1) primary key,
name varchar(20),
duration float)

insert into tblMovie(name,duration) values('A-Team',123.2)
insert into tblMovie(name,duration) values('XYZ',113.8)
insert into tblMovie(name,duration) values('Expendables',102.5)
insert into tblMovie(name,duration) values('MI',100.3)

select * from tblMovie

create table tblDisc
(id int identity(101,1) primary key,
movie_id int constraint fk_mid foreign key references tblMovie(id),
rent_cost float,
is_Available bit default 1)

insert into tblDisc(movie_id,rent_cost,is_Available) 
values(1,50,default)
insert into tblDisc(movie_id,rent_cost,is_Available) 
values(2,40,default)
insert into tblDisc(movie_id,rent_cost,is_Available) 
values(1,30,default)

select * from tblDisc

Create  table UserData
(username varchar(20) primary key,
password varchar(20) not null)

insert into UserData values('Ramu',1234)
insert into UserData values('Somu',1234)
insert into UserData values('Bimu',1234)
insert into UserData values('Pomu',1111)

select * from userData