USE Batch_01_2024
select*from MyDepartment;

select*from Employee_Details;

----Between, Top, Percent, Distinct, And, In, Not Operator in SQL Server----------
select*from Employee_Details where Salary between 50000 and 70000;
select top 5 *from Employee_Details;
select top 40percent*from Employee_Details;
select Distinct Gender From Employee_Details;
select*from Employee_Details where City in('pune','Nagpur');
select*from Employee_Details where City not in('pune','Nagpur');