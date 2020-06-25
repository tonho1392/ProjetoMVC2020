CREATE DATABASE PROJETOMVCA03;
USE PROJETOMVCA03;

CREATE TABLE tbl_clientea03(
id_cliente int(11) auto_increment not null,
nome_cliente varchar(45) not null,
sobrenome_cliente varchar(45) not null,
email_cliente varchar(50) not null,
senha_cliente varchar(45) not null,
cpf_cliente varchar(11) not null,
nome_mae varchar(50) not null,
tp_usuario int(1) default null,
primary key(id_cliente)

);

select * from tbl_clientea03;




