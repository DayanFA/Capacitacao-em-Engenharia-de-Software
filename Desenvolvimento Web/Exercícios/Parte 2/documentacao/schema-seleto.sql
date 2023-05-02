
# phpMyAdmin MySQL-Dump
# version 2.2.3
# http://phpwizard.net/phpMyAdmin/
# http://phpmyadmin.sourceforge.net/ (download page)
#
# Servidor: localhost
# Tempo de Generação: Jul 02, 2005 at 05:58 PM
# Versão do Servidor: 3.23.47
# Versão do PHP: 4.1.1
# Banco de Dados : `seleto`
# --------------------------------------------------------

#
# Estrutura da tabela `candidatos`
#

CREATE TABLE candidatos (
  cand_id int(4) NOT NULL auto_increment,
  cand_inscricao varchar(7) NOT NULL default '0',
  cand_nome varchar(60) NOT NULL default '',
  cand_nascimento date NOT NULL,
  cand_endereco text NOT NULL,
  cand_fone varchar(30) default NULL,
  cand_pai varchar(60) default NULL,
  cand_mae varchar(60) default NULL,
  cand_doc_identificacao varchar(20) NOT NULL default '',
  cand_tipo_doc_ident char(1) default NULL,
  cand_car_id int(3) NOT NULL default '0',
  cand_loc_id int(3) default '0',
  cand_unidade_lotacao int(3) NOT NULL default '0',
  cand_usu_id int(3) default NULL,
  cand_dt_inscricao datetime default NULL,
  cand_dt_sistema datetime default NULL,
  PRIMARY KEY  (cand_id),
  KEY id (cand_id)
);

#
# Extraindo dados da tabela `candidatos`
#

INSERT INTO candidatos VALUES (1, '01-0001', 'Luiz Augusto M Silva', '1958-08-20', 'R Henrique Dias, 107 - Bosque', '3224-2537', 'Nome Pai', 'mae', '00011', '2', 1, 2, 0, 1, '2005-06-21 00:00:00', '2005-07-02 00:00:00');
INSERT INTO candidatos VALUES (5, '08-0005', 'Juvenal Antunes', '1930-01-01', 'Gameleira, 123 - Quinze', '555-33333', 'Luisa', 'Luis', '99999', '5', 8, 0, 0, 2, '2005-06-21 00:00:00', '2005-07-02 00:00:00');
INSERT INTO candidatos VALUES (4, '02-0004', 'Maria', '1930-01-04', 'Conju', '44444444', 'Jose', 'Luisa', '66666', '3', 2, 0, 0, 2, '2005-06-21 00:00:00', '2005-07-02 00:00:00');
INSERT INTO candidatos VALUES (6, '11-0006', 'Mario', '1930-01-05', 'Conjnutiffdf', '55544', 'Estamos Testando', 'Teste 123', '55433322', '5', 11, 0, 0, 2, '2005-06-21 00:00:00', '2005-07-02 00:00:00');
INSERT INTO candidatos VALUES (7, '15-0007', 'Jota Silva', '1948-03-19', 'Rua Teste', '9999', 'aad', 'dfdf', '56467799', '3', 15, 0, 0, 1, '2005-06-21 00:00:00', '2005-07-02 00:00:00');
INSERT INTO candidatos VALUES (8, '14-0008', 'Luissssss', '1933-05-01', 'BAGDA', '434343', 'Vamos ver agora, 123', 'Apenas teste', '0976665', '7', 14, 0, 6, 2, '2005-06-24 00:00:00', '2005-07-02 00:00:00');

# --------------------------------------------------------

#
# Estrutura da tabela `cargos`
#

CREATE TABLE cargos (
  car_id int(2) NOT NULL auto_increment,
  car_descricao varchar(100) NOT NULL default '',
  car_escolaridade varchar(100) default NULL,
  car_nivel char(1) default NULL,
  car_vagas int(3) NOT NULL default '0',
  PRIMARY KEY  (car_id)
);

#
# Extraindo dados da tabela `cargos`
#

INSERT INTO cargos VALUES (1, 'Professor 2 (1ª a 4ª séries)', 'Licenciatura em Pedagogia', 'S', 17);
INSERT INTO cargos VALUES (2, 'Professor 2 (1 a 4ª series c/ habilitacao em Supervisao Escolar)', 'Licenciatura em Pedagogia com habilitacao em Supervisao Escolar', 'S', 6);
INSERT INTO cargos VALUES (3, 'Professor 2 - Ingles', 'Licenciatura Letras Ingles', 'S', 4);
INSERT INTO cargos VALUES (4, 'Professor 2 - Matematica', 'Licenciatura em Matematica', 'S', 2);
INSERT INTO cargos VALUES (5, 'Agente Administrativo', 'Ensino Medio', 'M', 58);
INSERT INTO cargos VALUES (6, 'Monitor', 'Formacao em 2° Magisterio', 'M', 9);
INSERT INTO cargos VALUES (7, 'Motorista', 'Ensino Fundamental (1° Grau) e Cart. de Habilitacao Categoria D', 'F', 14);
INSERT INTO cargos VALUES (8, 'Fiscal de Tributos', 'Ensino Medio (2° Grau)', 'M', 2);
INSERT INTO cargos VALUES (9, 'Servente', 'Conclusao da 2ª serie primaria', 'F', 43);
INSERT INTO cargos VALUES (10, 'Merendeira', 'Conclusao da 2ª Serie primaria', 'F', 6);

# --------------------------------------------------------

#
# Estrutura da tabela `locais`
#

CREATE TABLE locais (
  loc_id int(3) NOT NULL auto_increment,
  loc_descricao varchar(100) NOT NULL default '',
  loc_salas int(3) default NULL,
  loc_endereco text,
  PRIMARY KEY  (loc_id),
  KEY id (loc_id)
);

#
# Extraindo dados da tabela `locais`
#

INSERT INTO locais VALUES (1, 'UFAC - Campus Teste', 5, 'Rua Teste, 111 - CRUZEIRAO');
INSERT INTO locais VALUES (2, 'UFAC - Bloco Jersey Nazareno Nunes', 12, 'Campus Rio Branco');
# --------------------------------------------------------

#
# Estrutura da tabela `usuarios`
#

CREATE TABLE usuarios (
  usu_id int(3) NOT NULL auto_increment,
  usu_nome varchar(50) NOT NULL default '',
  usu_login varchar(8) NOT NULL default '',
  usu_codigo varchar(16) NOT NULL default '',
  usu_acesso datetime default NULL,
  usu_status char(1) default NULL,
  PRIMARY KEY  (usu_id),
  KEY id (usu_id)
);

#
# Extraindo dados da tabela `usuarios`
#

INSERT INTO usuarios VALUES (1, 'Administrador', 'admin', '43e9a4ab75570f5b', '2005-07-02 11:30:57', NULL);

    