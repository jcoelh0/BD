use pubs;
--1)
--a)
SELECT * FROM authors;

--b)
SELECT au_fname, au_lname, phone 
FROM authors;

--c)
SELECT au_fname, au_lname, phone 
FROM authors
ORDER BY au_fname, au_lname;

--d)
SELECT au_fname as first_name, au_lname as last_name, phone as telephone
FROM authors
ORDER BY first_name, last_name;

--e)
SELECT au_fname as first_name, au_lname as last_name, phone as telephone
FROM authors
WHERE state='CA' AND au_lname='Ringer' 
ORDER BY first_name, last_name;

--f)
SELECT *
FROM publishers
WHERE pub_name like '%Bo%';

--g)
SELECT pub_name
FROM publishers JOIN titles ON publishers.pub_id=titles.pub_id
WHERE titles.[type]='Business';

--h) Número total de vendas de cada editora;
SELECT pub_name, SUM(titles.ytd_sales) as pub_sales
FROM titles JOIN publishers on titles.pub_id=publishers.pub_id
GROUP BY pub_name;

--i) Número total de vendas de cada editora agrupado por título;
SELECT publishers.pub_id, pub_name, title, SUM(qty) as total_sales
FROM publishers JOIN titles on publishers.pub_id=titles.pub_id 
				JOIN sales on titles.title_id=sales.title_id
GROUP BY publishers.pub_id, publishers.pub_name, title;

--j) Nome dos títulos vendidos pela loja ‘Bookbeat’;
SELECT title
FROM titles JOIN sales on titles.title_id=sales.title_id 
			JOIN stores on sales.stor_id=stores.stor_id
WHERE stores.stor_name='Bookbeat';

--k) Nome de autores que tenham publicações de tipos diferentes;
SELECT	au_fname, au_lname
FROM authors JOIN titleauthor on authors.au_id=titleauthor.au_id
			 JOIN titles on titles.title_id=titleauthor.title_id
GROUP BY au_fname, au_lname
HAVING count([type])>1;

--l) Para os títulos, obter o preço médio e o número total de vendas agrupado por tipo (type) e editora (pub_id);
SELECT titles.[type], titles.pub_id, AVG(price) as average_price, SUM(sales.qty) as total_sales
FROM titles JOIN publishers on titles.pub_id=publishers.pub_id
			JOIN sales on titles.title_id=sales.title_id
GROUP BY titles.[type], titles.pub_id;

--m) Obter o(s) tipo(s) de título(s) para o(s) qual(is) o máximo de dinheiro “à cabeça”
--   (advance) é uma vez e meia superior à média do grupo (tipo);
SELECT titles.title, titles.advance, average_advance
FROM titles JOIN (SELECT titles.[type], AVG(advance) as average_advance
					FROM titles
					GROUP BY [type]) as AV
					ON titles.[type]=av.[type]
WHERE titles.advance > AV.average_advance * 1.5;

--n) Obter, para cada título, nome dos autores e valor arrecadado por estes com a sua venda;
SELECT title, au_fname, au_lname, 
							titles.ytd_sales * titles.royalty / 100 * titleauthor.royaltyper / 100 as earnings --valor arrecadado
FROM titles JOIN titleauthor on titles.title_id=titleauthor.title_id
			JOIN authors on titleauthor.au_id=authors.au_id
			JOIN sales on titles.title_id=sales.title_id
GROUP BY title, au_fname, au_lname, titles.ytd_sales, titles.royalty, titleauthor.royaltyper;

--o) Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, a faturação total, 
--   o valor da faturação relativa aos autores e o valor da faturação relativa à editora;
SELECT title, ytd_sales, price*ytd_sales as faturacao, royalty*0.01*price*ytd_sales as authors_money, 
											price*ytd_sales-royalty*0.01*price*ytd_sales as publisher_money
FROM titles;

--p) Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, o nome de cada autor, 
--   o valor da faturação de cada autor e o valor da faturação relativa à editora;
SELECT title, ytd_sales, au_fname, au_lname, price*ytd_sales as facturacao, royalty*0.01*price*ytd_sales*royaltyper*0.1 
											as authors_money, price*ytd_sales-royalty*0.01*price*ytd_sales as publisher_money
FROM titles JOIN titleauthor as TA ON titles.title_id=TA.title_id
			JOIN authors ON TA.au_id=authors.au_id;

--q) Lista de lojas que venderam pelo menos um exemplar de todos os livros;
SELECT S.stor_name, S.stor_id, COUNT(T.title_id) as number_titles
FROM stores as S JOIN sales as TA ON S.stor_id=TA.stor_id
				 JOIN titles as T ON T.title_id=TA.title_id
GROUP BY S.stor_name, S.stor_id
HAVING COUNT(T.title_id)=(SELECT count(*) FROM titles);

--r) Lista de lojas que venderam mais livros do que a média de todas as lojas.
SELECT S.stor_name, S.stor_id, sum(qty) as total_sales
FROM stores as S JOIN sales as TA ON S.stor_id=TA.stor_id
GROUP BY S.stor_name, S.stor_id
HAVING sum(qty)> (SELECT avg(Qty_Sales) as avg_store_sales
				  FROM(SELECT stor_name, sum(qty) as Qty_Sales
					   FROM stores AS STO JOIN sales AS SAL ON STO.stor_id=SAL.stor_id
					   GROUP BY stor_name) as S);;

--s) Nome dos títulos que nunca foram vendidos na loja “Bookbeat”;
SELECT T.title
FROM titles as T
WHERE T.title_id not in (SELECT T.title_id
					   FROM titles as T JOIN sales as S ON T.title_id=S.title_id
										JOIN stores as ST ON S.stor_id=ST.stor_id
					   WHERE ST.stor_name='Bookbeat');

--t) Para cada editora, a lista de todas as lojas que nunca venderam títulos dessa editora;
SELECT P.pub_name, S.stor_name
FROM publishers as P, stores as S
EXCEPT --as lojas que já venderam titulos dessa editora
SELECT P.pub_name, S.stor_name
FROM stores AS S LEFT OUTER JOIN sales AS Sa ON S.stor_id=Sa.stor_id
			JOIN titles ON Sa.title_id=titles.title_id 
			RIGHT OUTER JOIN publishers as P ON titles.pub_id=P.pub_id
GROUP BY P.pub_name, S.stor_name;