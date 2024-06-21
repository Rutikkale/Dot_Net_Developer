use [Practice ];

create table FullNameTbl(Id int primary key identity,
                         FirstName varchar(50),
                         MiddleName varchar(50),
						 LastName Varchar(50));

drop table FullNameTbl;

insert into FullNameTbl(MiddleName) values('Kisanrao');
insert into FullNameTbl(LastName) values('Kale');
insert into FullNameTbl(FirstName) values('Arpit');
insert into FullNameTbl(MiddleName) values('Kisanrao');

select*from FullNameTbl;
select Id, coalesce(FirstName,MiddleName,LastName) from FullNameTbl;