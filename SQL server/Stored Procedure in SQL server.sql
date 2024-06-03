USE Batch_01_2024

select*from Employee_Details;

create procedure sp_GetEmployee
as
begin
select*from Employee_Details
end

sp_GetEmployee
Execute sp_GetEmployee
Exec sp_GetEmployee

create procedure sp_GetEmployeeId
@id int
as
begin
select*from Employee_Details where Id=@id
end

Execute sp_GetEmployeeId 3;

create procedure sp_GetEmployeeIdName
@id int,
@name varchar(50)
as
begin
select*from Employee_Details where Id=@id and Name=@name
end

execute sp_GetEmployeeIdName 1, 'Rutik';

alter procedure sp_GetEmployeeIdName
@id int,
@name varchar(50)
as
begin
select Name , Salary from Employee_Details where Id=@id and Name=@name
end

execute sp_GetEmployeeIdName 1, 'Rutik';

sp_help sp_GetEmployeeIdName;
sp_helptext sp_GetEmployeeIdName;

alter procedure sp_GetEmployeeIdName
@id int,
@name varchar(50)
with encryption
as
begin
select Name , Salary from Employee_Details where Id=@id and Name=@name
end

sp_helptext sp_GetEmployeeIdName;

alter procedure sp_GetEmployeeIdName
@id int,
@name varchar(50)
as
begin
select Name , Salary from Employee_Details where Id=@id and Name=@name
end

sp_helptext sp_GetEmployeeIdName;

drop procedure sp_GetEmployeeIdName;


alter procedure sp_GetEmployeeIdName
@id int,
@name varchar(50)
with encryption
as
begin
select *from Employee_Details where Id=@id and Name=@name
end

Execute sp_GetEmployeeIdName 1,'Rutik'
