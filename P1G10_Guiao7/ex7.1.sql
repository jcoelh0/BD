use pubs;

-- a)
go
CREATE VIEW title_author AS
SELECT titles.title, authors.au_fname, authors.au_lname
FROM titles JOIN titleauthor ON titles.title_id=titleauthor.title_id JOIN authors ON titleauthor.au_id=authors.au_id;

-- b)
go
CREATE VIEW publisher_employee AS
SELECT pub_name, fname, lname
FROM employee JOIN publishers ON employee.pub_id=publishers.pub_id;

-- c)
go
CREATE VIEW stores_titles AS
SELECT stor_name, title
FROM stores JOIN sales ON stores.stor_id=sales.stor_id JOIN titles ON sales.title_id=titles.title_id;

-- d)
go
CREATE VIEW business_titles AS
SELECT title_id, title, type, pub_id, price, notes
FROM titles
WHERE titles.[type]='Business'
WITH CHECK OPTION;
go