-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 08 juin 2022 à 16:34
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projet2`
--

-- --------------------------------------------------------

--
-- Structure de la table `ajoute`
--

DROP TABLE IF EXISTS `ajoute`;
CREATE TABLE IF NOT EXISTS `ajoute` (
  `ID_USER` int(32) NOT NULL,
  `ID_PRODUIT` int(32) NOT NULL,
  PRIMARY KEY (`ID_USER`,`ID_PRODUIT`),
  KEY `I_FK_AJOUTE_USER` (`ID_USER`),
  KEY `I_FK_AJOUTE_PRODUIT` (`ID_PRODUIT`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `ID_CATEGORIE` int(32) NOT NULL,
  `LIBELLE` varchar(32) NOT NULL,
  PRIMARY KEY (`ID_CATEGORIE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`ID_CATEGORIE`, `LIBELLE`) VALUES
(1, 'Conserves'),
(2, 'Apéritifs'),
(3, 'Produits Ménagers'),
(4, 'Biscuits');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `ID_PRODUIT` int(32) NOT NULL AUTO_INCREMENT,
  `ID_CATEGORIE` int(32) NOT NULL,
  `LIBELLE` varchar(32) NOT NULL,
  `QUANTITÉ` int(100) NOT NULL,
  PRIMARY KEY (`ID_PRODUIT`),
  KEY `I_FK_PRODUIT_CATEGORIE` (`ID_CATEGORIE`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`ID_PRODUIT`, `ID_CATEGORIE`, `LIBELLE`, `QUANTITÉ`) VALUES
(3, 3, 'Savon', 54),
(4, 4, 'Prince', 212);

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `ID_ROLE` int(32) NOT NULL,
  `LIBELLE` varchar(32) NOT NULL,
  PRIMARY KEY (`ID_ROLE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `role`
--

INSERT INTO `role` (`ID_ROLE`, `LIBELLE`) VALUES
(1, 'admin'),
(2, 'client');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `ID_USER` int(32) NOT NULL AUTO_INCREMENT,
  `ID_ROLE` int(32) NOT NULL,
  `IDENTIFIANT` varchar(32) NOT NULL,
  `MOTDEPASSE` varchar(255) NOT NULL,
  PRIMARY KEY (`ID_USER`),
  KEY `I_FK_USER_ROLE` (`ID_ROLE`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`ID_USER`, `ID_ROLE`, `IDENTIFIANT`, `MOTDEPASSE`) VALUES
(3, 2, 'anton', '$2a$11$S2TrVgsz3EcPyO2wvNOY3OaS2y95OZvfYWINoLjCeAv6vmlh1.H.2'),
(2, 1, 'mehdi', '$2a$11$LL8.TJOcjELev3.umo1/aeDMt/CCpkEasgmPEQ2R.VMjjb1.Tbl2C');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
