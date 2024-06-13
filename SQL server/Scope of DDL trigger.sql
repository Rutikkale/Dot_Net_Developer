use Trigger_DB

create trigger tr_create
on database
for create_table
as
begin
print'You are just created a table';
end

create table student(id int)

create trigger tr_ServerScopedTrigger
on all server
for create_table
as
begin
print'You are just created a table';
end

drop trigger tr_ServerScopedTrigger on all server


use  Practice;

create table student(id int)
create table student1(id int)

drop table student;
select*from student;

alter trigger tr_ServerScopedTrigger
on all server
with encryption
for create_table
as
begin
rollback
print'You are just created a table';
end

drop trigger tr_ServerScopedTrigger on all server

disable trigger tr_ServerScopedTrigger on all server;
enable trigger tr_ServerScopedTrigger on all server;

---------------------
create trigger tr_ServerScopedTriggerView
on all Server
for create_view
as
begin
rollback
print 'You are not allowed to created a views';
end

drop trigger tr_ServerScopedTriggerView on all server

use  Practice;
create table myStudent(id int, name varchar(40), age int);


create view vw_stu
as
select id , name from myStudent;

drop view vw_stu;

