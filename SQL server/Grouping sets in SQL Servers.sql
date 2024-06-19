Use Batch_01_2024;

create table Employee_Salary_tbl(Id int primary key identity,
                                 Name varchar(50),
								 Gender varchar(50),
								 City varchar(50),
								 Salary int);
select*from Employee_Salary_tbl;

----Grouping sets in SQL Server---------------------
select City, Gender, sum(Salary) as Total_Salary from Employee_Salary_tbl
group by 
grouping sets
(
(City, Gender),
(City),
(Gender),
()
)
Order by grouping(City),grouping(Gender) asc;

------------With out Grouping Set using of Group by and Union Clause-------------

select City,Gender,Sum(Salary) as Total_Salary from Employee_Salary_tbl
Group by City,Gender

union all

select City,Null as [Male / Female],Sum(Salary) as Total_Salary from Employee_Salary_tbl
Group by City

union all

select Null as City,Gender,Sum(Salary) as Total_Salary from Employee_Salary_tbl
Group by Gender

union all

select Null as City,null,Sum(Salary) as Total_Salary from Employee_Salary_tbl
Group by ();


