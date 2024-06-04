USE Batch_01_2024

create table tbl_Student(id int primary key identity,
                         Name varchar(100),
						 Gender varchar(10),
						 Age int,
						 Standard int,
						 Teacher_id int);

Select*from tbl_Student;	
truncate table tbl_Student;

insert into tbl_Student values ('Rutik','Male',23,12,100);
insert into tbl_Student values ('Nikhil','Male',24,11,110);
insert into tbl_Student values ('Sakshi','Female',21,12,100);
insert into tbl_Student values ('Pooja','Female',25,13,105);
insert into tbl_Student values ('Arpit','Male',19,12,115);
insert into tbl_Student values ('Aniket','Male',26,11,105);

------------Inline table valued Funtion-------------------
--Without parameters--
create function fn_GetStudent()
returns table
as
return (select*from tbl_Student);

select*from fn_GetStudent();
select*from dbo.fn_GetStudent();

------------Inline table valued Funtion-------------------
--With parameters--

create function fn_GetStudentAge(@Age int)
returns table
as
return (select*from tbl_Student where Age>=@Age);

select*from dbo.fn_GetStudentAge(21);
select*from dbo.fn_GetStudentAge(24);
Select*from tbl_Student;	

-------------------------------------------------------

select*from Teacher_tbl;
Select*from tbl_Student;	

select*from dbo.fn_GetStudentAge(24) as A
inner join
Teacher_tbl as B
on A.Teacher_id=B.T_id;





