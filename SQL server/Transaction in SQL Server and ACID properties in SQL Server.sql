use Batch_01_2024;

create table Student_Details(Id int primary key,
                             Name varchar(50),
							 Age int,
							 Class int);
select*from Student_Details;

insert into Student_Details values(1,'Rutik',14,7);
insert into Student_Details values(2,'Sanket',12,5);
insert into Student_Details values(3,'Sourabh',14,7);
insert into Student_Details values(4,'Shardha',11,6);

update Student_Details set Name='King' where Id=1; --implicit transaction


begin transaction --explicit transaction
update Student_Details set Name='Rutik' where Id=1;

rollback transaction; --undo

commit transaction;--Permanent save in table

-------------------------------------------------------

begin transaction 
update Student_Details set Name='Rutik' where Id=1;
delete from Student_Details where Id=4;

select*from Student_Details;

rollback transaction; --undo

commit transaction;--Permanent save in table

set transaction isolation level read uncommitted;-- are show committed data as well as show Uncommitted data