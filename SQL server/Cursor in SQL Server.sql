use [Practice ];

select*from employee;

-----------WithOut Cursors Variables------------- 
declare MyCursor cursor scroll for select*from employee
open MyCursor
fetch first from MyCursor
fetch next from MyCursor
fetch Last from MyCursor
fetch prior from MyCursor
fetch absolute 6  from MyCursor
fetch relative 1  from MyCursor
close MyCursor
deallocate MyCursor;

-----------With Cursors Variables------------- 
declare MyCursor cursor scroll for select id,name from employee
declare @Emp_id int, @Emp_Name varchar(50)
open MyCursor
fetch first from MyCursor into @Emp_id , @Emp_Name
print 'Employees is:'+ cast(@Emp_id as varchar(5))+' '+ @Emp_Name
fetch last from MyCursor into @Emp_id, @Emp_Name
print 'Employees is:'+ cast(@Emp_id as varchar(5))+' '+ @Emp_Name
fetch next from MyCursor into @Emp_id, @Emp_Name
print 'Employees is:'+ cast(@Emp_id as varchar(5))+' '+ @Emp_Name
fetch Prior from MyCursor into @Emp_id, @Emp_Name
print 'Employees is:'+ cast(@Emp_id as varchar(5))+' '+ @Emp_Name
fetch Absolute 4 from MyCursor into @Emp_id, @Emp_Name
print 'Employees is:'+ cast(@Emp_id as varchar(5))+' '+ @Emp_Name
fetch relative 1 from MyCursor into @Emp_id, @Emp_Name
print 'Employees is:'+ cast(@Emp_id as varchar(5))+' '+ @Emp_Name
close MyCursor
deallocate MyCursor