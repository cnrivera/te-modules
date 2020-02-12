SELECT TOP 10 *
FROM countrylanguage
--WHERE percentage > 1
ORDER BY percentage DESC

SELECT *
FROM countrylanguage
ORDER BY percentage
OFFSET 40 ROWS FETCH NEXT 20 ROWS ONLY

SELECT AVG(percentage)
FROM countrylanguage;

SELECT MIN(percentage)
FROM countrylanguage;

SELECT MAX(percentage)
FROM countrylanguage;

SELECT COUNT(*) -- count all the rows in a table
FROM countrylanguage;

SELECT COUNT(*)
FROM countrylanguage
WHERE percentage > 10;

SELECT SUM(percentage)
FROM countrylanguage
WHERE percentage > 10;

SELECT (countrycode + ', ' + language) AS codelanguage
FROM countrylanguage

SELECT * FROM city 
WHERE population = 
(SELECT MAX(population) FROM city
WHERE countrycode
SELECT code FROM country)
FROM city
WHERE countrycode 

SELECT countrycode FROM country
WHERE name = 'Germany'

SELECT AVG(percentage) AS highest_percentage, countrycode
FROM countrylanguage
GROUP BY countrycode
ORDER BY highest_percentage DESC
