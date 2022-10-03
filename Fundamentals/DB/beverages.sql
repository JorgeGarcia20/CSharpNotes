CREATE DATABASE beverages_db;

USE beverages_db;

CREATE TABLE beers(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	beer_name VARCHAR(50),
	brand VARCHAR(50),
	alcohol_percentage NUMERIC(10, 2),
	price NUMERIC(10,2),
	quantity INT
);

INSERT INTO beers 
VALUES
('Modelo Negra', 'Modelo', 4.5, 24.90, 20),
('Victoria', 'Victoria', 4.2, 20.90, 50),
('Corona', 'Corona', 4.2, 19.90, 50),
('Carta Blanca', 'Carta Blanca', 4.0, 15.80, 50),
('Guiness', 'Guiness', 5.0, 42.90, 20),
('Modelo Ambar', 'Modelo', 4.3, 23.80, 40),
('Modelo Especial', 'Modelo', 4.3, 21.00, 100);

SELECT * FROM beers;

-- Selecting the name, price and quantity from all the beers where the brand is 'Modelo' 
SELECT beer_name, price, quantity 
FROM beers 
WHERE brand = 'Modelo' 
ORDER BY beer_name;