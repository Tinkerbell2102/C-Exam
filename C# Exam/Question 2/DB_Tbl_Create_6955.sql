CREATE TABLE frmAddress (
    ID int NOT NULL PRIMARY KEY,
    ComplexNumber int,
    ComplexName varchar(255),
    Street varchar(255),
    Suburb varchar(255),
	City varchar(255),
	Provice varchar(255),
	Country varchar(255),
	PostalCode int
);
CREATE TABLE frmCustomer (
    CustomerID int NOT NULL PRIMARY KEY,
    Fullname varchar(255),
    ContactNumber text,
    Email varchar(255),
    AdressId varchar(255)
);
CREATE TABLE frmFreight (
    ID int NOT NULL PRIMARY KEY,
    CustomerID int,
    Height float,
    Weight float,
	Lenght float,
	DestanationAdressID varchar(255),
	OrginAdressID varchar(255),
	StatusID varchar(255),
	FreightDate date
);
CREATE TABLE frmStatus (
    ID int NOT NULL PRIMARY KEY,
    DatePickedUp date,
    DateDeliverd date,
    DriverID int
);
CREATE TABLE frmDriver (
    DriverID int NOT NULL PRIMARY KEY,
    LicenseType varchar(255),
    Owner text
);