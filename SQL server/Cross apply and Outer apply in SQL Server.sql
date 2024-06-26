Use [Practice ];

Create table Teacher_tbl
(teacher_id int,
teacher_name varchar(40),
teacher_gender varchar(40),
teacher_qual varchar(10),
teacher_sal int
);

create table Student_tbl
(
std_id int,
std_name varchar(50),
std_gender varchar(10),
std_age int,
std_class int,
t_id int
);

select*from Teacher_tbl;
select*from Student_tbl;

insert into Teacher_tbl values(1,'Asad','Male','BSIT',28000);
insert into Teacher_tbl values(2,'Khalid','Male','MBA',29000);
insert into Teacher_tbl values(3,'Amjad','Male','MPHIL',30000);
insert into Teacher_tbl values(4,'Adeel','Male','BSIT',27000);
insert into Teacher_tbl values(5,'Sahar','Female','BSC',25000);
insert into Teacher_tbl values(6,'Farukh','Male','BBA',26000);

insert into Student_tbl values(1,'Anas','Male',22,12,2);
insert into Student_tbl values(2,'Anum','Female',21,11,3);
insert into Student_tbl values(3,'Zain','Male',23,12,1);
insert into Student_tbl values(4,'Furqan','Male',21,10,2);
insert into Student_tbl values(5,'Saba','Female',21,11,4);
insert into Student_tbl values(6,'Amna','Female',23,12,3);

Select*from teacher_tbl
inner join student_tbl
on teacher_tbl.teacher_id = Student_tbl.t_id;

select T.teacher_name, T.teacher_qual, S.std_name , S.std_Age from Teacher_tbl as T
left join
Student_tbl as S
on T.teacher_id=S.t_id;

create function fn_GetStudentbyTeacherID(@Teacher_id int)
returns table
as
return
(
select*from Student_tbl 
where t_id=@Teacher_id
);

select*from fn_GetStudentbyTeacherID(2);

select T.teacher_name, T.teacher_qual, S.std_name , S.std_Age from Teacher_tbl as T
cross apply
fn_GetStudentbyTeacherID(T.teacher_id) as S;


select T.teacher_name, T.teacher_qual, S.std_name , S.std_Age from Teacher_tbl as T
outer apply
fn_GetStudentbyTeacherID(T.teacher_id) as S;