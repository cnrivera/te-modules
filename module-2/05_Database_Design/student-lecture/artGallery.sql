USE master;

DROP DATABASE IF EXISTS ArtGallery;

CREATE DATABASE ArtGallery;
GO

USE ArtGallery

BEGIN TRANSACTION;

CREATE TABLE artists
(
	artist_id int identity(1,1),
	first_name varchar(50) NOT NULL,
	last_name varchar(100) NOT NULL,

	constraint pk_artist_id primary key(artist_id)
);

CREATE TABLE customers
(
	customer_id int identity(2000, 3),
	first_name varchar(100) NOT NULL,
	last_name varchar(100) NOT NULL,
	address varchar(200) NOT NULL,
	count int

	constraint  pk_customer_id primary key(customer_id)

);

CREATE TABLE artwork
(
	artwork_id int identity(1,1),
	title varchar(200) DEFAULT 'untitled' NOT NULL,
	artist_id int NOT NULL,

	constraint pk_art_id primary key(artwork_id),
	constraint fk_art_artist_id foreign key (artist_id) references artists (artist_id)
);

CREATE TABLE transactions
(
	transaction_id int identity(1,1) NOT NULL,
	customer_id int NOT NULL, 
	artwork_id int NOT NULL,
	purchase_date datetime NOT NULL,
	price money NOT NULL,

	constraint pk_transaction_id primary key (transaction_id),
	constraint  fk_transaction_artwork foreign key (artwork_id) references artwork(artwork_id),
	constraint fk_transaction_customer foreign key (customer_id) references customers(customer_id),


);

COMMIT TRANSACTION;