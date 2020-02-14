
-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**
USE [dvdstore]

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor (first_name, last_name)
VALUES ('HAMPTON', 'AVENUE'), ('LISA', 'BYWAY')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

INSERT INTO film (title, description, release_year, language_id, original_language_id, rental_duration, rental_rate, length, replacement_cost, rating)
VALUES ('EUCLIDEAN PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, NULL, 4, 2.99, 198, 24.99, 'PG')


-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

INSERT INTO film_actor (actor_id, film_id)
VALUES (201, 1001), (202, 1001)


-- 4. Add Mathmagical to the category table.
INSERT INTO category (name)
VALUES ('Mathmagical')


-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

INSERT INTO film_category (film_id, category_id)
VALUES (1001, 17), (274, 17), (494, 17), (714, 17), (996, 17)


-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE film
SET film.rating = 'G'
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id = category.category_id
WHERE category.name = 'Mathmagical'


-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO inventory (film_id, store_id)
VALUES (1001, 1), (1001, 2)


-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
-- No, because it has a reference constraint because film_id connects to film_actor so that actors can be associated with the films.
-- Other data relies on film_id, so it cannot be removed directly.
BEGIN TRANSACTION
DELETE FROM film
WHERE film_id = 1001
ROLLBACK TRANSACTION

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
-- No, because it has a reference constraint that goes through film_category.
BEGIN TRANSACTION
DELETE FROM category
WHERE name = 'Mathmagical'
ROLLBACK TRANSACTION

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
-- Yes, because via film_category, the category can be removed from all the films.

BEGIN TRANSACTION
DELETE FROM film_category
WHERE category_id = 17
ROLLBACK TRANSACTION

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
-- Deleting 'Mathmagical' from category succeeded because we have removed the reference to this name in film_category, thus removing it from all films, so no films rely on it..
-- Deleting 'Euclidean PI' still does not work because we have not removed references to the film from film_actor, thus all the actor info still relies on it.
BEGIN TRANSACTION
DELETE FROM category
WHERE name = 'Mathmagical'
ROLLBACK TRANSACTION

BEGIN TRANSACTION
DELETE FROM film
WHERE title = 'EUCLIDEAN PI'
ROLLBACK TRANSACTION

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
--Objects that still depend on film_id include film_actor, film_category, inventory (rental, payment). We would need to remove all references 
--of Euclidean PI in these other tables in order to remove it from the film database.