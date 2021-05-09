create database VideoLibrary;

use VideoLibrary;

create table Members(
ID int PRIMARY KEY UNIQUE AUTO_INCREMENT,
Name varchar(50) NOT NULL,
Address varchar(50) NOT NULL,
Contact varchar (50) NOT NULL,
MembershipDate date NOT NULL,
Status varchar(50)
);

create table Movies(
ID int PRIMARY KEY UNIQUE AUTO_INCREMENT,
Name varchar(50) NOT NULL,
Genre varchar(50) NOT NULL,
Year year NOT NULL,
Status varchar(50)
);

create table Loans(
ID int PRIMARY KEY UNIQUE AUTO_INCREMENT,
Member int NOT NULL,
Movie int NOT NULL,
FOREIGN KEY (Member) REFERENCES Members(ID) on delete cascade on update cascade,
FOREIGN KEY (Movie) REFERENCES Movies(ID) on delete cascade on update cascade,
MovieReserved varchar(50)
);