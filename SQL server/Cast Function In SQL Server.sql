--Cast Function In SQL Server
use [Practice ];

create table employee(Id int Primary Key identity,
                      Name varchar(50),
					  Joining_date datetime);

select*from employee;
drop table employee;
truncate table employee;

insert into employee values('King',GETDATE());
insert into employee values('Arpit',GETDATE());
insert into employee values('Rutik',GETDATE());
insert into employee values('Anjali',GETDATE());
insert into employee values('Sanskruti',Cast('2014-07-24' as datetime));
insert into employee values('Sanskruti',Cast('2014-07-24 12:24' as datetime));

select cast ('2022-01-25'as datetime)
select cast (98.8 as int) as value;

select*from employee;

select Name+'-' + CAST(Id as varchar) from employee;

insert into employee values('Rutik' + cast(26 as varchar), GETDATE())

select*from employee where Joining_date= '2014-07-24 ';

select*from employee where cast( Joining_date as date)= '2014-07-24 ' ;
select Id,Name,Cast(Joining_date as date)from employee;

select Id,Name,Cast(Joining_date as date)from employee
where Joining_date ='2014-07-24';

select cast(Joining_date as date),count(Id) from employee
group by cast(Joining_date as date);