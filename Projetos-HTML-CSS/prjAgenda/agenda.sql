-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 14-Abr-2022 às 02:35
-- Versão do servidor: 5.6.25-log
-- versão do PHP: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `agenda`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `compromissos`
--

CREATE TABLE `compromissos` (
  `id_compromisso` int(11) NOT NULL,
  `nome` varchar(70) NOT NULL,
  `descricao` varchar(150) NOT NULL,
  `data_compromisso` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `compromissos`
--

INSERT INTO `compromissos` (`id_compromisso`, `nome`, `descricao`, `data_compromisso`) VALUES
(2, 'Festa do Flavinho do Pneu', 'festa do flavinho no domingo, no fim de semana', '2022-04-17 20:00:00'),
(3, 'Shaolin', 'Encontrar o Shaolin Matador de Porco', '2022-04-28 14:30:00'),
(4, 'viniciao', 'festa do maximos', '2022-04-28 21:30:00'),
(5, 'aaaaaaaaaaaaaaa', 'bbbbbbbbbbbbbbbb', '2022-04-25 23:30:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `login_usuario` varchar(65) NOT NULL,
  `senha_usuario` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `login_usuario`, `senha_usuario`) VALUES
(1, 'admin@admin', '1234');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `compromissos`
--
ALTER TABLE `compromissos`
  ADD PRIMARY KEY (`id_compromisso`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `compromissos`
--
ALTER TABLE `compromissos`
  MODIFY `id_compromisso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
