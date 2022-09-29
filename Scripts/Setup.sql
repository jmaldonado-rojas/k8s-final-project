-- Creates the database for the app: MyWebApi_DB
DROP DATABASE IF EXISTS MyWebApi_DB;
CREATE DATABASE MyWebApi_DB;

-- Creates the main table: Person
USE MyWebApi_DB;
CREATE TABLE Person (
 Id INT NOT NULL AUTO_INCREMENT,
 Name VARCHAR(255) NOT NULL,
 LastName VARCHAR(255) NOT NULL,
 Role VARCHAR(255) NOT NULL,
 PRIMARY KEY (Id)
);

-- Inserts a Person for testing
INSERT INTO mywebapi_db.person(Name,LastName,Role) VALUES ("Jimmy","Maldonado","DevOps"); 