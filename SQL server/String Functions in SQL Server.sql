USE Practice;

select ascii('a');--97
select ascii('z');--122
select ascii('A');--65
select ascii('Z');--90
select ascii(';');--59
select ascii('0');--48
select ascii('9');--57

select char(99);-- c

--a-z
declare @start int
set @start =97
while (@start <= 122)
begin
print char (@start)
set @start = @start + 1;
end

--a-z
declare @start int
set @start =97
while (@start <= 122)
begin
select char (@start)
set @start = @start + 1;
end

--0-9
declare @start int
set @start =48
while (@start <= 57)
begin
print char (@start)
set @start = @start + 1;
end

select ('  hello');
select ltrim('   hello');

create table BioData(First_Name varchar(50),Middle_Name varchar(50), Last_Name varchar(50));

insert into BioData Values('  Rutik','Kisanrao','Kale');
insert into BioData Values('  Harshal','Kisor','Ramtake');
insert into BioData Values(' Ramesh','Shamrao','Takare');
insert into BioData Values('Akshay','Vinod','Dheshmukh');

select*from BioData;
drop table BioData;

select ltrim(First_Name), Middle_Name, Last_Name,
rtrim(ltrim(First_Name)) +' '+ Middle_Name +' '+ Last_Name  as [Full name ] 
from BioData;

select Lower(Middle_Name) from BioData;
select upper(Middle_Name) from BioData;

select reverse(Last_Name) from BioData;

select len(First_Name) from BioData;
select ltrim(First_Name),len(First_Name) from BioData;
