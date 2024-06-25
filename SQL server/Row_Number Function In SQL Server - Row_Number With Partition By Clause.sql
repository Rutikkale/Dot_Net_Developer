use [Practice ];

create table Emp_tbl
(
Name varchar(50),
City varchar(10),
Age int,
Gender varchar(10),
Salary int
);



insert into Emp_tbl values ('Rutik','Yavatmal',23,'Male',250000);
insert into Emp_tbl values ('Arpit','Yavatmal',22,'Male',250000);
insert into Emp_tbl values ('Priyanka','Yavatmal',23,'Female',250000);
insert into Emp_tbl values ('Vaishanvi','Yavatmal',23,'Female',250000);
insert into Emp_tbl values ('Supariya','Yavatmal',23,'Female',250000);
insert into Emp_tbl values ('Komal','Yavatmal',23,'Female',250000);
insert into Emp_tbl values ('Ashvin','Mumbai',20,'Male',25000);
insert into Emp_tbl values ('Darshan','Mumbai',23,'Male',25000);
insert into Emp_tbl values ('Omkar','Mumbai',24,'Male',50000);

select*, ROW_NUMBER() over(order by Name asc) as Numbering from Emp_tbl;

select*, ROW_NUMBER() over(Partition by Gender order by Name asc) as Numbering
from Emp_tbl;

select*, ROW_NUMBER() over(Partition by City order by Name asc) as Numbering
from Emp_tbl;
