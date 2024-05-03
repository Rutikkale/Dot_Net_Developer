use Ado_db

------------------------------ employee_tbl -----------------------------------
create table employee_tbl(id int primary key,
                          name varchar(50),
						  gender varchar(10),
						  age int,
						  salary int,
						  city varchar(50));
drop table employee_tbl

select*from employee_tbl

insert into employee_tbl values(1,'Rutik Kale','Male',23,25000,'Nagpur')
insert into employee_tbl values(2,'Arpit Kale','Male',23,25000,'Nagpur')
insert into employee_tbl values(3,'Harshal Shinde','Male',21,35000,'Mumbai')
insert into employee_tbl values(4,'Ram Raut','Male',28,25000,'Yavatmal')
insert into employee_tbl values(5,'Vikas Bankar','Male',35,45000,'Yavatmal')
insert into employee_tbl values(6,'Sakshi Swarkar','Female',22,25000,'Nagpur')


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