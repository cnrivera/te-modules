-- ********* LEFT JOIN ***********

-- (There aren't any great examples of left joins in the "dvdstore" database, so the following queries are for the "world" database)

-- A Left join, selects all records from the "left" table and matches them with records from the "right" table if
-- a matching record exists.


-- Let's display a list of all countries and their capitals, if they have some.
SELECT *
FROM country
JOIN city ON country.capital = city.id

SELECT *
FROM country
LEFT JOIN city ON country.capital = city.id

SELECT count(*)
FROM  country

-- Only 232 rows


-- But we’re missing entries:

-- There are 239 countries. So how do we show them all even if they don’t have a capital?


-- That’s because if the rows don’t exist in both tables, we won’t show any information for it. If we want to show data FROM the left side table everytime, we can use a different join: