SELECT *
FROM country
INNER JION countrycode ON country.code - countrylanguage, counntrycode
WHERE country.code = "abw"

SELECT *
FROM countrylanguage
JOIN country ON country.code = countrylanguage.countrycode
WHERE countrylanguage.language = 'English'
ORDER BY countryLanguage.percentage