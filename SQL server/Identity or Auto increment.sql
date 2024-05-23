use Batch_01_2024;

----Identity Or Auto Increment-----
create table Teacher_tbl (T_id int primary key identity,
                          T_Name varchar(50),
						  T_Qualification varchar(50),
						  T_Salary int not null);
select*from Teacher_tbl;

insert into Teacher_tbl values('rutik','BE',100000);
insert into Teacher_tbl values('Harshal','B-Tech',100000);
insert into Teacher_tbl values('Rupesh','ME',100000);
insert into Teacher_tbl values('Yash','M-Tech',5000);

----Identity with condition ----------------

drop table Teacher_tbl;
create table Teacher_tbl (T_id int primary key identity(100,5),
                          T_Name varchar(50),
						  T_Qualification varchar(50),
						  T_Salary int not null);

insert into Teacher_tbl values('rutik','BE',100000);
insert into Teacher_tbl values('Harshal','B-Tech',100000);
insert into Teacher_tbl values('Rupesh','ME',100000);
insert into Teacher_tbl values('Yash','M-Tech',5000);

select*from Teacher_tbl;