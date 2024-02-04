DROP DATABASE IF EXISTS retail;

CREATE DATABASE retail;

USE retail;

CREATE TABLE Store(
    Store_ID VARCHAR(10) NOT NULL PRIMARY KEY,
    Location VARCHAR(256) NOT NULL UNIQUE,
    Manager VARCHAR(256) NOT NULL UNIQUE,
    Number_of_employee INT NOT NULL,
    Total_Sale DOUBLE


);

CREATE TABLE Employees (
    Store_ID VARCHAR(10) NOT NULL,
    Employees_ID VARCHAR(10) NOT NULL,
    Name VARCHAR(256) NOT NULL,
    Position VARCHAR(256) DEFAULT NULL,
    Manager VARCHAR(256) DEFAULT NULL,
    PRIMARY KEY (Store_ID, Employees_ID),
    FOREIGN KEY(Name) REFERENCES Store(Manager)
);

CREATE TABLE Merchandise (
    Item_ID INT(10) NOT NULL,
    Item_name VARCHAR(256) NOT NULL,
    Price INT NOT NULL,
    Quantity INT NULL,
    Store_ID VARCHAR(10) NOT NULL,
    PRIMARY KEY(Item_ID, Store_ID),
    FOREIGN KEY (Store_ID) REFERENCES Store(Store_ID)
);

CREATE TABLE Networth(
    Store_ID VARCHAR(10) NOT NULL,
    Sale_date DATE NOT NULL,
    Sale_amount DOUBLE NOT NULL,
    Items INT NOT NULL,
    Transaction INT NOT NULL,
    PRIMARY KEY(Store_ID, Sale_date)
);

-- CREATE TABLE Items (
--     Barcode INT PRIMARY KEY,
--     Item_Name VARCHAR(255) NOT NULL,
--     Price DECIMAL(10, 2) NOT NULL,
--     FOREIGN KEY (Barcode) REFERENCES Merchandise(Barcode),
--     FOREIGN KEY (Price) REFERENCES Merchandise(Price),
--     FOREIGN KEY (Item_Name) REFERENCES Merchandise(Item_Name)
--  );


CREATE TABLE Receipts (
    Receipt_ID INT PRIMARY KEY,
    Receipt_Date DATE NOT NULL,
    Total_Amount DECIMAL(12, 2) NOT NULL
);


CREATE TABLE Receipt_Items (
    Receipt_ID INT,
    Item_ID INT,
    Quantity INT NOT NULL,
    PRIMARY KEY (Receipt_ID, Item_ID),
    FOREIGN KEY (Receipt_ID) REFERENCES Receipts(Receipt_ID),
    FOREIGN KEY (Item_ID) REFERENCES Merchandise(Item_ID)
);