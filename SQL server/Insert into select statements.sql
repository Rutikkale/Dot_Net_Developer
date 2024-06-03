USE Batch_01_2024

create table Student_tbl_Pune(s_name varchar(50),S_Last_Name varchar(50),Age int , Class int);
select*from Student_tbl_Pune;
drop table Student_tbl_Pune;

insert into student_tbl_Pune Values('Rutik','Kale',22,10);
insert into Student_tbl_Pune Values('Ram','chavan',24,10);
insert into Student_tbl_Pune Values('Rakhesh','thak',22,10);
insert into Student_tbl_Pune Values('Mayur','Kaware',25,10);
insert into Student_tbl_Pune Values('Darshan','Thakare',22,10);
insert into Student_tbl_Pune Values('Laxmikant','Madhane',12,11);
insert into Student_tbl_Pune Values('Prashad','virutkar',25,12);

create table Student_tbl_Nagpur(Id int identity,s_name varchar(50),S_Last_Name varchar(50),Age int , Class int);
select*from Student_tbl_Nagpur;
drop table Student_tbl_Nagpur;


insert into Student_tbl_Nagpur Values('Ritu','Kotake',22,10);
insert into Student_tbl_Nagpur Values('Sayali','sulbhewar',24,10);
insert into Student_tbl_Nagpur Values('Sayali','Agashe',22,10);

insert into Student_tbl_Nagpur select*from Student_tbl_Pune;
select*from Student_tbl_Nagpur;


insert into Student_tbl_Nagpur(s_name,S_Last_Name) select s_name ,S_Last_Name from Student_tbl_Pune;
select*from Student_tbl_Nagpur;
