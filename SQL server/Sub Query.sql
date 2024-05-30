USE Batch_01_2024

create table Employee_Details( Id int primary key identity,
                               Name varchar(50),
							   Gender varchar(50),
							   Salary int ,
							   City varchar(50));

insert into Employee_Details values ('Rutik','Male',60000,'Nagpur');
insert into Employee_Details values ('Rupesh','Male',65000,'Pune');
insert into Employee_Details values ('Sachin','Male',80000,'Nagpur');
insert into Employee_Details values ('Pratik','Male',60000,'Nagpur');
insert into Employee_Details values ('Krish','Male',550000,'Pune');
insert into Employee_Details values ('Priyanka','Male',65000,'Indore');
insert into Employee_Details values ('Prachi','Male',68000,'Nashik');
insert into Employee_Details values ('Janhavi','Female',20000,'Aamaravati');
insert into Employee_Details values ('Hement','Male',65000,'Pune');
insert into Employee_Details values ('Prasad Kale','Male',70000,'Nagpur');

create table MyDepartment (Id int Primary key,
                           Dept_Name varchar(50));

select*from MyDepartment;

select*from Employee_Details;

select*from Employee_Details
where Id in 
(select Id from Employee_Details where Salary>=10000);

select*from Employee_Details
where Id in
(select Id from Employee_Details where City in ('Nagpur'));

select Name,Gender,City from Employee_Details
where id in
(select id from Employee_Details where city in('Pune') );

select Name,Gender,City from Employee_Details
where id in
(select id from Employee_Details where Gender='Male' );

select Name,Gender,City from Employee_Details
where id in
(select id from Employee_Details where Gender='Female' );

Update Employee_Details set Salary=Salary+2000
where id in 
(Select id From Employee_Details where City in ('Pune'));

select*from Employee_Details;

delete from Employee_Details 
where id in
(select id from Employee_Details where City in('Aamaravati'));

select*from Employee_Details
where id in
(select id from MyDepartment where Dept_Name ='Accounts');

select*from Employee_Details
where Id in 
(select Id from Employee_Details where Salary>=10000)
order by City;