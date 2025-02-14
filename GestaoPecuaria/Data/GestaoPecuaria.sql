create database GestaoPecuaria;

use GestaoPecuaria;



create table Animais (
	id_animal int primary key auto_increment,
    nome_numeracao varchar(50) not null unique,
    raca varchar(50) not null,
    sexo char(1) not null,
    dataNascimento date,
    peso varchar(1000),
    ultimaVacinacao date,
    observacao text
);