Create database Trigger_DB;
use Trigger_DB

create trigger tr_ddl_table_create
on database
for create_table
as
begin
print'New table Created !!'
end

create trigger tr_ddl_table_alter
on database
for alter_table
as
begin
print'You have just altered a table';
end

alter table test_tbl add name varchar(50);

create trigger tr_ddl_table_drop
on database
for drop_table
as
begin
print 'You have just drop a table ';
end

drop table test_tbl;

-----------------------------------------

create trigger tr_ddl_table
on database
for create_table, Alter_table, Drop_table
as
begin
print 'You Have just create, alter or drop table';
end

create table ddl_tablecheck(id int)
alter table ddl_tablecheck add name varchar(50);
drop table ddl_tablecheck;

select*from ddl_tablecheck;



create trigger tr_ddl_sp_create
on database
for create_Procedure
as
begin
ROLLBACK
print 'You are not allowed to create a stored procedure !!'
end

create procedure sp_MyDDLProcedure
as
begin
print'This is my stored procedure !!';
end

drop procedure sp_MyDDLProcedure;

alter trigger tr_ddl_sp_create
on database
with encryption
for create_Procedure
as
begin
ROLLBACK
print 'You are not allowed to create a stored procedure !!'
end


----------

create trigger tr_ddl_table_create
on database
for create_table
as
begin
rollback
print'New table Created !!'
end

disable trigger tr_ddl_table_create on database;
enable trigger tr_ddl_table_create on database;

create table test_tbl ( id int);
create table test_tbl1 ( id int);

create trigger tr_ddl_rename
on database
for rename
as
begin
print'You have just  renamed a table or table column !!'
end

select*from tbl_test3;

sp_rename 'test_tbl','tbl_test3'

sp_rename 'tbl_test3.id','Student_id'

---------For delete DDL trigger -----------------
drop trigger tr_ddl_rename on database;