-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: dbclubs
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20210902124742_mysqltest.models.init','5.0.9'),('20210902124903_mysqltest.models.init1','5.0.9'),('20210902125549_mysqltest.models.initStudents','5.0.9'),('20210902130206_mysqltest.models.initStudentClubs','5.0.9');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clubs`
--

DROP TABLE IF EXISTS `clubs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clubs` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Type` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CreatedDate` datetime(6) NOT NULL,
  `UpdatedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clubs`
--

LOCK TABLES `clubs` WRITE;
/*!40000 ALTER TABLE `clubs` DISABLE KEYS */;
INSERT INTO `clubs` VALUES (1,'International','Other','2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(2,'Math','Academic','2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(3,'Diving','Sport','2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(4,'Strollers','Leisure','2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000');
/*!40000 ALTER TABLE `clubs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentclubs`
--

DROP TABLE IF EXISTS `studentclubs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentclubs` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ClubId` int NOT NULL,
  `StudentId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_StudentClubs_ClubId` (`ClubId`),
  KEY `IX_StudentClubs_StudentId` (`StudentId`),
  CONSTRAINT `FK_StudentClubs_Clubs_ClubId` FOREIGN KEY (`ClubId`) REFERENCES `clubs` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_StudentClubs_Students_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `students` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentclubs`
--

LOCK TABLES `studentclubs` WRITE;
/*!40000 ALTER TABLE `studentclubs` DISABLE KEYS */;
INSERT INTO `studentclubs` VALUES (1,1,1),(2,2,1),(3,3,2),(4,4,3),(5,3,4),(6,2,5),(7,1,6),(8,2,7),(9,3,8),(10,4,3),(11,2,5),(12,2,6),(13,1,7);
/*!40000 ALTER TABLE `studentclubs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `BirthDate` datetime(6) NOT NULL,
  `Password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CreatedDate` datetime(6) NOT NULL,
  `UpdatedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'Ali','Tayari','1999-08-01 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(2,'Dmitry','Apraksin','1963-08-09 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(3,'Ivan','Ivanou','2004-08-12 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(4,'Petr','Petrov','2000-01-01 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(5,'Sidor','Sidorov','1989-02-03 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(6,'Pambos','Boss','2000-05-10 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(7,'Christos','Christou','1998-04-05 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000'),(8,'Savvas','Savvou','1999-12-21 00:00:00.000000',NULL,'2021-09-02 16:02:06.000000','2021-09-02 16:02:06.000000');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-02 17:06:12
