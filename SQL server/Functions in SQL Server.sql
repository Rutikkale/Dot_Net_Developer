USE Batch_01_2024

-------Function With with-out Parameter -------
create function showMessage()
returns varchar(100)
as
begin
return 'This is Scalar funtion without parameter'
end

select dbo.showMessage();

-------Function With single Parameter -------
create function TakeNumber(@num as int)
returns int
as
begin
return (@num * @num)--Squre
end

select dbo.TakeNumber(2);

-------Function With Multiple-Parameter -------
create function Addition(@num1 as int , @num2 as int)
returns int
as
begin
return (@num1 + @num2)
end

select dbo.Addition(2,2)

-------Alter in scalar function-------
alter function TakeNumber(@num as int)
returns int
as
begin
return (@num * @num * @num)--Cuderoot
end

select dbo.TakeNumber(2)

drop function dbo.TakeNumber;

---using if else in scalar funtion-----------
create function CheckVoterAge(@Age as int)
returns varchar(100)
as
begin
declare @str varchar(100)
if(@Age>=18)
begin
 set @str ='You Are Eligible for Vote';
end
else
begin
 set @str ='You Are Not Eligible For Vote';
end
return @str
end

select dbo.CheckVoterAge(20);
select dbo.CheckVoterAge(17);


--------- Scalar Function Can Call other function----------
create function GetDateTime()
returns datetime
as
begin
return getdate()
end

select dbo.GetDateTime();