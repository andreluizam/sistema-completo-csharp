-- 04/12/2023 CREATE


IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Entidade' AND TYPE = 'U')
CREATE TABLE Entidade (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	Usuario varchar (8),
	Senha varchar (8),
	GrupoID int,
	Tipo int,
	Ativo bit,
	Bloqueado bit,
	Nome varchar (60),
	RazaoSocial varchar (60),
	CPFCNPJ varchar (18),
	RGIE varchar (16),
	Fone1 varchar (15),
	Fone2 varchar (15),
	Pais int,
	CEP varchar (8),
	Municipio varchar (200),
	Endereco varchar (50),
	Numero varchar (8),
	Bairro varchar (40),
	Complemento varchar (35),
	DataNascimento datetime,
	Email varchar (40),
	DataCadastro datetime,
	Observacao text,
);

GO
INSERT INTO Entidade (Senha,Usuario, Tipo, Ativo, Bloqueado, Nome,GrupoID)
VALUES ('001002','ADMIN', 3, 1, 0, 'ADMIN',1);
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'GroupUser' AND TYPE = 'U')
CREATE TABLE GroupUser (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	Nome varchar(50)
);

GO

INSERT INTO GroupUser (Nome)
VALUES ('ADMINISTRADOR');

GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Permissoes' AND TYPE = 'U')
CREATE TABLE Permissoes (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	FormID int,
	GrupoID int,
	INSERIR bit,
	VISUALIZAR bit,
	ALTERAR bit,
	EXCLUIR bit
	FOREIGN KEY(GrupoID) REFERENCES GroupUser(ID),

);
GO

DECLARE @FormID INT = 1;
WHILE @FormID <= 10
BEGIN
    INSERT INTO Permissoes (FormID, GrupoID, INSERIR, VISUALIZAR, ALTERAR, EXCLUIR)
    VALUES (@FormID, 1, 1, 1, 1, 1);

    SET @FormID = @FormID + 1;
END;

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Produto' AND TYPE = 'U')
CREATE TABLE Produto (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	Descricao varchar (8),
	NCM varchar (8),
	CodigoBarra varchar(14),
	Estoque decimal(10,2),
	Valor decimal(10,2),
	ValorEstoque decimal(10,2)
);
GO

-- CREATE 13/12/2023

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'StatusSistema' AND TYPE = 'U')
CREATE TABLE StatusSistema (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	Descricao varchar(60),
	Situacao bit
);
GO

INSERT INTO StatusSistema (Descricao, Situacao)
VALUES ('Pago',1)

INSERT INTO StatusSistema (Descricao, Situacao)
VALUES ('Aberto',0)

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'FormasPagamento' AND TYPE = 'U')
CREATE TABLE FormasPagamento (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	StatusID int not null,
	Descricao varchar(60),
	PrazoDias int not null,
	IntervaloDias int not null,
	Parcelas int not null,
	FOREIGN KEY(StatusID) REFERENCES StatusSistema(ID)
);
GO

INSERT INTO FormasPagamento (StatusID,Descricao,PrazoDias,IntervaloDias,Parcelas)
VALUES (1,'DINHEIRO',0,0,0)

INSERT INTO FormasPagamento (StatusID,Descricao,PrazoDias,IntervaloDias,Parcelas)
VALUES (2,'A PRAZO 30 DIAS',30,30,1)

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Vendas' AND TYPE = 'U')
CREATE TABLE Vendas (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	ClienteID int,
	UsuarioID int,
	FormaPagamentoID int,
	DescontoReais decimal,
	DescontoPercentual decimal,
	DataEmissao datetime,
	Total decimal
	FOREIGN KEY(ClienteID) REFERENCES Entidade(ID),
	FOREIGN KEY(UsuarioID) REFERENCES Entidade(ID),
	FOREIGN KEY(FormaPagamentoID) REFERENCES FormasPagamento(ID),
);
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'ProdutosVendas' AND TYPE = 'U')
CREATE TABLE ProdutosVendas (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	ProdutoID int not null,
	VendaID int not null,
	Descricao varchar (80),
	CodigoBarra varchar(14),
	Quantidade decimal(10,2),
	Valor decimal(10,2),
	Subtotal decimal(10,2)
	FOREIGN KEY(ProdutoID) REFERENCES Produto(ID),
	FOREIGN KEY(VendaID) REFERENCES Vendas(ID),
);
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Caixas' AND TYPE = 'U')
CREATE TABLE Caixas (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	Descricao varchar (20),
	Saldo decimal(10,2),

);
GO

INSERT INTO Caixas (Descricao,Saldo)
VALUES ('MEU CAIXA', 0.00)

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'ContasReceber' AND TYPE = 'U')
CREATE TABLE ContasReceber (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	Cliente varchar(150),
	Referente varchar (150),
	Valor decimal(10,2),
	Recebida bit
);
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'ContasRecebidas' AND TYPE = 'U')
CREATE TABLE ContasRecebidas (
    ID int PRIMARY KEY IDENTITY NOT NULL,
	ContaID int not null,
	UsuarioID int not null,
	FormaPagamentoID int not null,
	Cliente varchar(150),
	Referente varchar (150),
	Valor decimal(10,2),
	FOREIGN KEY (ContaID) REFERENCES ContasReceber(ID),
	FOREIGN KEY(UsuarioID) REFERENCES Entidade(ID),
	FOREIGN KEY(FormaPagamentoID) REFERENCES FormasPagamento(ID)
);
GO