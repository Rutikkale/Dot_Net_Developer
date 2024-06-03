USE Batch_01_2024

select*from Employee_Details;

create procedure spGetEmployeesOutParameter
@Gender varchar(10),
@EmployeeCount int output
as
begin 
select @EmployeeCount = count(id) from Employee_Details
end

Declare @TotalEmployee int
execute spGetEmployeesOutParameter 'Male', @TotalEmployee output
select @TotalEmployee



Declare @TotalEmployee int
execute spGetEmployeesOutParameter 'Female', @TotalEmployee output
select @TotalEmployee as [Total Employee]