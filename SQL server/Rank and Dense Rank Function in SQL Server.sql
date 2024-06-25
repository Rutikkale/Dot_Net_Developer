use [Practice ];

Create table Total_results
(
id int primary key identity,
Name varchar(50),
Gender varchar(10),
Age int,
Marks int,
);

select*from Total_results;

insert into Total_results values ('Vaibhavi','Female',17,85);
insert into Total_results values ('Pawan','Male',17,80);
insert into Total_results values ('Dinesh','Male',18,75);
insert into Total_results values ('Sachin','Male',16,75);
insert into Total_results values ('Dharavesh','Male',17,75);
insert into Total_results values ('Kunal','Male',18,67);
insert into Total_results values ('Purava','Male',16,65);
insert into Total_results values ('Rushikesh','Male',18,65);
insert into Total_results values ('Abhjeet','Male',17,57);
insert into Total_results values ('Rajvi','Female',16,55);

select Name, Gender,Age, Marks, rank() over (order by Marks desc) as Rank
from Total_results;

select Name,Gender,Age,Marks, rank()
over(Partition by Gender Order by Marks desc) as Rank
from Total_results;


select Name, Gender,Age, Marks, Dense_rank()
over (order by Marks desc) as [Dense Rank]
from Total_results;

select Name, Gender,Age, Marks, Dense_rank()
over (Partition by Gender order by Marks desc) as[Dense Rank]
from Total_results;

select Name, Gender, Age ,Marks, DENSE_RANK()
over (order by Marks desc) as [Dense Rank],
rank() over(order by Marks desc) as [Rank]
from Total_results;