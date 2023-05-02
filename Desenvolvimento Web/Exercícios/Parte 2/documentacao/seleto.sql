-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 02/05/2023 às 05:20
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `seleto`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `candidatos`
--

CREATE TABLE `candidatos` (
  `cand_id` int(4) NOT NULL,
  `cand_inscricao` varchar(7) NOT NULL DEFAULT '0',
  `cand_nome` varchar(60) NOT NULL DEFAULT '',
  `cand_nascimento` date NOT NULL,
  `cand_endereco` text NOT NULL,
  `cand_fone` varchar(30) DEFAULT NULL,
  `cand_pai` varchar(60) DEFAULT NULL,
  `cand_mae` varchar(60) DEFAULT NULL,
  `cand_doc_identificacao` varchar(20) NOT NULL DEFAULT '',
  `cand_tipo_doc_ident` char(1) DEFAULT NULL,
  `cand_car_id` int(3) NOT NULL DEFAULT 0,
  `cand_loc_id` int(3) DEFAULT 0,
  `cand_unidade_lotacao` int(3) NOT NULL DEFAULT 0,
  `cand_usu_id` int(3) DEFAULT NULL,
  `cand_dt_inscricao` datetime DEFAULT NULL,
  `cand_dt_sistema` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `candidatos`
--

INSERT INTO `candidatos` (`cand_id`, `cand_inscricao`, `cand_nome`, `cand_nascimento`, `cand_endereco`, `cand_fone`, `cand_pai`, `cand_mae`, `cand_doc_identificacao`, `cand_tipo_doc_ident`, `cand_car_id`, `cand_loc_id`, `cand_unidade_lotacao`, `cand_usu_id`, `cand_dt_inscricao`, `cand_dt_sistema`) VALUES
(1, '01-0001', 'Luiz Augusto M Silva', '1958-08-20', 'R Henrique Dias, 107 - Bosque', '3224-2537', 'Nome Pai', 'mae', '00011', '2', 1, 2, 0, 1, '2005-06-21 00:00:00', '2005-07-02 00:00:00'),
(4, '02-0004', 'Maria', '1930-01-04', 'Conju', '44444444', 'Jose', 'Luisa', '66666', '3', 2, 0, 0, 2, '2005-06-21 00:00:00', '2005-07-02 00:00:00'),
(5, '08-0005', 'Juvenal Antunes', '1930-01-01', 'Gameleira, 123 - Quinze', '555-33333', 'Luisa', 'Luis', '99999', '5', 8, 0, 0, 2, '2005-06-21 00:00:00', '2005-07-02 00:00:00'),
(6, '11-0006', 'Mario', '1930-01-05', 'Conjnutiffdf', '55544', 'Estamos Testando', 'Teste 123', '55433322', '5', 11, 0, 0, 2, '2005-06-21 00:00:00', '2005-07-02 00:00:00'),
(7, '15-0007', 'Jota Silva', '1948-03-19', 'Rua Teste', '9999', 'aad', 'dfdf', '56467799', '3', 15, 0, 0, 1, '2005-06-21 00:00:00', '2005-07-02 00:00:00'),
(8, '14-0008', 'Luissssss', '1933-05-01', 'BAGDA', '434343', 'Vamos ver agora, 123', 'Apenas teste', '0976665', '7', 14, 0, 6, 2, '2005-06-24 00:00:00', '2005-07-02 00:00:00'),
(9, 'r', 'r', '1930-01-01', 'r', 'rtr', 'r', 'r', 'rte', '2', 2, 0, 0, 1, '2023-05-18 00:00:00', '2023-05-01 00:00:00'),
(10, 'u', 'u', '1930-01-01', 'u', 'u', 'u', 'u', 'u', '2', 6, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(11, 'r', 'r', '1930-01-01', 'r', 'r', 'r', 'r', 'r', '3', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(12, 'r', 'r', '1930-01-01', 'r', 'r', 'r', 'r', 'r', '3', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(13, 'r', 'r', '1930-01-01', 'r', 'r', 'r', 'r', 'r', '2', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(14, 'sad', 'asd', '1938-01-01', 'dsa', 'sda', 'sda', 'dsa', '5878', '2', 4, 0, 0, 1, '2023-05-29 00:00:00', '2023-05-01 00:00:00'),
(15, 'sada', 'dsad', '1930-01-01', 'sdad', 'sdad', 'sda', 'sdad', 'sda', '2', 2, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(16, 'fsd', 'fds', '1930-01-01', 'fds', 'fds', 'fds', 'dfs', 'dfs', '2', 0, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(17, 'fsd', 'fds', '1930-01-01', 'fds', 'fds', 'fds', 'dfs', 'dfs', '2', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(18, 'dfs', 'dfs', '1930-01-01', 'dfs', 'fds', 'dfs', 'dfs', 'dsf', '2', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(19, 'dfgdfg', 'fgdgdfg', '1930-01-01', 'dfgdfgd', 'dfgdfg', 'fdgdgd', 'fdgfg', 'gfdgdf', '4', 2, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(20, 'sdasd', 'dsada', '1930-01-01', 'sad', 'sad', 'dsad', 'sdadas', 'dsa', '2', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(21, 'dasd', 'dsa', '1930-01-01', 'dsa', 'dsa', 'dsa', 'dsa', 'dsa', '2', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(22, 'r', 'asd', '1930-01-01', 'dsa', 'fds', 'fdsf', 'gbfc', 'bvc', '2', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(23, 'fdfsfs', 'dfsfdf', '1930-01-01', 'fdsfs', 'dfsdfs', 'fds', 'dfsf', 'dfs', '2', 2, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(24, 'ftdg', 'gfdg', '1930-01-01', 'fgdg', 'fgdg', 'gfd', 'dfgd', 'fdgd', '2', 1, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00'),
(25, 'YO', 'YO', '1930-01-01', 'YO', 'YO', 'YO', 'YO', 'YO', '2', 1, 0, 0, 1, '2023-05-19 00:00:00', '2023-05-01 00:00:00'),
(26, 'fxcvb', 'cvx', '1930-01-01', 'vcxv', 'cvx', 'cvx', 'vcx', 'cvx', '6', 2, 0, 0, 1, '2023-05-15 00:00:00', '2023-05-01 00:00:00');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cargos`
--

CREATE TABLE `cargos` (
  `car_id` int(2) NOT NULL,
  `car_descricao` varchar(100) NOT NULL DEFAULT '',
  `car_escolaridade` varchar(100) DEFAULT NULL,
  `car_nivel` char(1) DEFAULT NULL,
  `car_vagas` int(3) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cargos`
--

INSERT INTO `cargos` (`car_id`, `car_descricao`, `car_escolaridade`, `car_nivel`, `car_vagas`) VALUES
(1, 'Professor 2 (1? a 4? s?ries)', 'Licenciatura em Pedagogia', 'S', 17),
(2, 'Professor 2 (1 a 4? series c/ habilitacao em Supervisao Escolar)', 'Licenciatura em Pedagogia com habilitacao em Supervisao Escolar', 'S', 6),
(3, 'Professor 2 - Ingles', 'Licenciatura Letras Ingles', 'S', 4),
(4, 'Professor 2 - Matematica', 'Licenciatura em Matematica', 'S', 2),
(5, 'Agente Administrativo', 'Ensino Medio', 'M', 58),
(6, 'Monitor', 'Formacao em 2? Magisterio', 'M', 9),
(7, 'Motorista', 'Ensino Fundamental (1? Grau) e Cart. de Habilitacao Categoria D', 'F', 14),
(8, 'Fiscal de Tributos', 'Ensino Medio (2? Grau)', 'M', 2),
(9, 'Servente', 'Conclusao da 2? serie primaria', 'F', 43),
(10, 'Merendeira', 'Conclusao da 2? Serie primaria', 'F', 6);

-- --------------------------------------------------------

--
-- Estrutura para tabela `locais`
--

CREATE TABLE `locais` (
  `loc_id` int(3) NOT NULL,
  `loc_descricao` varchar(100) NOT NULL DEFAULT '',
  `loc_salas` int(3) DEFAULT NULL,
  `loc_endereco` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `locais`
--

INSERT INTO `locais` (`loc_id`, `loc_descricao`, `loc_salas`, `loc_endereco`) VALUES
(1, 'UFAC - Campus Teste', 5, 'Rua Teste, 111 - CRUZEIRAO'),
(2, 'UFAC - Bloco Jersey Nazareno Nunes', 12, 'Campus Rio Branco');

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `usu_id` int(3) NOT NULL,
  `usu_nome` varchar(50) NOT NULL DEFAULT '',
  `usu_login` varchar(8) NOT NULL DEFAULT '',
  `usu_codigo` varchar(255) DEFAULT NULL,
  `usu_acesso` datetime DEFAULT NULL,
  `usu_status` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`usu_id`, `usu_nome`, `usu_login`, `usu_codigo`, `usu_acesso`, `usu_status`) VALUES
(1, 'Administrador', 'admin', '*01A6717B58FF5C7EAFFF6CB7C96F7428EA65FE4C', '2005-07-02 11:30:57', NULL);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `candidatos`
--
ALTER TABLE `candidatos`
  ADD PRIMARY KEY (`cand_id`),
  ADD KEY `id` (`cand_id`);

--
-- Índices de tabela `cargos`
--
ALTER TABLE `cargos`
  ADD PRIMARY KEY (`car_id`);

--
-- Índices de tabela `locais`
--
ALTER TABLE `locais`
  ADD PRIMARY KEY (`loc_id`),
  ADD KEY `id` (`loc_id`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`usu_id`),
  ADD KEY `id` (`usu_id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `candidatos`
--
ALTER TABLE `candidatos`
  MODIFY `cand_id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de tabela `cargos`
--
ALTER TABLE `cargos`
  MODIFY `car_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `locais`
--
ALTER TABLE `locais`
  MODIFY `loc_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `usu_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
