use Batch_01_2024;

select 10/2;

select 10/0;

select*from Student_Details

update Student_Details set Age='abc' where Id=1;

begin try
update Student_Details set Age='abc' where Id=1;
end try
begin catch
 print 'you are not insert varchar in Int datatypes'
end catch


begin try
update Student_Details set Age='abc' where Id=1;
end try
begin catch
 select
 ERROR_NUMBER() as [Error Number],
 Error_Severity() as [ Error Sever],
 Error_State() as [Error State],
 Error_procedure () as [Error Procedure],
 Error_Line() as [Error in line Number],
 ERROR_MESSAGE() as [Error Message]
end catch



create procedure sp_Student
as
begin
begin try
update Student_Details set Age='abc' where Id=1;
end try
begin catch
 select
 ERROR_NUMBER() as [Error Number],
 Error_Severity() as [ Error Sever],
 Error_State() as [Error State],
 Error_procedure () as [Error Procedure],
 Error_Line() as [Error in line Number],
 ERROR_MESSAGE() as [Error Message]
end catch
end