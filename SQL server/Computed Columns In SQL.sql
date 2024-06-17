use Batch_01_2024;

------------Non-Persisted Computed---------------

create table Employee_Payroll(EmpId int primary key identity,
                              EmpName varchar(50),
							  Designation varchar(50),
							  [Basic Pay] int,
							  [House Rent Allowance] int,
							  [Convence Allowance] int,
							  [Medical Allowance] int,
							  [Gross Pay] as [Basic Pay] + [House Rent Allowance] + [Convence Allowance]+ [Medical Allowance] );
							 
select*from Employee_Payroll;	 

alter table Employee_Payroll add [Company Name] as 'Sukhakarta Consulant Services'
alter table Employee_Payroll add [Date] as GetDate();
alter table  Employee_Payroll drop column [Gross Pay];
alter table Employee_Payroll add Bonus as [Gross Pay]+2000;--erro --Not allowed to used Computed column in another column compute--

insert into Employee_Payroll values('Rutik','Manager',25000,7000,5000,5000);
insert into Employee_Payroll values('Aniket','Hr Manager',20000,7000,5000,5000);
insert into Employee_Payroll values('Arpit','Manager lead',35000,7000,5000,5000);
insert into Employee_Payroll values('Arun','Dot Net Developer',25000,7000,5000,5000);
insert into Employee_Payroll values('Vaibhavi','Developer',20000,7000,5000,5000);
insert into Employee_Payroll values('Vanshika','Data Analaties',26000,7000,5000,5000);

------------Persisted Computed---------------
drop table Employee_Payroll;

create table Employee_Payroll(EmpId int primary key identity,
                              EmpName varchar(50),
							  Designation varchar(50),
							  [Basic Pay] int,
							  [House Rent Allowance] int,
							  [Convence Allowance] int,
							  [Medical Allowance] int,
							  [Gross Pay] as [Basic Pay] + [House Rent Allowance] + [Convence Allowance]+ [Medical Allowance]  Persisted );
							 
select*from Employee_Payroll;

update Employee_Payroll set [Basic Pay] =45000 where EmpId=1;
select [Gross Pay] from Employee_Payroll ;
select [Gross Pay] from Employee_Payroll where EmpId=1;
select*from Employee_Payroll Order By [Gross Pay] asc;
select*from Employee_Payroll where [Gross Pay]>25000;

update Employee_Payroll set [Gross Pay] =2000 where EmpId=1;--error
/*The column "Gross Pay" cannot be modified because it is either
a computed column or is the result of a UNION operator.*/

----------------Another Example of Computed Column-----------
create  table Products_Sales(Product_Id int primary key,
                      Product_Name varchar(50),
					  [Product Price] int not null,
					  [Product Quantity] int not null,
					  [Total Price] as [Product Price]*[Product Quantity] persisted);

select*from Products_sales;
drop table Products_Sales;

insert into Products_Sales values(1,'Soap',50,2);
insert into Products_Sales values(2,'Hair Oil',69,3);
insert into Products_Sales values(3,'Shammpu',25,4);