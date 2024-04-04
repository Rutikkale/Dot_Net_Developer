use Batch_01_2024;

-- Primary Key and Foreign Key relationship in SQL 

create table customer_tbl(c_id int primary key,
                          c_Name varchar(50),
						  c_Address Varchar (max),
						  city varchar(50));

select*from customer_tbl;                 

insert into customer_tbl values (1,'Rutik','Sai Nagar','Puna')
insert into customer_tbl values (2,'Arpit','Gurukrupa Layout','Nagpur')
insert into customer_tbl values (3,'Harshal','Sneha Nagar','Nagpur')
insert into customer_tbl values (4,'Abhijeet','Jijau Nagar','Puna')
insert into customer_tbl values (5,'Shau','Renuka Nagar','Puna')


create table [order](ord_id int primary key,
                     Item Varchar(50),
					 Quantity int,
					 Price_of_1 int,
					 c_id int foreign key references customer_tbl(c_id));

select*from [order]

insert into [order] values (111,'Hard-Disk',2,2000,5);
insert into [order] values (222,'PenDrive',1,500,1);
insert into [order] values (333,'Keyboard',3,300,4);
insert into [order] values (444,'Moniter',2,5400,5);
insert into [order] values (555,'Phone',1,5000,2);
insert into [order] values (666,'Mouse',2,200,3);
insert into [order] values (777,'Laptop',1,60000,1);
insert into [order] values (888,'charger',1,500,5);

insert into [order] values (999,'charger',1,500,7);
delete from [order] where ord_id =999;

select*from customer_tbl;
select*from [order]

--Delete foreign-key---
alter table [order] Drop constraint [FK__order__c_id__04E4BC85]

--Alter add foreign key ---
alter table [order] add foreign key (c_id) references customer_tbl(c_id);

--Cascading Referential Integrity Constraints In SQL Server -1) No Action
Delete from customer_tbl where c_id = 2;
Update Customer_tbl set c_id = 7 where c_id = 2;

--Cascading Referential Integrity Constraints In SQL Server -2) Cascade
drop table [Order];
drop table customer_tbl;

create table customer_tbl(c_id int primary key,
                          c_Name varchar(50),
						  c_Address Varchar (max),
						  city varchar(50));

insert into customer_tbl values (1,'Rutik','Sai Nagar','Puna')
insert into customer_tbl values (2,'Arpit','Gurukrupa Layout','Nagpur')
insert into customer_tbl values (3,'Harshal','Sneha Nagar','Nagpur')
insert into customer_tbl values (4,'Abhijeet','Jijau Nagar','Puna')
insert into customer_tbl values (5,'Shau','Renuka Nagar','Puna')


create table [order](ord_id int primary key,
                     Item Varchar(50),
					 Quantity int,
					 Price_of_1 int,
					 c_id int foreign key references customer_tbl(c_id)
					 on delete Cascade
					 on Update Cascade);

select*from [order]

insert into [order] values (111,'Hard-Disk',2,2000,5);
insert into [order] values (222,'PenDrive',1,500,1);
insert into [order] values (333,'Keyboard',3,300,4);
insert into [order] values (444,'Moniter',2,5400,5);
insert into [order] values (555,'Phone',1,5000,2);
insert into [order] values (666,'Mouse',2,200,3);
insert into [order] values (777,'Laptop',1,60000,1);
insert into [order] values (888,'charger',1,500,5);

select*from customer_tbl;
select*from [order]

delete from customer_tbl where c_id = 5 ;
update customer_tbl set c_id = 7 where c_id = 4;






