use Trigger_DB

create table student (id int,
                      name varchar(50),
					  Age int,
					  class int);
drop table student; 
select*from student;

insert into student values (1,'Shrusti',8,1)
insert into student values (2,'Surbhi',9,2)
insert into student values (3,'sweta',14,7)
insert into student values (4,'Sakshi',11,4)
insert into student values (5,'Harshu',11,5)
insert into student values (6,'Shivani',11,5)
insert into student values (7,'sherya',8,2)

create trigger tr_insert_student3
on student
after insert
as
begin
print '3rd trigger is fired !!'
end

create trigger tr_insert_student2
on student
after insert
as
begin
print '2rd trigger is fired !!'
end

create trigger tr_insert_student1
on student
after insert
as
begin
print '1rd trigger is fired !!'
end

execute sp_settriggerorder
@triggername ='tr_insert_student1',
@order='first',
@stmttype = 'insert';

execute sp_settriggerorder
@triggername='tr_insert_student3',
@order ='Last',
@stmttype='Insert';