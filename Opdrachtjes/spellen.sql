create database spellen;
use spellen;

DROP TABLE IF EXISTS `persoon`;

CREATE TABLE `persoon` (
  `idpersoon` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) NOT NULL,
  `voornaam` varchar(45) NOT NULL,
  `telefoonnummer` varchar(11) NOT NULL,
  PRIMARY KEY (`idpersoon`),
  UNIQUE KEY `idpersoon_UNIQUE` (`idpersoon`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

LOCK TABLES `persoon` WRITE;
ALTER TABLE `persoon` DISABLE KEYS ;
INSERT INTO `persoon` VALUES (1,'hindryckx','siebe','32497317895'),(2,'paudel','rubin','32497456879'),(3,'decuiper','dario','32485412389');
ALTER TABLE `persoon` ENABLE KEYS ;
UNLOCK TABLES;

DROP TABLE IF EXISTS `spellen`;

CREATE TABLE `spellen` (
  `idspellen` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) NOT NULL,
  `maker` varchar(45) NOT NULL,
  `type` varchar(45) NOT NULL,
  `korte inhoud` varchar(200) DEFAULT NULL,
  `aankoopdatum` date NOT NULL,
  PRIMARY KEY (`idspellen`),
  UNIQUE KEY `idspellen_UNIQUE` (`idspellen`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

LOCK TABLES `spellen` WRITE;
ALTER TABLE `spellen` DISABLE KEYS ;
INSERT INTO `spellen` VALUES (1,'call of duty','activision','first person shooter','schieten op andere mensen','2019-07-21'),(2,'fortnite','epic games','battle royale','overleven tot je de laatste bent','2019-03-10'),(3,'Gears of war','	Microsoft Game Studios','third persin shooter','buitenaardse wezens vermoorden','2016-04-17');
ALTER TABLE `spellen` ENABLE KEYS ;
UNLOCK TABLES;

DROP TABLE IF EXISTS `uitlenen`;

CREATE TABLE `uitlenen` (
  `iduitlenen` int(11) NOT NULL AUTO_INCREMENT,
  `spel` int(11) NOT NULL,
  `persoon` int(11) NOT NULL,
  `datum` date NOT NULL,
  PRIMARY KEY (`iduitlenen`),
  UNIQUE KEY `iduitlenen_UNIQUE` (`iduitlenen`),
  KEY `persoon_idx` (`persoon`),
  KEY `spel_idx` (`spel`),
  KEY `persoon_spel` (`spel`,`persoon`),
  CONSTRAINT `spel` FOREIGN KEY (`spel`) REFERENCES `spellen` (`idspellen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `persoon` FOREIGN KEY (`persoon`) REFERENCES `persoon` (`idpersoon`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

LOCK TABLES `uitlenen` WRITE;
ALTER TABLE `uitlenen` DISABLE KEYS ;
INSERT INTO `uitlenen` VALUES (1,3,2,'2020-02-02'),(2,1,3,'2020-04-12'),(3,2,1,'2020-05-11'),(4,3,2,'2020-03-02');
 ALTER TABLE `uitlenen` ENABLE KEYS ;
UNLOCK TABLES;
