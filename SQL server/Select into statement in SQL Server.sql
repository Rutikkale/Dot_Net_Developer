USE Batch_01_2024
select*from MyEmployees;

select*from MyDepartment;

select * into Employee_Backup from MyEmployees;
select*from Employee_Backup;
drop table Employee_Backup;

select Emp_id,Emp_Name into Employee_Backup from MyEmployees;
select*from Employee_Backup;
drop table Employee_Backup;

select*into Employee_Backup from MyEmployees where City in ('Pune');
select*from Employee_Backup;
drop table Employee_Backup;

select*into Employee_Backup from
MyEmployees as A
inner join MyDepartment as B
on B.Id=A.Dept_id;

select*from Employee_Backup;
drop table Employee_Backup;

select A.* ,B.Dept_Name Employee_Backup from
MyEmployees as A
inner join MyDepartment as B
on B.Id=A.Dept_id;

select*from Employee_Backup;
drop table Employee_Backup;

select*into Employee_Backup  from Employee_Details  Where 1 <> 1;
select*from Employee_Backup;
drop table Employee_Backup;

select*into Batch_05_2024.dbo.Employee_Backup2
from MyEmployees;