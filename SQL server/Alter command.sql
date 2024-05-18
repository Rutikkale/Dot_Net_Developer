create database Batch_05_2024
use Batch_05_2024

----Change Database name-------
alter database Batch_05_2024 modify name = New_Batch_05_2024;

----Change set Database name with build in store procedure-------
execute sp_renamedb 'New_Batch_05_2024','Batch_05_2024';

--The database could not be exclusively locked to perform the operation.error msg--
ALTER DATABASE New_Batch_05_2024
SET SINGLE_USER WITH ROLLBACK IMMEDIATE

alter database New_Batch_05_2024 modify name =Batch_05_2024;

ALTER DATABASE Batch_05_2024
SET MULTI_USER WITH ROLLBACK IMMEDIATE


----Change table name-------
create table Voter_list(Voter_id int primary key,
                        Voter_Name varchar(50) not null,
						Voter_Age int not null);

Select*from Voter_list

insert into New_Voter_list values(1,'Rutik',23);
insert into New_Voter_list values(2,'Arpit',21);

execute sp_rename 'Voter_list','New_Voter_list'
Select*from New_Voter_list

--Add Coloums in table with the help of Alter Command--

alter table New_Voter_list add Voter_city varchar(50);

update New_Voter_list set Voter_city='Nagpur' where Voter_id=2;

--Delete coloums from table using Alter Command--
alter table New_Voter_list drop column Voter_city;

--Change Datatype of Column--
alter table New_Voter_list alter Column Voter_Name nvarchar(50);

---Alter command with SQL Constraints----
create table Voter_list (Voter_id int not null,
                         Voter_name varchar(50) not null ,
						 Voter_Age int not null);

Select*from Voter_list

----change null to not null---------
alter table Voter_list alter column Voter_name Varchar(50) not null;
alter table Voter_list alter column Voter_name Varchar(50) null;

insert into Voter_list(Voter_id,Voter_Name,Voter_Age) values (1,'Ram',23);
insert into Voter_list(Voter_id,Voter_Age) values (2,23);

delete from Voter_list where Voter_id =1;
delete from Voter_list where Voter_id= 2;

alter table Voter_list drop column Voter_id;
alter table Voter_list add Voter_id int ;

drop table Voter_list

------Add Unique Constraint----------
alter table Voter_list add Unique (Voter_id);

insert into Voter_list Values (3,'Rutik',23)
insert into Voter_list Values (3,'Arpit',21)

---delete Unique Constraints----
alter table Voter_list drop [UQ__Voter_li__E289234CD268ECA0]

------Add Primary key----------
alter table Voter_list add Primary key (Voter_id)

alter table Voter_list alter column Voter_id int not null;
delete from Voter_list where Voter_id=3;

--------delete Primary key-----------
alter table Voter_list drop  [PK__Voter_li__E289234D6E93D20D];

---------Add Foreign key-------
create table Voter_list (Voter_id int primary key,
                         Voter_name varchar(50) not null ,
						 Voter_Age int not null);

create table Voter_city(C_id int,
                        C_Name Varchar(50),
						Voter_id int);
drop table Voter_list;

select*From Voter_list;
select*From Voter_city;

--add Foreign key
alter table Voter_city add Foreign key (Voter_id) references Voter_list(Voter_id);
--add Not null to the voter_id column
alter table Voter_list alter column Voter_id int not null;
--Delete Foreign key
alter table Voter_city drop constraint [FK__Voter_cit__Voter__5165187F]
alter table Voter_city drop constraint [FK__Voter_cit__Voter__52593CB8]

----Alter command For Check Constraint----
--Add check constraint--
alter table Voter_list add check(Voter_Age >=18);

insert into Voter_list values(1,'Sarthak',18);
insert into Voter_list values(2,'Sarthak',15);

--delete check constraint--
alter table Voter_list drop [CK__Voter_lis__Voter__534D60F1]

--Alter command with Default Constraints--
alter table Voter_list add default 18 for Voter_Age;

insert into Voter_list (Voter_id,Voter_name) Values (2,'Rutik');

select*From Voter_list;
select*From Voter_city;

------------ALIAS IN SQL Server-----------
create table Voter_list (Voter_id int primary key,
                         Voter_name varchar(50) not null ,
						 Voter_Age int not null);

select Voter_id as Voter_ID, Voter_Name as Voter_Full_Name from Voter_list;

select*From Voter_list;