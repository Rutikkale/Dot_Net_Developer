use Batch_01_2024;

select*from Student_Details;

begin try
begin transaction
insert into Student_Details Values (4,'Pooja',12,5)
insert into Student_Details values (5,'Priti',10,4)
insert into Student_Details Values (6,'Riyansh',7,2)
insert into Student_Details values (7,'Rani',8,2)
commit transaction -- permanent data save
 print 'Transaction Succesfully Done!!'
end try
begin catch
rollback transaction --undo
 print 'transaction Failed !!'
 select ERROR_MESSAGE() as [Error Message]
end catch

----------------------------

begin try
begin transaction
insert into Student_Details Values (8,'Pooja',12,5)
insert into Student_Details values (9,'Priti',10,4)
insert into Student_Details Values (9,'Riyansh',7,2)
commit transaction -- permanent data save
 print 'Transaction Succesfully Done!!'
end try
begin catch
rollback transaction --undo
 print 'transaction Failed !!'
 select ERROR_MESSAGE() as [Error Message]
end catch