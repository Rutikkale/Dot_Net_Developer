create database Employee ;
use Employee;

create table Employee (Emp_id int not null,
                       Dept_id int not null,
					   Emp_Name varchar(50),
					   Emp_Gender varchar(50),
					   Salary int,
					   Dept_name varchar(50),
					   Dept_head varchar(50),
					   Dept_location varchar(50),
					  -- primary key(Emp_id,Dept_id)
					  );

select*from Employee;

insert into Employee values(1,1,'Rutik','Male',450000,'IT','Rutik','Hyderabad');
insert into Employee values(2,1,'Pritik','Male',50000,'HR','Rutik','Yavatmal');
insert into Employee values(3,1,'Ashish','Male',25000,'CIVIL','Rutik','Nagpur');
insert into Employee values(4,2,'Vivek','Male',45000,'Account','Rutik','Hyderabad');
insert into Employee values(5,1,'Sanandan','Male',25500,'Admision','Rutik','Pune');
insert into Employee values(6,2,'Rithesh','Male',30000,'Placement','Rutik','Mumbai');

drop table Employee;
truncate table Employee;

alter table Employee add Primary key(Emp_id,Dept_id);
