use [Practice ];

create table Employee_Details (id int primary key ,
                      Name varchar(50),
					  Gender varchar(10),
					  Age int,
					  Salary int);
					  
insert into Employee_Details values (1,'Rutik','Male',23,250000);
insert into Employee_Details values (2,'Harshal','Male',25,200000);
insert into Employee_Details values (3,'Arpit','Male',20,250000);
insert into Employee_Details values (4,'Sanskruti','Female',23,25000);
insert into Employee_Details values (5,'Harsh','Male',23,25000);
insert into Employee_Details values (6,'Shehal','Female',20,25000);

select*from Employee_Details;

select Gender, count(*) as Gender_Total from Employee_Details 
group by Gender;

------------With Group by clause----------
select Id,Name,A.Gender,Genders.Gender_Total from Employee_Details as A
inner join
(select Gender, count(*) as Gender_Total from Employee_Details 
group by Gender) as Genders
on A.Gender = Genders.Gender;

------------With Over clause Partition By----------
select id ,Name, Gender ,Count(Gender) over (Partition By gender) as Gender_Total
from Employee_Details;

select *,Count(Gender) over (Partition By gender) as Gender_Total
from Employee_Details;

-----------------------Another Example---------------------

select Gender, count(*) as Gender_Total,
max(Salary) as Max_Salary,
Min(Salary) as Min_Salary,
Avg(Salary) as Average_Salary
from Employee_Details 
group by Gender;

select Name,Age,A.Gender,Genders.Gender_Total,Genders.Max_Salary,Genders.Min_Salary,Genders.Average_Salary from Employee_Details as A
inner join
(select Gender, count(*) as Gender_Total,
max(Salary) as Max_Salary,
Min(Salary) as Min_Salary,
Avg(Salary) as Average_Salary
from Employee_Details 
group by Gender
)as Genders
on A.Gender=Genders.Gender;


-------------------Over clause Partition By--------------

select *,Count(Gender) over (Partition By gender) as Gender_Total,
Min(Salary) over (Partition By gender) as Min_Salary,
Max(Salary) over (Partition By gender) as Max_Salary,
Avg(Salary) over (Partition By gender) as Avg_Salary
from Employee_Details;
