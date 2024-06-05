USE Batch_01_2024

select*from Teacher_tbl;
select*from tbl_Student;

create table Branch(B_id int primary key,
                    City varchar(40),
					Std_id int);

insert into Branch Values(101,'Napur',100)
insert into Branch Values(102,'Banglore',105)
insert into Branch Values(103,'Pune',110)
insert into Branch Values(104,'Mumbai',115)

select*from Branch;	
select*from Teacher_tbl;
select*from tbl_Student;

select*from tbl_Student as A
inner join Teacher_tbl as B
on A.Teacher_id= B.T_id ;

select*from tbl_Student as A
inner join Teacher_tbl as B
on A.Teacher_id= B.T_id
inner join Branch as C
on B.T_id=C.Std_id;

select A.Name,A.Gender,A.Age,C.City, B.T_Name,B.T_Qualification from tbl_Student as A
inner join Teacher_tbl as B
on A.Teacher_id= B.T_id
inner join Branch as C
on B.T_id=C.Std_id;