create database diepvries;
use diepvries;

DROP TABLE IF EXISTS `houdbaarheid`;

CREATE TABLE `houdbaarheid` (
  `idhoudbaarheid` int(11) NOT NULL AUTO_INCREMENT,
  `product` int(11) NOT NULL,
  `lade` int(11) NOT NULL,
  `datumIn` date NOT NULL,
  `datumUit` date NOT NULL,
  PRIMARY KEY (`idhoudbaarheid`),
  UNIQUE KEY `idhoudbaarheid_UNIQUE` (`idhoudbaarheid`),
  KEY `prod_idx` (`product`),
  KEY `lades_idx` (`lade`),
  CONSTRAINT `lades` FOREIGN KEY (`lade`) REFERENCES `lade` (`idlade`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `prod` FOREIGN KEY (`product`) REFERENCES `producten` (`idproducten`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

LOCK TABLES `houdbaarheid` WRITE;
/*!40000 ALTER TABLE `houdbaarheid` DISABLE KEYS */;
INSERT INTO `houdbaarheid` VALUES (1,2,1,'2020-05-12','2020-05-30'),(2,5,1,'2020-05-12','2020-06-12'),(3,6,2,'2020-05-12','2020-06-21'),(4,1,3,'2020-05-12','2020-07-23'),(5,3,4,'2020-05-12','2020-06-14'),(6,4,5,'2020-05-12','2020-05-29');
/*!40000 ALTER TABLE `houdbaarheid` ENABLE KEYS */;
UNLOCK TABLES;

DROP TABLE IF EXISTS `lade`;

CREATE TABLE `lade` (
  `idlade` int(11) NOT NULL AUTO_INCREMENT,
  `ladenummer` int(11) NOT NULL,
  PRIMARY KEY (`idlade`),
  UNIQUE KEY `idlade_UNIQUE` (`idlade`),
  UNIQUE KEY `ladenummer_UNIQUE` (`ladenummer`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1 MAX_ROWS=6;

LOCK TABLES `lade` WRITE;
/*!40000 ALTER TABLE `lade` DISABLE KEYS */;
INSERT INTO `lade` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6);
/*!40000 ALTER TABLE `lade` ENABLE KEYS */;
UNLOCK TABLES;

DROP TABLE IF EXISTS `producten`;

CREATE TABLE `producten` (
  `idproducten` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) NOT NULL,
  PRIMARY KEY (`idproducten`),
  UNIQUE KEY `idproducten_UNIQUE` (`idproducten`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

LOCK TABLES `producten` WRITE;
ALTER TABLE `producten` DISABLE KEYS ;
INSERT INTO `producten` VALUES (1,'broccoli'),(2,'pizza'),(3,'ijs'),(4,'kabbeljauw'),(5,'ribbetjes'),(6,'pasta');
ALTER TABLE `producten` ENABLE KEYS ;
UNLOCK TABLES;

