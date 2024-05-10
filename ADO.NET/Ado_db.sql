use Ado_db

------------------------------ employee_tbl -----------------------------------
create table employee_tbl(id int primary key identity,
                          name varchar(50),
						  gender varchar(10),
						  age int,
						  salary int,
						  city varchar(50));
drop table employee_tbl

select*from employee_tbl

insert into employee_tbl values('Rutik Kale','Male',23,25000,'Nagpur')
insert into employee_tbl values('Arpit Kale','Male',23,25000,'Nagpur')
insert into employee_tbl values('Harshal Shinde','Male',21,35000,'Mumbai')
insert into employee_tbl values('Ram Raut','Male',28,25000,'Yavatmal')
insert into employee_tbl values('Vikas Bankar','Male',35,45000,'Yavatmal')
insert into employee_tbl values('Sakshi Swarkar','Female',22,25000,'Nagpur')


------------------------------ Student_tbl -----------------------------------
create table student_tbl(std_id int Primary key,
                         std_name varchar(50),
						 std_gender varchar(10),
						 std_age int,
						 std_class int );

 insert into student_tbl values(1,'Anuj chavdhari','Male',18,12);
 insert into student_tbl values(2,'Ram Malhode','Male',21,1);
 insert into student_tbl values(3,'Lopa Chavan','FeMale',13,7);
 insert into student_tbl values(4,'Vaishanvi Jaishwal','FeMale',14,8);
 insert into student_tbl values(5,'Sarthak Helunde','Male',17,11);
 insert into student_tbl values(6,'Abhisheek Giri','Male',16,10);

 select*From student_tbl

------------------------------ Stored Procedure -----------------------------------
 create procedure spGetEmployees
 as
 begin
 select*From employee_tbl
 select*From student_tbl
 end

 execute spGetEmployees;

 ------------ Stored Procedure  for CRUD Operation in Asp.net Mvc Ado.net -----------

 create procedure spGetEmployeesAspNet
 as 
 begin
 select*From employee_tbl
 end
 
 execute spGetEmployeesAspNet

--------------------------Stored Procedure  for CRUD spAddEmployees --------------------------

 create procedure spAddEmployeeAspNet
 (@id int,
 @name varchar(50),
 @gender varchar(50),
 @age int,
 @salary int,
 @city varchar(5)
 )
 as 
 begin
 insert into employee_tbl (id, name, gender, age, salary, city)
 values(@id,@name,@gender,@age,@salary,@city)
 end
 
 execute spAddEmployeeAspNet 8 ,"Sanket", "male", 23, 45000,"Nagpur"

 --------------------------Stored Procedure spUpdateEmployees --------------------------

 create procedure spUpdateEmployeeAspNet
 (@id int,
 @name varchar(50),
 @gender varchar(50),
 @age int,
 @salary int,
 @city varchar(5)
 )
 as 
 begin
 Update employee_tbl set name=@name, gender=@gender,age = @gender, salary=@salary, city=@city
where id=@id
 end

 execute spUpdateEmployeeAspNet 5 ,'Vivek','Male',24,25000,'Yavatmal'

 --------------------------Stored Procedure spDeleteEmployees --------------------------

 create procedure spDeleteEmployeesAspNet
 (@id int)
 as 
 begin
 delete from employee_tbl where id = @id
 end

 execute spDeleteEmployeesAspNet 6

 select*from employee_tbl