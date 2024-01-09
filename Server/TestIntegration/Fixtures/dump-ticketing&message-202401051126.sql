-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: lab006.2isa.org    Database: ticketing&message
-- ------------------------------------------------------
-- Server version	5.5.5-10.5.21-MariaDB-0+deb11u1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Categories`
--

DROP TABLE IF EXISTS `Categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Categories` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Label` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Categories`
--

LOCK TABLES `Categories` WRITE;
/*!40000 ALTER TABLE `Categories` DISABLE KEYS */;
INSERT INTO `Categories` VALUES (15,'Audio'),(16,'Poste'),(18,'Périphérique d\'entré'),(19,'Périphérique de sortie');
/*!40000 ALTER TABLE `Categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `MaterielCategories`
--

DROP TABLE IF EXISTS `MaterielCategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `MaterielCategories` (
  `IdMateriel` int(11) NOT NULL,
  `IdCategories` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `MaterielCategories`
--

LOCK TABLES `MaterielCategories` WRITE;
/*!40000 ALTER TABLE `MaterielCategories` DISABLE KEYS */;
INSERT INTO `MaterielCategories` VALUES (1,1),(2,2),(4,5),(5,2),(6,1),(7,15),(15,15),(16,15),(17,15),(18,15),(19,16),(20,19),(21,18),(22,16),(23,15),(24,18),(25,18);
/*!40000 ALTER TABLE `MaterielCategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Role`
--

DROP TABLE IF EXISTS `Role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Role` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Label` varchar(20) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Role`
--

LOCK TABLES `Role` WRITE;
/*!40000 ALTER TABLE `Role` DISABLE KEYS */;
INSERT INTO `Role` VALUES (4,'Admin'),(5,'Utilisateur'),(6,'Credo');
/*!40000 ALTER TABLE `Role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Materiel`
--

DROP TABLE IF EXISTS `Materiel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Materiel` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(25) NOT NULL,
  `Proprietaire` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Materiel`
--

LOCK TABLES `Materiel` WRITE;
/*!40000 ALTER TABLE `Materiel` DISABLE KEYS */;
INSERT INTO `Materiel` VALUES (1,'Souris','Sicard'),(2,'écran','Sicard'),(4,'Toshiba','Sicard'),(6,'Imprimante','Sicard'),(18,'Philips','Sicard'),(19,'Toshiba','Sicard'),(20,'Imprimante Sharp','Sicard'),(21,'Scanner','Sicard'),(22,'Acer','Sicard'),(24,'Souris','Sicard'),(25,'Clavier','Sicard');
/*!40000 ALTER TABLE `Materiel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UserRole`
--

DROP TABLE IF EXISTS `UserRole`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `UserRole` (
  `IdUser` bigint(20) unsigned NOT NULL,
  `IdRole` int(11) NOT NULL,
  KEY `FK_UserRole_User_Id` (`IdUser`),
  KEY `FK_UserRole_Role_Id` (`IdRole`),
  CONSTRAINT `FK_UserRole_Role_Id` FOREIGN KEY (`IdRole`) REFERENCES `Role` (`Id`),
  CONSTRAINT `FK_UserRole_User_Id` FOREIGN KEY (`IdUser`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UserRole`
--

LOCK TABLES `UserRole` WRITE;
/*!40000 ALTER TABLE `UserRole` DISABLE KEYS */;
INSERT INTO `UserRole` VALUES (5,4),(34,6),(48,5);
/*!40000 ALTER TABLE `UserRole` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `two_factor_secret` text DEFAULT NULL,
  `two_factor_recovery_codes` text DEFAULT NULL,
  `remember_token` varchar(100) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `tel` varchar(10) DEFAULT NULL,
  `firstname` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `users_email_unique` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (5,'Sicard','sicard.joseph@gmail.com','2023-05-31 06:58:04','$2y$10$0ttoUMarJf7GdOOwxliZWuZIThS9.PQpr9ICbUO4mPc/Di7OXcJSe',NULL,NULL,'WUo7qAlvQ1x1z05eHd62MUC0OT3pwFf1W3rKnyNy6uUk6z6krA67ngaMgJez','2023-05-31 06:57:15','2023-10-05 09:50:51','0631700031','Joseph'),(34,'Blanchart','blanchart@yopmail.com','2023-06-09 06:51:09','$2y$10$JL9zu.LViXJxt71igGeBkuWCk83Ozr9jsmQWgDR1BH1RxKeTHuBeq',NULL,NULL,'xLYF8rvX77zRzYNGr1KatmRc8fyRXjIyyMadFML88bTP4PsHApvLvzklrvym','2023-06-06 05:52:37','2023-06-16 04:44:01','0683913900','Georges'),(48,'Gosief','gosief@hotmail.com','2023-06-14 05:46:55','$2y$10$4jG1Ymfw02ajnZiIAQEW3uqq.vSLdLm83.YdJyIcBJzE2sPsQcJWS',NULL,NULL,'ABgpTry5gR5kuzAbbyeWQtyKQlv4k5IWNClAWkLp2kaKdPuE4QLlgGOPDpcC','2023-06-14 05:46:28','2023-12-19 12:11:54','0683913900','Joseph'),(53,'test','test@yopmail.com','2023-06-28 06:55:03','$2y$10$KmzMvzbS.Ghp1eoq8ceTSeln2cvFksEKqj32l9PO/ceMcnw1rgmLu',NULL,NULL,NULL,'2023-06-28 06:54:20','2023-06-28 06:55:03','0565493929','TEST');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-05 11:27:07
