CREATE SCHEMA if not exists `project4` ;


CREATE TABLE `project3`.`klant` (
  `idklant` INT NOT NULL AUTO_INCREMENT,
  `naamKlant` VARCHAR(45) NULL,
  `SaldoKlant` VARCHAR(45) NULL,
  `Kaartnummer` VARCHAR(45) NULL,
  PRIMARY KEY (`idklant`));

CREATE TABLE `project3`.`brood` (
  `idbrood` INT NOT NULL AUTO_INCREMENT,
  `broodbesch` VARCHAR(45) NULL,
  PRIMARY KEY (`idbrood`));
  
  CREATE TABLE `project3`.`automaat` (
  `idautomaat` INT NOT NULL AUTO_INCREMENT,
  `BroodId` VARCHAR(45) NOT NULL,
  `Broodprijs` VARCHAR(45) NULL,
  `Broodlocatie` VARCHAR(45) NULL,
  `Datum` DATETIME NULL,
  PRIMARY KEY (`idautomaat`, `BroodId`));
  
  CREATE TABLE `project3`.`transactie` (
  `idtransactie` INT NOT NULL AUTO_INCREMENT,
  `automaatID` VARCHAR(45) NULL,
  `kaartnummer` VARCHAR(45) NULL,
  `datum` DATETIME NULL,
  PRIMARY KEY (`idtransactie`));
  