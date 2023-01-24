create database logindetails
use logindetails
create table logindetails
(
FirstName varchar(50),
SecondName varchar(20),
Email varchar(100)check(Email like '%@gmail.com')primary key,
password char(6)
)
select * from logindetails

insert into logindetails values()
delete from logindetails

select * from logindetails where Email='sha@gmail.com' and password='rgrb'
update logindetails set password='rgb' where Email='a@gmail.com'

create table imagedetails
(
Email varchar(100)check(Email like '%@gmail.com'),
img varchar(200),
imgpass varchar(10),
foreign key (Email)references logindetails (Email)
)
select * from imagedetails 
delete from logindetails

create table aa
(
id int,
img varchar(100)
) 
select * from aa

select img from aa where id='1'
drop table aa

delete from aa

