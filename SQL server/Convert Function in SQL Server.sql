--Convert() Function In SQL Server
use [Practice ];

select cast(54.25 as int);
select convert(int, 54.54);

declare @num1 decimal=24.45
select convert(int,@num1)
select @num1;

declare @num2 decimal=24.50
select convert(int,@num2)
select @num2;

select cast('2024-06-21' as date);

select CONVERT(date,'2024-07-25');

select GETDATE();
select convert(varchar,getdate(),0);
select convert(varchar,getdate(),1);
select convert(varchar,getdate(),2);
select convert(varchar,getdate(),102);

select*from employee;
select Name, convert(varchar,Joining_date) as Today_date from employee;
select *, convert(varchar,Joining_date) as Today_date from employee;
