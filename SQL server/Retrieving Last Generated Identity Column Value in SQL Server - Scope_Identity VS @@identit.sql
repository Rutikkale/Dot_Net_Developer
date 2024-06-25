use [Practice ];

create table Employee_tbl
(
id int identity,
Name varchar(50)
);

select*from Employee_tbl;

insert into Employee_tbl values ('Rutik');
insert into Employee_tbl values ('Arpit');
insert into Employee_tbl values ('Nikhil');
insert into Employee_tbl values ('Rushikesh');

select SCOPE_IDENTITY();
select @@Identity;
select IDENT_CURRENT('Employee_tbl');
select IDENT_CURRENT('Emp_Details');

create table Emp_Details
(
id int identity,
date_time datetime
);

insert into Emp_Details values(GETDATE());

create trigger tr_Emp_GetDate
on Emp_Details
after insert
as
begin
insert into Emp_Details values(GETDATE());
end

