-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 04/09/2021 às 20:35
-- Versão do servidor: 10.4.19-MariaDB
-- Versão do PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cardapio`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `nomeCliente` varchar(100) NOT NULL,
  `cpfCliente` varchar(14) NOT NULL,
  `emailCliente` varchar(150) NOT NULL,
  `ativoCliente` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `itemcardapio`
--

CREATE TABLE `itemcardapio` (
  `idItem` int(11) NOT NULL,
  `nomeItem` varchar(50) NOT NULL,
  `descricaoItem` text CHARACTER SET utf8 NOT NULL,
  `valorItem` varchar(50) NOT NULL,
  `valorComDesconto` varchar(50) NOT NULL,
  `categoriaItem` varchar(150) CHARACTER SET utf8 NOT NULL,
  `restricaoItem` varchar(50) CHARACTER SET utf8 NOT NULL,
  `ativoItem` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `itemcardapio`
--

INSERT INTO `itemcardapio` (`idItem`, `nomeItem`, `descricaoItem`, `valorItem`, `valorComDesconto`, `categoriaItem`, `restricaoItem`, `ativoItem`) VALUES
(2, 'Teste', 'Testando.', '123,00', '100,00', 'Bebida', 'alsdjkf', 1),
(3, 'Coca Cola', 'Coca Cola geladinha', '5,00', '4,00', 'Bebidas', '', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Índices de tabela `itemcardapio`
--
ALTER TABLE `itemcardapio`
  ADD PRIMARY KEY (`idItem`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `itemcardapio`
--
ALTER TABLE `itemcardapio`
  MODIFY `idItem` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
