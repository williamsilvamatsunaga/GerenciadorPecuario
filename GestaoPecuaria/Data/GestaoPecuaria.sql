create database GestaoPecuaria;

use GestaoPecuaria;

CREATE TABLE Despesas (
	id_despesa INT PRIMARY KEY AUTO_INCREMENT,
    tipoDespesa VARCHAR(50) NOT NULL,
    valor DECIMAL(10,2) NOT NULL,
    dataDespesa DATE NOT NULL,
    categoria VARCHAR(50) NOT NULL
);

CREATE TABLE Fornecedores (
	id_fornecedor INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cpfCnpj VARCHAR(14) NOT NULL UNIQUE,
    endereco TEXT NOT NULL,
    contrato VARCHAR(50),
    racaAnimal VARCHAR(50) NOT NULL
);

CREATE TABLE DespesasFornecedores (
    id_despesaFornecedor INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_despesa INT NOT NULL,
    fk_id_fornecedor INT NOT NULL,
    descricao VARCHAR(100),
    FOREIGN KEY (fk_id_despesa) REFERENCES Despesas(id_despesa) ON DELETE CASCADE,
    FOREIGN KEY (fk_id_fornecedor) REFERENCES Fornecedores(id_fornecedor) ON DELETE CASCADE
);

CREATE TABLE Lotes (
	id_lote INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL, 
    tipo VARCHAR(50) NOT NULL,
    dataCriacao DATE NOT NULL
);

CREATE TABLE Rebanhos (
	id_rebanho INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50),
    tipo VARCHAR(50) NOT NULL
);

CREATE TABLE LotesRebanhos (
    id_loteRebanho INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_lote INT NOT NULL,
    fk_id_rebanho INT NOT NULL,
    FOREIGN KEY (fk_id_lote) REFERENCES Lotes(id_lote) ON DELETE CASCADE,
    FOREIGN KEY (fk_id_rebanho) REFERENCES Rebanhos(id_rebanho) ON DELETE CASCADE
);

CREATE TABLE Vendas (
	id_venda INT PRIMARY KEY AUTO_INCREMENT,
    nomeNumeracaoAnimal VARCHAR(50) NOT NULL,
    comprador VARCHAR(50) NOT NULL,
    valor DECIMAL(10,2) NOT NULL,
    dataVenda DATE NOT NULL
);

CREATE TABLE Animais (
	id_animal int primary key auto_increment,
    nomeNumeracao varchar(50) not null unique,
    raca varchar(50) not null,
    sexo char(1) not null,
    dataNascimento date,
    peso decimal(10,2),
    ultimaVacinacao date,
    observacao text,
    fk_id_venda INT,
    FOREIGN KEY (fk_id_venda) REFERENCES Vendas (id_venda)
);

select * from animais;

CREATE TABLE RebanhoAnimal (
    id_rebanhoAnimal INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_rebanho INT NOT NULL,
    fk_id_animal INT NOT NULL,
    dataEntrada DATE NOT NULL,
    dataSaida DATE NOT NULL,
    FOREIGN KEY (fk_id_rebanho) REFERENCES Rebanhos (id_rebanho) ON DELETE CASCADE,
    FOREIGN KEY (fk_id_animal) REFERENCES Animais (id_animal) ON DELETE CASCADE
);

CREATE TABLE Piquetes (
	id_piquete INT PRIMARY KEY AUTO_INCREMENT,
    nomeNumeracao VARCHAR(50) NOT NULL,
    localizacao VARCHAR(50) NOT NULL,
    tipoProducao VARCHAR(50) NOT NULL
);

CREATE TABLE PiquetesRebanhos (
    id_piqueteRebanho INT PRIMARY KEY AUTO_INCREMENT,
    fk_id_piquete INT NOT NULL,
    fk_id_rebanho INT NOT NULL,
    dataEntrada DATE NOT NULL,
    dataSaida DATE NULL,
    FOREIGN KEY (fk_id_piquete) REFERENCES Piquetes(id_piquete) ON DELETE CASCADE,
    FOREIGN KEY (fk_id_rebanho) REFERENCES Rebanhos(id_rebanho) ON DELETE CASCADE
);

