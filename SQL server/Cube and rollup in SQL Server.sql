Use Batch_01_2024;

create table Employee_Salary_tbl(Id int primary key identity,
                                 Name varchar(50),
								 Gender varchar(50),
								 City varchar(50),
								 Salary int);
select*from Employee_Salary_tbl;

insert into Employee_Salary_tbl values('Rutik','Male','Nagpur','60000');
insert into Employee_Salary_tbl values('Arpit','Male','Nagpur','70000');
insert into Employee_Salary_tbl values('Sarhavi','Female','Yavatmal','25000');
insert into Employee_Salary_tbl values('Anuga','Female','Yavatmal','60000');
insert into Employee_Salary_tbl values('Rushikesh','Male','Nagpur','65000');

select City,Gender, Sum(Salary) as Total_Salary from Employee_Salary_tbl
group by City,Gender;

select City,Gender, Sum(Salary) as Total_Salary from Employee_Salary_tbl
group by Cube(City,Gender);

select City,Gender, Sum(Salary) as Total_Salary from Employee_Salary_tbl
group by City,Gender with cube;


select City,Gender, Sum(Salary) as Total_Salary from Employee_Salary_tbl
group by ROLLUP(City,Gender);

select City,Gender, Sum(Salary) as Total_Salary from Employee_Salary_tbl
group by City,Gender with rollup;

select City, Sum(Salary) as Total_Salary from Employee_Salary_tbl
group by Cube(City);

select City, Sum(Salary) as Total_Salary from Employee_Salary_tbl
group by rollup(City);


