USE [World]

-- INSERT

-- 1. Add Klingon as a spoken language in the USA
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'Klingon', 1, 2.04)

SELECT *
FROM countrylanguage
WHERE language = 'Klingon';

-- 2. Add Klingon as a spoken language in Great Britain
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('GBR', 'Klingon', 0, 15.89)  

-- UPDATE

-- 1. Update the capital of the USA to Houston
UPDATE country
SET capital = 3796
WHERE code = 'USA'

SELECT * FROM country WHERE code = 'USA'

-- 2. Update the capital of the USA to Washington DC and the head of state
UPDATE country
	SET 
		capital = (SELECT id FROM city WHERE name = 'Washington'),
		headofstate = 'Joe'
	WHERE code = 'USA';

SELECT * FROM country WHERE headofstate = 'JOE'
SELECT * FROM city WHERE id = 3813
	SELECT id FFROM city WHERE name = 'washington'

-- DELETE

-- 1. Delete English as a spoken language in the USA

--DELETE FROM countrylanguage
WHERE language = 'English' AND countrycode = 'USA'


-- 2. Delete all occurrences of the Klingon language 
--DELETE FROM countrylanguage 
WHERE language = 'Klingon';

SELECT *
FROM countrylanguage
WHERE language = 'Klingon';

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.

INSERT INTO countrylanguage (countrycode)
VALUES('Elivsh');

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('ZZZ', 'English', 0, 65)
-- 3. Try deleting the country USA. What happens?
--DELETE FROM country WHERE code = 'USA'
SELECT * FROM country WHERE code = 'USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA
SELECT * FROM countrylanguage where countrycode = 'USA'
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'English', 0, 86.2)

-- 2. Try again. What happens? Constraint violation / duplicate key
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'English', 0, 86.2)

-- 3. Let's relocate the USA to the continent - 'Outer Space' -- it's a check constraint, so must set to existing value
UPDATE country 
SET continent = 'Puter Space'
WHERE code = 'USA'

-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.
BEGIN TRANSACTION

SELECT * FROM countrylanguage
DELETE FROM countrylanguage
SELECT FROM countrylanguage

ROLLBACK TRANSACTION

SELECT * from countrylanguage
--COMMIT


-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table
-- where one happens to be inside of a transaction but hasn't committed yet.