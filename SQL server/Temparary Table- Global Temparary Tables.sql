create database channel_db;
use channel_db;

create table ##EmpData(Name varchar(50),
                      Gender varchar(50));

select*from ##EmpData;
drop table ##EmpData;

insert into ##EmpData values('Rutik','Male');
insert into ##EmpData values('Riya','Female');
insert into ##EmpData values('lakhan','Male');
