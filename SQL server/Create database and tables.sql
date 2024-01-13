--create database
create database Batch_01_2024;
use Batch_01_2024;

--creating student table
create table student(student_Id int,
                     student_Name varchar(50),
					 Father_Name varchar(50),
					 Roll_no int,
					 class varchar(50),
					 mob_no bigint);

drop table student;				 

--showing all records
select*from student

--inserting records
insert into student values(1,'Rutik','Kisanrao Kale',21,'10th',9028600982)
insert into student values(1,'Arpit','Kisanrao Kale',16,'9th',9028600983)
insert into student values(1,'Harshal','Salvatkar',15,'8th',9028600984)
insert into student values(1,'Darshan','Thakare',14,'7th',9028600981)

--inserting records another mathod
insert into student(student_Id,student_Name)values(5,'Rupesh')