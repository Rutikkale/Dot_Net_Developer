use Batch_01_2024;

select*from Employee_Details;

select*from Employee_Details where Name like 'R%';
select*from Employee_Details where Name like '%k';
select*from Employee_Details where Name like '%ti%';
select*from Employee_Details where Name like 'R____';
select*from Employee_Details where Name like '_____k';
select*from Employee_Details where Name like '[r,p,s]%';
select*from Employee_Details where Name like '[a-z]%';
select*from Employee_Details where Name like '[A-K]%';
select*from Employee_Details where Name like '_u%';
select*from Employee_Details where Name like 'R%K';