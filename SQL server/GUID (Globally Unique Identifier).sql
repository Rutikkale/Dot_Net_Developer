create database mydb;
use mydb;

------------GUID (Globally Unique Identifier)--------------------------
create table Customer_Hyderabad (id uniqueidentifier primary key default newid(),Name Varchar(50));

drop table Customer_Hyderabad;
select NewId();

insert into Customer_Hyderabad values (Default,'Rutik');
insert into Customer_Hyderabad values (Default,'Sakshi');
insert into Customer_Hyderabad values (Default,'Pritam');

select*from Customer_Hyderabad;

create table Customer_Mumbai (id uniqueidentifier primary key default newid(),Name Varchar(50));

insert into Customer_Mumbai values(Default,'Yash Mirashe');
insert into Customer_Mumbai values(Default,'Shivani Mahale');
insert into Customer_Mumbai values(Default,'Shardha Gadrkar');

select*from Customer_Mumbai;
select*from Customer_Hyderabad;

create table Customers (id Uniqueidentifier Primary Key default newid(), Name Varchar(50));

insert into Customers
select*from Customer_Mumbai
union all
select*from Customer_Hyderabad;

select*from Customers;