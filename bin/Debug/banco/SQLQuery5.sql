create table tb_colaboradores(
	 ID int identity(1,1) not null primary key, 
	 NOME varchar(80) not null, 
	 CPF varchar(14) not null,
	 CARGO varchar(80) not null, 
	 DATA_NASC varchar(10) not null, 
	 USUARIO varchar(50) not null, 
	 SENHA varchar(50) not null, 
	 EMAIL varchar(80) not null,
	 ENDERECO varchar(120) not null,
	 STATUS varchar(20) not null
	 );

	 select*from tb_colaboradores;


