use Ado_db

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