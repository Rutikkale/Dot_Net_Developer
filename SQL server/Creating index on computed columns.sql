use Batch_01_2024

create  table Products_Sales(Product_Id int primary key,
                      Product_Name varchar(50),
					  [Product Price] int not null,
					  [Product Quantity] int not null,
					  Total_Cost as [Product Price]*[Product Quantity]);

select*from Products_sales;
drop table Products_Sales;

insert into Products_Sales values(1,'Soap',50,2);
insert into Products_Sales values(2,'Hair Oil',69,3);
insert into Products_Sales values(3,'Shammpu',25,4);
insert into Products_Sales values(4,'EarePhone',20,2);
insert into Products_Sales values(5,'Bulthoot specker',70,1);
insert into Products_Sales values(6,'Mouse',250,4);

create index IX_TotalCost
on Products_Sales(Total_Cost ASC);

select*from Products_sales where Total_Cost >500;

sp_helpindex Products_sales;
