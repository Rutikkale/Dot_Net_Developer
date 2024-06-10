USE Batch_01_2024

Select*from Student_tbl;

insert into Student_tbl values('Prachi','Krupal',8,25000)
insert into Student_tbl values('Kalyani','Shiva',7,22000)
insert into Student_tbl values('Sakshi','Pravin',2,2500)
insert into Student_tbl values('Sayali','Pramod',6,2100)
insert into Student_tbl values('Sayali','Pramod',6,2100)


create trigger tr_student_ForInsert
on Student_tbl
after insert 
as
begin
print'something happened to the Student Table';
end


alter trigger tr_student_ForInsert
on Student_tbl
after insert 
as
begin
select*from inserted;
end

create trigger tr_student_ForDelete
on Student_tbl
after delete
as
begin
select*from deleted;
end


Select*from Student_tbl;
delete from Student_tbl where Student_id=114;
delete from Student_tbl where Student_id=112;
delete from Student_tbl where Student_id=113;
delete from Student_tbl where Student_id=111;

----------------
create table tbl_Student_Audit(Audit_Id int primary key identity,
                               Audit_Info varchar(Max));
select*from tbl_Student_Audit;
drop table tbl_Student_Audit;
truncate table tbl_Student_Audit

---------------
Create trigger tr_Audit_Student_ForInsert
on Student_tbl
after insert
as
begin
declare @Id int
select @Id = Student_id from inserted
insert into tbl_Student_Audit values('Student with id '+CAST(@Id as  varchar(50))  +' is added at'+CAST(GETDATE() as varchar(50)));
end

select*from tbl_Student_Audit;

-----------------------for change in trigger-------------------
alter trigger tr_Audit_Student_ForInsert
on Student_tbl
after insert
as
begin
declare @Id int
select @Id = Student_id from inserted
insert into tbl_Student_Audit values('Student with id '+CAST(@Id as  varchar(50))  +' is added at '+CAST(GETDATE() as varchar(50)));
end

select*from tbl_Student_Audit;


-------------------
create trigger tr_Audit_Student_ForDelete
on Student_tbl
after delete
as
begin
declare @Id int
select @Id = Student_id from deleted
insert into tbl_Student_Audit values('Existing Student with id '+CAST(@Id as  varchar(50))  +' is deleted at '+CAST(GETDATE() as varchar(50)));
end

select*from tbl_Student_Audit;

delete from Student_tbl where Student_id =117;
--------------------------------
create trigger tr_student_ForUpdate
on Student_tbl
after update
as
begin
select*from inserted;
select*from deleted;
end

Select*from Student_tbl;

update Student_tbl set Student_Name='Sayali' ,Father_Name='Ashok' where Student_id=124 ;

SP_HELPTEXT tr_student_ForUpdate;