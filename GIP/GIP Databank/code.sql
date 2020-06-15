drop schema gip;
CREATE SCHEMA if not exists `gip` ;

use`gip`;


CREATE TABLE `leerling` (
  `idleerling` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  `voornaam` VARCHAR(45) NULL,
   `email` VARCHAR(45) NULL,
  `idklas` INT NOT NULL ,
  PRIMARY KEY (`idleerling`));
  
  CREATE TABLE `aanwezig` (
  `idaanwezig` INT NOT NULL AUTO_INCREMENT,
  `idleerling` VARCHAR(45) NULL,
  `tijd` VARCHAR(45) NULL,
  `aanwezigheid` VARCHAR(45) NULL DEFAULT 'afwezig',
  PRIMARY KEY (`idaanwezig`));
  
   CREATE TABLE `klas` (
  `idklas` INT NOT NULL AUTO_INCREMENT,
  `omschrijving` VARCHAR(45) NULL,
  `leerjaar` VARCHAR(45) NULL,
  `schooljaar` VARCHAR(45) NULL,
  PRIMARY KEY (`idklas`));
  
  ALTER TABLE `gip`.`leerling` 
ADD INDEX `FKleerlingklas_idx` (`idklas` ASC);
;
ALTER TABLE `leerling` 
ADD CONSTRAINT `FKleerlingklas`
  FOREIGN KEY (`idklas`)
  REFERENCES `klas` (`idklas`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
  CREATE VIEW `controle` AS 
  Select leerling.voornaam ,leerling.naam, aanwezig.tijd, aanwezig.aanwezigheid 
  from aanwezig 
  Join leerling on leerling.idleerling = aanwezig.idleerling;
  
  ALTER TABLE `gip`.`aanwezig` 
  ADD COLUMN `datum` DATETIME NULL AFTER `aanwezigheid`;


  INSERT INTO `gip`.`klas` (`omschrijving`, `leerjaar`, `schooljaar`) VALUES ('ITN', '6', '2019-2020');
  INSERT INTO `gip`.`leerling` (`naam`, `voornaam`, `email`, `idklas`) VALUES ('hindryckx', 'siebe', 'siebehindryckx@atheneumjanfevijn.be', '1');
  INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`) VALUES ('1', '10:47', 'aanwezigheid');
  INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`) VALUES ('1', '11:48', 'afwezigheid');
  UPDATE `gip`.`aanwezig` SET `datum` = '2020-05-19' WHERE (`idaanwezig` = '1');
UPDATE `gip`.`aanwezig` SET `datum` = '2020-05-19' WHERE (`idaanwezig` = '2');
INSERT INTO `gip`.`klas` (`omschrijving`, `leerjaar`, `schooljaar`) VALUES ('STW', '6', '2019-2020');
INSERT INTO `gip`.`leerling` (`naam`, `voornaam`, `email`, `idklas`) VALUES ('Standaert', 'lena', 'lenastandaert@atheneumjanfevijn.be', '2');
INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`, `datum`) VALUES ('2', '12:00', 'afwezig', '2020-06-11');
INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`, `datum`) VALUES ('2', '8:25', 'aanwezig', '2020-06-11');
UPDATE `gip`.`aanwezig` SET `aanwezigheid` = 'aanwezig' WHERE (`idaanwezig` = '1');
UPDATE `gip`.`aanwezig` SET `aanwezigheid` = 'afwezig' WHERE (`idaanwezig` = '2');

INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`, `datum`) VALUES ('1', '8:25', 'aanwezig', '2020-06-18');
INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`, `datum`) VALUES ('2', '8:30', 'aanwezig', '2020-06-18');
INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`, `datum`) VALUES ('1', '12:05', 'afwezig', '2020-06-18');
INSERT INTO `gip`.`aanwezig` (`idleerling`, `tijd`, `aanwezigheid`, `datum`) VALUES ('2', '12:00', 'afwezig', '2020-06-18');

