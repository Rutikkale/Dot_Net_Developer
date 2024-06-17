use Batch_01_2024;

Create table Book (Book_Id int not null,
                   BookName varchar(50),
				   Categaory varchar(50),
				   Price int null,
				   Publisher varchar(50));

drop table Book;

Create table Book (Book_Id int unique not null,
                   BookName varchar(50),
				   Categaory varchar(50),
				   Price int null,
				   Publisher varchar(50));


insert into Book(Book_Id,BookName,Categaory,Price,Publisher)
values(1,'RichDad poorDad','Finance',450,'Robart kivosaki'),
(2,'Anotomy','Biology',700,'RD Chadha'),
(3,'Aptitude','Aptitude test',550,'RS Agraval'),
(4,'Gate','Civil Engineering',500,'Made Easy'),
(5,'Town Planning Assistance','Civil Engineering Compatetive',650,'Infinity'),
(6,'Asp.net core ','Programming',750,'Infinity.com'),
(7,'Think and Grow Rich','Finance',450,'Publisher');
 
 insert into Book Values (7,'Think and Grow Rich','Finance',450,'Publisher');
  insert into Book Values (8,'Think and Grow Rich','Finance',450,'Publisher');

 select*from Book;

 create Clustered index CIX_BOOK_BOOK_ID
 on Book(Book_Id asc);

 create Unique Clustered index CIX_BOOK_BOOK_ID
 on Book(Book_Id asc);

 create NonClustered index CIX_BOOL_BooK_Name
 on Book (BookName asc)

 delete from Book where Book_Id = 8;


 create Unique NonClustered index CIX_BOOL_BooK_Name
 on Book (BookName asc)

 
 sp_helpIndex Book;

