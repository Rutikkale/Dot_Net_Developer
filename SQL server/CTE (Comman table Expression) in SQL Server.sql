use [Practice ];

select*from Student_tbl;

with New_CTE
as
(
select*from Student_tbl where std_gender='Male'
)select*from New_CTE;

with New_CTE
as
(
select*from Student_tbl where std_gender='Male'
)select Count(*) from New_CTE;

with New_CTE
as
(
select*from Student_tbl where std_gender='Male'
)select*from New_CTE where std_age >=17;

with New_CTE
as
(
select*from Student_tbl where std_gender='Male'
)--select 'Hellow Worlds'
select*from New_CTE where std_age >=17;


With New_CTE(id,name)
as
(
select std_id,std_name from Student_tbl where std_gender='Male'
)
select * from New_CTE;


With New_CTE(id,name,Age)
as
(
select std_id,std_name, std_age from Student_tbl where std_gender='Male'
)
select * from New_CTE;

-----------------------------

with New_CTE
as
(
select *from Student_tbl
)
insert into New_CTE values(7,'Rutik','Male',23,12,2);

------------------------------

with New_CTE
as
(
select*from Student_tbl
)
update New_CTE set std_name='Arpit' where std_id=7;

------------------------------

with New_CTE 
as
(
select*from Student_tbl
)
delete  New_CTE where std_id=7;

------------------------------

create view VwMyNewView
as
with New_CTE
as
(
select*from Student_tbl where std_class=12
)
select*from New_CTE ;

select*from VwMyNewView;


------------------------------

with New_CTE
as
(
select*from Student_tbl where std_class=12
),
New_CTE_2
as
(
select*from Student_tbl where std_class=11
)
select*from New_CTE
union all
select*from New_CTE_2


------------------------------


With New_CTE
as
(
select count(*) as[Total Male Student ] from Student_tbl where std_gender='Male'
)
select * from New_CTE ;

