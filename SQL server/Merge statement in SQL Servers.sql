use Batch_01_2024;

create table Employee_Source(Id int Primary key, Name Varchar(50), Gender Varchar(50));

select*from Employee_Source;

insert into Employee_Source values(1,'King','Male');
insert into Employee_Source values(2,'Arpit','Male');
insert into Employee_Source values(3,'Priya','Female');

truncate table Employee_Source;


create table Employee_Target(Id int Primary key, Name Varchar(50), Gender Varchar(50));

select*from Employee_Target;


insert into Employee_Target values(1,'Rutik','Male');
insert into Employee_Target values(2,'Arpit','Male');
insert into Employee_Target values(3,'Priya','Female');
insert into Employee_Target values(4,'Shivani','Female');
insert into Employee_Target values(5,'Priyanka','Female');

truncate table Employee_Target;

select*from Employee_Source;
select*from Employee_Target;


Merge Employee_Target as T
using Employee_Source as S
on T.Id = S.Id
when matched then
update set T.Name =S.Name,T.Gender=S.Gender
when not Matched then
Insert (id,Name,Gender) Values(S.Id,S.Name,S.Gender)
when not Matched by Source then
Delete;


------------------------------------------------------------------------

truncate table Employee_Source;
truncate table Employee_Target;

Merge Employee_Target as T
using Employee_Source as S
on T.Id = S.Id
when matched then
update set T.Name =S.Name,T.Gender=S.Gender
when not Matched then
Insert (id,Name,Gender) Values(S.Id,S.Name,S.Gender);

select*from Employee_Source;
select*from Employee_Target;
