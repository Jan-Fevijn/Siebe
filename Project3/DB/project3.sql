
create schema if not exists `project3`;
use project3;

DROP TABLE IF EXISTS `broodpositiedatum`;

CREATE TABLE `broodpositiedatum` (
  `idbroodpositieDatum` int(11) NOT NULL AUTO_INCREMENT,
  `idbrood` int(11) NOT NULL,
  `positie` int(11) NOT NULL,
  `Datum` date NOT NULL,
  `aantalIn` int(11) NOT NULL,
  `kostprijs` decimal(8,2) NOT NULL,
  PRIMARY KEY (`idbroodpositieDatum`)
);

INSERT INTO `broodpositiedatum` VALUES (1,1,1,'2020-04-15',5,2.20),(2,2,2,'2020-04-20',8,1.30),(3,4,3,'2020-04-19',8,1.30),(4,3,4,'2020-04-10',2,2.00),(5,5,5,'2020-04-05',3,1.50),(6,6,6,'2020-04-13',7,1.75);

DROP TABLE IF EXISTS `broodtype`;

CREATE TABLE `broodtype` (
  `idbroodtype` int(11) NOT NULL AUTO_INCREMENT,
  `broodnaam` varchar(45) NOT NULL,
  PRIMARY KEY (`idbroodtype`)
) ;

INSERT INTO `broodtype` VALUES (1,'bus melkwit'),(2,'bus wit'),(3,'bus tarwe'),(4,'boeren tijger wit'),(5,'boeren mout'),(6,'boeren tarwe');

DROP TABLE IF EXISTS `klant`;

CREATE TABLE `klant` (
  `idklant` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) NOT NULL,
  `code` int(11) NOT NULL,
  PRIMARY KEY (`idklant`)
) ;

INSERT INTO `klant` VALUES (1,'siebe',1234),(2,'Dario',4321);

DROP TABLE IF EXISTS `overzichtbroden`;
CREATE VIEW `overzichtbroden` AS SELECT 
 1 AS `broodnaam`,
 1 AS `idbroodtype`,
 1 AS `kostprijs`,
 1 AS `positie`,
 1 AS `aantalIn`;
 
 DROP TABLE IF EXISTS `saldo`;

CREATE TABLE `saldo` (
  `idsaldo` int(11) NOT NULL AUTO_INCREMENT,
  `idklant` int(11) NOT NULL,
  `saldo` decimal(8,2) DEFAULT NULL,
  `datum` date DEFAULT NULL,
  `broodpositiedatum` int(11) DEFAULT NULL,
  PRIMARY KEY (`idsaldo`),
  KEY `FKklantsaldo` (`idklant`),
  KEY `FKaankoop` (`broodpositiedatum`),
  CONSTRAINT `FKaankoop` FOREIGN KEY (`broodpositiedatum`) REFERENCES `broodpositiedatum` (`idbroodpositieDatum`),
  CONSTRAINT `FKklantsaldo` FOREIGN KEY (`idklant`) REFERENCES `klant` (`idklant`)
);
INSERT INTO `saldo` VALUES (1,1,30.00,'2020-04-27',6),(2,2,20.00,'2020-04-28',2),(3,2,10.00,'2020-04-26',1);

DROP TABLE IF EXISTS `aankopen`;
 CREATE VIEW `aankopen` AS SELECT 
 1 AS `kostprijs`,
 1 AS `datum`,
 1 AS `idbroodtype`,
 1 AS `idklant`,
 1 AS `broodnaam`,
 1 AS `code`;
;

alter table `broodpositiedatum`
add CONSTRAINT `FKBestaandBrood` FOREIGN KEY (`idbrood`) REFERENCES `broodtype` (`idbroodtype`);