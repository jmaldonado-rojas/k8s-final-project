-- Creates the main table: Person
USE mywebapi_db;
CREATE TABLE Person (
 Id INT NOT NULL AUTO_INCREMENT,
 Name VARCHAR(255) NOT NULL,
 LastName VARCHAR(255) NOT NULL,
 Role VARCHAR(255) NOT NULL,
 PRIMARY KEY (Id)
);

-- Inserts a Person for testing
INSERT INTO mywebapi_db.Person(Name,LastName,Role) VALUES ("Jimmy","Maldonado","DevOps"); 
