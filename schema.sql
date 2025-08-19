CREATE DATABASE LibraryDB;
GO

USE LibraryDB;

CREATE TABLE Books (
    Id INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(100),
    Author NVARCHAR(100),
    IsAvailable BIT
);

CREATE TABLE Members (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);

CREATE TABLE Transactions (
    Id INT PRIMARY KEY IDENTITY,
    BookId INT FOREIGN KEY REFERENCES Books(Id),
    MemberId INT FOREIGN KEY REFERENCES Members(Id),
    IssueDate DATE,
    ReturnDate DATE
);