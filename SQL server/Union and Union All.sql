use Batch_01_2024;

create table footBallParticipants(id int,Name Varchar(50),Email varchar(50));
 
insert into footBallParticipants values (1,'Rutik','rutik@gmail.com');
insert into footBallParticipants values (2,'Arpit','Arpit@gmail.com');
insert into footBallParticipants values (3,'NagaArjun','NagaArjun@gmail.com');
insert into footBallParticipants values (4,'Roshan','Roshan@gmail.com');
insert into footBallParticipants values (5,'Ramkant','Ramkantk@gmail.com');

select*from footBallParticipants;

create table HockeyParticipants(id int,Name Varchar(50),Email varchar(50));
 
insert into HockeyParticipants values (1,'Rutik','rutik@gmail.com');
insert into HockeyParticipants values (2,'Priya','Priya@gmail.com');
insert into HockeyParticipants values (3,'Rajni','Rajni@gmail.com');
insert into HockeyParticipants values (4,'Rahul','Rahul@gmail.com');
insert into HockeyParticipants values (5,'Sanket','Sanket@gmail.com');

select*from HockeyParticipants;

select*from footBallParticipants
union
select*from HockeyParticipants

select*from footBallParticipants
union all
select*from HockeyParticipants

select*from footBallParticipants
intersect
select*from HockeyParticipants

select*from footBallParticipants
Except
select*from HockeyParticipants

