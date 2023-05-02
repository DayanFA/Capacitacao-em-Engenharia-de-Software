-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 02/05/2023 às 09:14
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
  `cand_matri` varchar(7) NOT NULL DEFAULT '0',
  `cand_nome` varchar(60) NOT NULL DEFAULT '',
  `cand_nascimento` date NOT NULL,
  `cand_endereco` text NOT NULL,
  `cand_fone` varchar(30) DEFAULT NULL,
  `cand_doc_identificacao` varchar(20) NOT NULL DEFAULT '',
  `cand_grau` int(1) DEFAULT NULL,
  `cand_usu_id` int(3) DEFAULT NULL,
  `cand_dt_inscricao` datetime DEFAULT NULL,
  `cand_dt_sistema` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `candidatos`
--

INSERT INTO `candidatos` (`cand_id`, `cand_matri`, `cand_nome`, `cand_nascimento`, `cand_endereco`, `cand_fone`, `cand_doc_identificacao`, `cand_grau`, `cand_usu_id`, `cand_dt_inscricao`, `cand_dt_sistema`) VALUES
(45, '123456', 'Teste da Silva', '2005-05-05', 'dsadasdasd R43', '+55 115856', '123.459', 4, 0, '2023-05-02 02:14:20', '2023-05-02 02:14:20');

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
  MODIFY `cand_id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `usu_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
