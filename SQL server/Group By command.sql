USE Batch_01_2024

create table MyEmployees(Emp_id int primary key identity(100,1),
                         Emp_Name varchar(50),
						 Gender varchar(10),
						 Salary int,
						 City varchar(50),
						 Dept_id int);

select*from MyEmployees;

drop table MyEmployees;

truncate table MyEmployees;

insert into MyEmployees values ('Sarthak','Male',25000,'yavatmal',5);
insert into MyEmployees values ('Rakesh','Male',28000,'Nagpur',4);
insert into MyEmployees values ('Sanchita','Female',35000,'Wardha',2);
insert into MyEmployees values ('Banti','Male',45000,'Pune',1);
insert into MyEmployees values ('Sanndan','Male',55000,'Delhi',3);
insert into MyEmployees values ('Abhishekh','Male',22000,'Hydrabad',6);
insert into MyEmployees values ('Prashad','Male',29000,'Banglore',8);
insert into MyEmployees values ('Roshan','Male',26500,'Pune',7);
insert into MyEmployees values ('Shreya','Female',15000,'yavatmal',9);
insert into MyEmployees values ('Rakha','Female',18000,'Nagpur',10);
insert into MyEmployees values ('Sanchita','Female',5000,'Wardha',12);
insert into MyEmployees values ('Banti','Female',45000,'Pune',11);
insert into MyEmployees values ('Nandini','Female',55000,'Delhi',13);
insert into MyEmployees values ('Abiti','Female',21000,'Hydrabad',15);
insert into MyEmployees values ('Priya','Female',29000,'Banglore',14);
insert into MyEmployees values ('Roshani','Female',26500,'Pune',16);

select City ,sum(Salary) as [Total Salary ] from MyEmployees  group by City ;

select Gender ,City ,sum(Salary) as [Total Salary Accounding to city ] from MyEmployees  group by Gender,City ;


---------------------

create table Student_tbl(Student_id int identity(100,1),
                         Student_Name varchar(50),
						 Father_Name varchar(50),
						 Class int,
						 Fees int )
						 
insert into Student_tbl values ('Darshan','Shamrao',5,3500);
insert into Student_tbl values ('vishal','Pankaj',2,1500);
insert into Student_tbl values ('Sunny','Akshay ',6,4500);
insert into Student_tbl values ('Darvesh','Shamrao',7,5500);
insert into Student_tbl values ('Shreya','Shamrao',2,1500);
insert into Student_tbl values ('Pratik','Shamrao',5,3500);
insert into Student_tbl values ('Akash','Shamrao',5,3500);
insert into Student_tbl values ('Aravind','Shamrao',7,5500);

select*from Student_tbl;

select Class,sum(fees) as [Total Fees according to class] from Student_tbl 
group by Class;