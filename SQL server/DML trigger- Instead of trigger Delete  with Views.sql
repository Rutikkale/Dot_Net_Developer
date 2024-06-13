USE Batch_01_2024

create table Employee_Personal_Details(Emp_Id int primary key Identity,
                              FirstName varchar(50),
                              LastName varchar(50),
                              Address varchar(50));
select*from Employee_Personal_Details;

insert into Employee_Personal_Details values('Rutik','Kale','Yavatmal');
insert into Employee_Personal_Details values('Pranav','Chavdhari','Yavatmal');
insert into Employee_Personal_Details values('Vedant','Kove','Katol');
insert into Employee_Personal_Details values('Rohan','Garud','Nagpur');
insert into Employee_Personal_Details values('Prasad','Virutkar','Pune');




create table Employee_Salary_Details(Emp_Id int primary key,
                                     Designation varchar(50),
									 Salary int);
select*from Employee_Salary_Details;
									 	
insert into  Employee_Salary_Details values(1,'Manager',45000);	
insert into  Employee_Salary_Details values(2,'Account',25000);									 
insert into  Employee_Salary_Details values(3,'HR',41000);									 
insert into  Employee_Salary_Details values(4,'CEO',42000);									 

select*from Employee_Salary_Details;
select*from Employee_Personal_Details;

create view VW_EmployeeDetails
as
select A.Emp_Id, A. FirstName, A.LastName, B.Designation, B.Salary from Employee_Personal_Details as A
inner join 
Employee_Salary_Details as B
on A.Emp_Id = B.Emp_Id;

drop view VW_EmployeeDetails; 

select*from VW_EmployeeDetails;


delete from VW_EmployeeDetails where Emp_Id = 4;

create trigger tr_DeleteView
on VW_EmployeeDetails
instead of delete
as
begin
delete from Employee_Personal_Details where Emp_Id in (select Emp_Id from deleted)
delete from Employee_Salary_Details where Emp_Id in (select Emp_Id from deleted)
end

delete from VW_EmployeeDetails where Emp_Id = 1;
delete from VW_EmployeeDetails where Emp_Id = 4;

select*from VW_EmployeeDetails;
