--DDL--

CREATE TABLE Employee
(
EId NVARCHAR(20) PRIMARY KEY NOT NULL,
E_Name NVARCHAR(50),
DOJ DATE,
Department NVARCHAR(50)
);

CREATE TABLE Ticket
(
TicketId INT PRIMARY KEY NOT NULL,
LoggedBy NVARCHAR(20) FOREIGN KEY REFERENCES Employee (Eid),
RaisedDate Date,
Severity NVARCHAR(20),
TDescription NVARCHAR(100),
ResolvedBy NVARCHAR(20),
Resolution NVARCHAR(50),
ResolvedDate Date,
TStatus NVARCHAR(20)
);


--DML--
INSERT [dbo].[Employee] Values('E100100','Venkat','2004-1-10','MGM');

INSERT [dbo].[Employee] Values('E100101','Krishna','2004-1-10','MGM');
INSERT [dbo].[Employee] Values('E100102','Chandrashekhar','2005-3-11','DEV');
INSERT [dbo].[Employee] Values('E100103','Saheer Ali Khan','2008-10-13','DEV');
INSERT [dbo].[Employee] Values('E100104','Shashikanth','2007-2-17','DEV');
INSERT [dbo].[Employee] Values('M100103','Avinash','2007-3-10','DEVOPS');
INSERT [dbo].[Employee] Values('M100105','Ashok','2008-6-18','DEVOPS');

Select*from dbo.Employee;

INSERT [dbo].[Ticket] VALUES(1,'E100101','2012-10-3','Major','App server not working','M100103','Need to restart with LAN cable','2012-10-4','CLOSED');

INSERT [dbo].[Ticket]([LoggedBy],[RaisedDate],[Severity],[TDescription],[TStatus]) VALUES('E100104','2013-7-10','Critical','Laptop restart problem','OPEN')

select * from dbo.Ticket;