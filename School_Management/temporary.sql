-- Create the database
CREATE DATABASE IF NOT EXISTS retail_receipts;

-- Use the created database
USE retail_receipts;

-- Create a table for items
CREATE TABLE Items (
    Item_ID INT PRIMARY KEY,
    Item_Name VARCHAR(255) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);

-- Create a table for receipts
CREATE TABLE Receipts (
    Receipt_ID INT PRIMARY KEY,
    Receipt_Date DATE NOT NULL,
    Total_Amount DECIMAL(12, 2) NOT NULL
);

-- Create a junction table to represent the many-to-many relationship between receipts and items
CREATE TABLE Receipt_Items (
    Receipt_ID INT,
    Item_ID INT,
    Quantity INT NOT NULL,
    PRIMARY KEY (Receipt_ID, Item_ID),
    FOREIGN KEY (Receipt_ID) REFERENCES Receipts(Receipt_ID),
    FOREIGN KEY (Item_ID) REFERENCES Items(Item_ID)
);
