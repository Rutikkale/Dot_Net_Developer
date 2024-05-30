use Batch_01_2024;

select*from MyEmployees;

create table MyDepartment (Id int Primary key,
                           Dept_Name varchar(50));

select*from MyDepartment;

insert into MyDepartment values (1,'Accounts');
insert into MyDepartment values (2,'HR');
insert into MyDepartment values (3,'Administration');
insert into MyDepartment values (4,'Counselling');

select*from MyDepartment;
select*from MyEmployees;

create view VW_ForEmployees
as
select*from MyEmployees as A
inner join MyDepartment as B
on A.Dept_id = B.Id;

select*from VW_ForEmployees;

create view VW_ForEmployees1
as
select A.* , B.Dept_Name  from MyEmployees as A
inner join MyDepartment as B
on B.id = A.Dept_id;

select*from VW_ForEmployees1;

------Column Security-----------
create view VW_ForEmployees2
as
select A.Emp_id,A.Emp_Name,A.Gender,A.City,A.Dept_id , B.Dept_Name  from MyEmployees as A
inner join MyDepartment as B
on B.id = A.Dept_id;

select*from VW_ForEmployees2;

------Row Security-----------
create view VW_ForEmployees3
as
select A.* , B.Dept_Name  from MyEmployees as A
inner join MyDepartment as B
on B.id = A.Dept_id
where Dept_Name = 'HR';

select*from VW_ForEmployees3;

--------SP_HelpText--------------------
SP_HelpText VW_ForEmployees3;

--------------Alter Views-------------
Alter view VW_ForEmployees3
as
select A.* , B.Dept_Name  from MyEmployees as A
inner join MyDepartment as B
on B.id = A.Dept_id
where Dept_Name = 'HR' or Dept_Name='Accounts';

select*from VW_ForEmployees3;

---------------Drop View ------------

drop  view VW_ForEmployees;

select*from VW_ForEmployees;

----------------------Insert, Update, Delete-------------------------------------

create view VW_ForEmployees
as
select*from MyEmployees;

drop  view VW_ForEmployees;

select*from VW_ForEmployees;

insert into VW_ForEmployees Values ('Anchal','Male','140000','Indore',17);

update VW_ForEmployees set Emp_Name ='Prashad' where Dept_id = 17;

delete from VW_ForEmployees Where Emp_id =116;

delete from VW_ForEmployees Where Dept_id =16;

---------------------------

create view VW_Employees
as
select Emp_id ,Emp_Name, Gender from MyEmployees;

select*from VW_Employees;

create view VW_Employee1
as
select*from MyEmployees where Emp_id = 114;

drop view VW_Employee1;

select*from VW_Employee1;
