if not exists(select * from sys.databases where name = 'MyAwesomeDatabase')
BEGIN
    create database MyAwesomeDatabase
END


USE MyAwesomeDatabase;
GO


if not exists (select * from sysobjects where name='Customer')
   Create Table Customer(
 Id int Identity Primary Key,
 FirstName NVARCHAR(100),
 LastName NVARCHAR(100),
 Email NVARCHAR (100)
);
go


if not exists (select * from sysobjects where name='Orders')
   Create Table Orders(
 Id int Identity Primary Key,
 CustomerId int,
  OrderDescription NVARCHAR(100),
  Quantity int,
  Cost money
 Foreign Key (CustomerId) References Customer (Id)
);
go


Insert into Customer VALUES ('Mahesh','Moodley','mail@mail.com')
Insert into Customer VALUES ('Nicholas','Chetty','mail@mail.com')
Insert into Customer VALUES ('Sachin','Moodley','mail@mail.com')
Insert into Customer VALUES ('Braam','Neethling','mail@mail.com')

Insert into Orders(CustomerId,OrderDescription,Quantity,Cost) VALUES (1,'I9 Gaming Pc',1,25000)
Insert into Orders(CustomerId,OrderDescription,Quantity,Cost) VALUES (1,'RTX 2080 TI',1,18000)

select * from Customer

select O.OrderDescription, O.Quantity, O.Cost from Orders O  INNER JOIN Customer c on c.Id = O.CustomerId
Where c.FirstName ='Mahesh'







