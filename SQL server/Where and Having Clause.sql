USE Batch_01_2024

create table Employee_Details( Id int primary key identity,
                               Name varchar(50),
							   Gender varchar(50),
							   Salary int ,
							   City varchar(50));

insert into Employee_Details values ('Rutik','Male',60000,'Nagpur');
insert into Employee_Details values ('Rupesh','Male',65000,'Pune');
insert into Employee_Details values ('Sachin','Male',80000,'Nagpur');
insert into Employee_Details values ('Pratik','Male',60000,'Nagpur');
insert into Employee_Details values ('Krish','Male',550000,'Pune');
insert into Employee_Details values ('Priyanka','Male',65000,'Indore');
insert into Employee_Details values ('Prachi','Male',68000,'Nashik');
insert into Employee_Details values ('Janhavi','Female',20000,'Aamaravati');
insert into Employee_Details values ('Hement','Male',65000,'Pune');
insert into Employee_Details values ('Prasad Kale','Male',70000,'Nagpur');

select*from Employee_Details;

select City , sum(Salary) as [Total Salary] 
from Employee_Details
group by City
having City in ('Nagpur')


select City , sum(Salary) as [Total Salary] 
from Employee_Details
where City in ('Nagpur')
group by City

select City , sum(Salary) as [Total Salary] 
from Employee_Details
where City in ('Indore','Nagpur','Pune')
group by City
having sum(salary) >40000;

-----------------------------------------------
create table Product_sales(Product_Name varchar(50),
                           Sales_Amount int);

insert into Product_sales (Product_Name,Sales_Amount) values ('Pendrive',1000);
insert into Product_sales (Product_Name,Sales_Amount) values ('Harddrive',100);
insert into Product_sales (Product_Name,Sales_Amount) values ('Monitor',500);
insert into Product_sales (Product_Name,Sales_Amount) values ('Mouse',600);
insert into Product_sales (Product_Name,Sales_Amount) values ('Laptop',300);
insert into Product_sales (Product_Name,Sales_Amount) values ('Mobile charger',400);
insert into Product_sales (Product_Name,Sales_Amount) values ('Pendrive',1000);
insert into Product_sales (Product_Name,Sales_Amount) values ('Harddrive',100);
insert into Product_sales (Product_Name,Sales_Amount) values ('Monitor',500);
insert into Product_sales (Product_Name,Sales_Amount) values ('Mouse',600);
insert into Product_sales (Product_Name,Sales_Amount) values ('Laptop',300);
insert into Product_sales (Product_Name,Sales_Amount) values ('Mobile charger',400);

select*from Product_sales;

select Product_Name, sum(Sales_Amount) as [total amount] from Product_sales
where Product_Name not in('Laptop')
group by Product_Name
having  sum(Sales_Amount)>=500;

select Product_Name, sum(Sales_Amount) as [total amount] from Product_sales
where Product_Name  in('Laptop')
group by Product_Name
having  sum(Sales_Amount)>=500;

select Product_Name, sum(Sales_Amount) as [total amount] from Product_sales
group by Product_Name
having  sum(Sales_Amount)>=100;

select Product_Name, sum(Sales_Amount) as [total amount] from Product_sales
where Product_Name  in('Monitor')
group by Product_Name
