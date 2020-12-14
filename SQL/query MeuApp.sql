USE [dbPICC_20202]
GO

CREATE TABLE MeuAppVictor.LoginSistema
(
	IdUsuario int primary key identity not null,
	Usuario varchar(200) not null,
	Senha varchar(200) not null,
)
--------------------------------------
CREATE TABLE MeuAppVictor.Cadastro(
	IdCadastro INT NOT NULL,
	Nome VARCHAR(100),
	Cidade VARCHAR(50),
	NumeroCasa VARCHAR(5),
	UF CHAR(2),
)


ALTER TABLE MeuAppVictor.Cadastro
ADD CONSTRAINT PKCadastro PRIMARY KEY (IdCadastro)


--------------------------------------
CREATE TABLE MeuAppVictor.Cliente(
	IdCliente INT NOT NULL,
	NomeCliente VARCHAR(100),
	CPF CHAR(11),
	Endereco CHAR(30),
	DataNascimento DATE,
) 

ALTER TABLE MeuAppVictor.Cliente
ADD CONSTRAINT PKCliente PRIMARY KEY (IdCliente)
-----------------------------------------

CREATE TABLE MeuAppVictor.PrestadorServico(
		IdTrabalhador INT NOT NULL,
		NomeTrabalhador VARCHAR(100),
		DataNascimento DATE,
		CPF CHAR(11),
		Endereco CHAR(30),
)

ALTER TABLE MeuAppVictor.PrestadorServico
ADD CONSTRAINT PKPrestadorServico PRIMARY KEY (IdTrabalhador)
--------------------------------------

CREATE TABLE MeuAppVictor.VisualizarTrabahos(
		IdVisualizacao INT NOT NULL,
		NomeTrabalhador VARCHAR(100),
		DescricaoTrabalho VARCHAR(100),
		Cidade VARCHAR(50),
		Valor REAL,
)


ALTER TABLE MeuAppVictor.VisualizarTrabahos
ADD CONSTRAINT PKVisualizarTrabahos PRIMARY KEY (IdVisualizacao)
-------------------------------------------
CREATE TABLE MeuAppVictor.Servico(
		IdServico INT NOT NULL,
		IdTrabalhador INT,
		IdCliente INT,
		Endereco CHAR(30),
		DataServico DATE,
		Valor REAL,
)



ALTER TABLE MeuAppVictor.Servico
ADD CONSTRAINT PKServico PRIMARY KEY (IdServico)
---------------------------------------
CREATE TABLE MeuAppVictor.AvaliarServico(
		IdAvaliacao INT NOT NULL,
		Descricao VARCHAR(100),
		NomeCliente VARCHAR(100),
		NomeTrabalhador VARCHAR(100),
		IdServico INT,
)

ALTER TABLE MeuAppVictor.AvaliarServico
ADD CONSTRAINT PKAvaliarServico PRIMARY KEY (IdAvaliacao)
--------------------------------------------------

CREATE TABLE MeuAppVictor.Pagamento(
		IdPagamento INT NOT NULL,
		FormaPagamento VARCHAR(20),
		ContaPagante CHAR (20),
		ContaRecebedora CHAR(20),
		NomeCliente VARCHAR(100),
		NomeTrabalhador VARCHAR(100),
)

ALTER TABLE MeuAppVictor.Pagamento
ADD CONSTRAINT PKPagamento PRIMARY KEY (IdPagamento)