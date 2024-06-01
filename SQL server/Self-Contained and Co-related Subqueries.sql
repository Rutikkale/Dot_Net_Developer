USE Batch_01_2024
select*from MyDepartment;

select*from Employee_Details;

----------self-Contained Sub-queries---------------
select*from Employee_Details
where Id in
(Select Id from Employee_Details where Gender ='Male')

select*from Employee_Details
where Id in
(select Id from MyDepartment where Dept_Name='HR')

---------Co-related Subqueries---------------------
select*from Employee_Details as E
where E.id in
(select D.id from MyDepartment as D where E.Gender='Male')

select*from Employee_Details as E
where E.id in
(select D.id from MyDepartment as D where E.Gender='Female')

select*from Employee_Details as E
where E.id in
(select D.id from MyDepartment as D where E.Salary >50000)

select*from Employee_Details as E
where E.id in
(select D.id from MyDepartment as D where E.Salary <=80000)

select*from Employee_Details
where Salary in
(select min(Salary) from Employee_Details);

select*from Employee_Details
where Salary in
(select max(Salary) from Employee_Details);