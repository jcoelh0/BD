--a)
select nome from fornecedor except select nome from fornecedor join encomenda on nif=fornecedor;

--b)
select nome, codProd, avg(item.unidades) as media from produto join item on codigo=codProd group by nome, codProd;

--c)
select numero, avg(produto.unidades) as media from encomenda join item on numEnc=numero join produto on codProd=codigo group by numero

--d)
select fornecedor.nome, produto.nome, produto.unidades from encomenda join fornecedor on nif=fornecedor join item on numEnc=numero join produto on codigo=codProd