USE Batch_01_2024

Select*from tbl_Student;	

------------Multi-statement table valued functions--------------------
create function fn_GetStudentByGender(@Gender varchar(10))
returns @MyTable table (std_id int,std_Name varchar(50),std_Gender varchar(10))
as
begin 
insert into @MyTable
select id,Name,Gender from tbl_Student where Gender=@Gender
return 
end

select*from [dbo].[fn_GetStudentByGender]('Male');

------------Inline table valued functions--------------------
create function fn_GetStdGender(@Gender varchar(10))
returns table
as 
return (select id,Name,Gender from tbl_Student where Gender=@Gender)

select*from [dbo].[fn_GetStdGender]('Male')
drop function [dbo].[fn_GetStdGender]
