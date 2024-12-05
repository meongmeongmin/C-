create database naverDB;
go
use naverDB
go
create table userTable (id char(4), userName char(15), email char(15), birthYear int);
go
insert into userTable values('john', 'John Bann', 'john@naver.com' , 1990);
insert into userTable values('kim', 'Kim Chi', 'kim@daum.net', 1992);
insert into userTable values('lee', 'Lee Pal', 'lee@paran.com', 1988);
insert into userTable values('park' , 'Park Su' , 'park@gmail.com' , 1980);
go
select * from userTable;
go
select * from userTable order by birthYear;
go