create database Hyderabad_DB;
create database Mumbai_DB;
use Hyderabad_DB;
use Mumbai_DB;

create table Customer_Hyderabad(id uniqueidentifier primary key default newid(), Name varchar(50));

insert into Customer_Hyderabad values(default,'Mobhashir khan');
insert into Customer_Hyderabad values(default,'LV Prasad Hospital');

select*from Customer_Hyderabad;

----------------------------------------------------------------------------------------------
use Mumbai_DB;

create table Customer_Mumbai (id uniqueidentifier primary key default newid(), Name varchar(50));

select newid();

insert into Customer_Mumbai values(default,'Golu');
insert into Customer_Mumbai values(default,'Vedant');
insert into Customer_Mumbai values(default,'Jivan');

select*from Customer_Mumbai;



create table Customers(id uniqueidentifier primary key default newid(),Name varchar(50));

drop table Customers;

select*from Customers;

insert into Customers
select*from Hyderabad_DB.dbo.Customer_Hyderabad
union all
select*from Mumbai_DB.dbo.Customer_Mumbai;