-- 05/12/2023

CREATE VIEW ViewEntidade AS
SELECT
    ID,
    Nome,
	RazaoSocial,
	Tipo,
    CPFCNPJ,
    RGIE,
    Fone1,
    Fone2,
	CEP,
	Municipio
FROM    
    Entidade;

-- 09/12/2023

CREATE VIEW ViewProdutos AS
SELECT
    ID,
    Descricao,
	NCM,
	CodigoBarra,
	Valor,
	Estoque,
    ValorEstoque
FROM
    Produto

    CREATE VIEW ViewPedido AS
SELECT
    A.ID,
    C.Nome as Cliente,
    P.Nome as Profissional,
    S.Descricao as FormaPagamento,
    A.Total,
	A.DataEmissao
FROM
    Vendas A
    LEFT JOIN Entidade C ON C.ID = A.ClienteID
    LEFT JOIN Entidade P ON P.ID = A.UsuarioID
    LEFT JOIN FormasPagamento S ON S.ID = A.FormaPagamentoID;