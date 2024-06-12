USE Batch_01_2024

create table Tbl_Customer(Id int primary key,
                          Name Varchar(50),
						  Gender Varchar(50),
						  City varchar(50),
						  ContactNo varchar(10));

select*from Tbl_Customer;
drop  table Tbl_customer;

insert into Tbl_Customer values(111,'Danu','Male','Hydrabad','9798949596');
insert into Tbl_Customer values(112,'Sham','Male','Kini','9798949596');
insert into Tbl_Customer values(113,'Devika','Female','Darawa','9798949596');
insert into Tbl_Customer values(114,'Danshri','Female','Hydrabad','9798949596');
insert into Tbl_Customer values(115,'Laxmikant','Male','Hydrabad','9798949596');


create trigger tr_insteadofTrigger_customer
on Tbl_Customer
instead of insert
as
begin
print'You are not allowed to insert data in this table !!'
end

drop trigger tr_insteadofTrigger_customer;




create trigger tr_insteadofTrigger_Updatecustomer
on Tbl_Customer
instead of Update
as
begin
print'You are not allowed to Update data in this table'
end

drop trigger tr_insteadofTrigger_Updatecustomer

update Tbl_Customer set City = 'Pune' where Id = 115;


create trigger tr_insteadofTrigger_Deletecustomer
on Tbl_Customer
instead of Delete
as
begin
Print'You are not allowed to Delete data in this table'
end

drop trigger tr_insteadofTrigger_Deletecustomer;

Delete from Tbl_Customer where Id=115;



create table Customer_Audit_table(Audit_id int primary key identity, Audit_information varchar(max));
select*from Customer_Audit_table;


create trigger tr_Audit_insert
on Tbl_Customer
instead of insert
as
begin
insert into Customer_Audit_table values('SomeOne tries to insert data in Cutomer table at :' +  CAST( GetDate() as varchar(max)))
end

insert into Tbl_Customer values(114,'Danshri','Female','Hydrabad','9798949596');
insert into Tbl_Customer values(115,'Laxmikant','Male','Hydrabad','9798949596');

select*from Customer_Audit_table;


create trigger tr_Audit_Update
on Tbl_Customer
instead of Update
as
begin
insert into Customer_Audit_table values('SomeOne tries to Update data in Cutomer table at :' +  CAST( GetDate() as varchar(max)))
end

update Tbl_Customer set City = 'Pune' where Id = 115;
select*from Customer_Audit_table;


create trigger tr_Audit_Delete
on Tbl_Customer
instead of Delete
as
begin
insert into Customer_Audit_table values('SomeOne tries to Delete data in Cutomer table at :' +  CAST( GetDate() as varchar(max)))
end

delete from Tbl_Customer where id = 115;
select*from Customer_Audit_table;

sp_helptext tr_Audit_Delete;


alter trigger tr_Audit_Delete
on Tbl_Customer
with encryption
instead of Delete
as
begin
insert into Customer_Audit_table values('SomeOne tries to Delete data in Cutomer table at :' +  CAST( GetDate() as varchar(max)))
end