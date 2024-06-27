select GETDATE(); --24 hours formate 
select convert(varchar, GETDATE(),100); --12 hours formate

select SYSDATETIME();
select convert(varchar, sysdatetime(),100); --12 hours formate

select CURRENT_TIMESTAMP;

select DateName(MONTH,GETDATE());
select DateName(YEAR,GETDATE());
select DateName(DAY,GETDATE());
select DateName(HOUR,GETDATE());
select DateName(MINUTE,GETDATE());
select DateName(SECOND,GETDATE());
select DateName(YEAR,'17 jun 2024');
select DateName(Year,'07-17-2000');
select DateName(MONTH,'07-17-2000');

------------------- DateDiff with GetDateTime()----------

select DATEDIFF(YEAR,'07-17-2000',GETDATE());
select DATEDIFF(MONTH,'07-17-2000',GETDATE());
select DATEDIFF(DAY,'07-17-2000',GETDATE());
select DATEDIFF(MINUTE,'07-17-2000',GETDATE());
select DATEDIFF(SECOND,'07-17-2000',GETDATE());
select DATEDIFF(HOUR,'07-17-2000',GETDATE());

------------------- DateDiff with current_TimeStamp----------
select DATEDIFF(YEAR,'07-17-2000',CURRENT_TIMESTAMP);
select DATEDIFF(MONTH,'07-17-2000',CURRENT_TIMESTAMP);
select DATEDIFF(DAY,'07-17-2000',CURRENT_TIMESTAMP);
select DATEDIFF(MINUTE,'07-17-2000',CURRENT_TIMESTAMP);
select DATEDIFF(SECOND,'07-17-2000',CURRENT_TIMESTAMP);
select DATEDIFF(HOUR,'07-17-2000',CURRENT_TIMESTAMP);


select DATEADD(Month,2,GETDATE());
select DATEADD(HOUR,2,GETDATE());
select DATEADD(YEAR,2,GETDATE());
select dateadd(MINUTE,2,GETDATE());
select DATEADD(MONTH,-2,GETDATE());
select dateadd(day,2,Getdate());

select Datepart(MONTH,GETDATE()) as month;
select Datepart(YEAR,GETDATE()) as year;
select Datepart(DAY,GETDATE());
select Datepart(HOUR,GETDATE());
select Datepart(MINUTE,GETDATE());
select Datepart(SECOND,GETDATE());
select Datepart(MONTH,'january 21, 2024');
select Datepart(Year,'07-17-2000');
select Datepart(MONTH,'07-17-2000');

select Day(GETDATE());
select month(GETDATE());
select year(GETDATE());

select ISDATE('07-17-2000');
select ISDATE('asdfghjkl');