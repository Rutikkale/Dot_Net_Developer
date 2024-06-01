USE Batch_01_2024
select*from MyDepartment;

select*from Employee_Details;

---Scalar subquery---------
select*from Employee_Details
where id =
(select Id from MyDepartment where Dept_Name='Accounts');

----MultiValued Subqueries---------
select*from Employee_Details
where Name in
(select Name from Employee_Details where gender='Male');

select*from Employee_Details
where Salary <any
(select Salary from Employee_Details where Name='Rutik' 
OR Name='Prachi');

select*from Employee_Details
where Salary <all
(select Salary from Employee_Details where Name='Rutik' 
OR Name='Prachi');