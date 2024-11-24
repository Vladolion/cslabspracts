USE library;
CREATE TABLE books (
    id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(50)
);


ALTER TABLE books ADD COLUMN year INT;

INSERT INTO books (title, year) VALUES 
('Out of Position', 2009),
('Isolation Play', 2011),
('Divions', 2013),
('Uncovered', 2014),
('Over Time', 2016);

SELECT * FROM books;

CREATE PROCEDURE get_even_year_books()
SELECT * FROM books WHERE year % 2 = 0;

CALL get_even_year_books();