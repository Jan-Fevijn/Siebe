drop database if exists project2;

CREATE SCHEMA if not exists `project2` ;

use project2;

CREATE TABLE if not exists `project2`.`evenement` (
  `evenementID` INT NOT NULL AUTO_INCREMENT,
  `evenementNaam` VARCHAR(45) NULL,
  `datumVan` DATETIME NULL,
  `datumTot` DATETIME NULL,
  `aantalPersonen` VARCHAR(45) NULL,
  PRIMARY KEY (`evenementID`));


CREATE TABLE if not exists `project2`.`gerecht` (
  `GerechtID` INT NOT NULL AUTO_INCREMENT,
  `naamGerecht` VARCHAR(45) NULL,
  `hoeveelheidProduct` VARCHAR(45) NULL,
  PRIMARY KEY (`GerechtID`));


CREATE TABLE if not exists `project2`.`evenementgerecht` (
  `EvenementID` INT NOT NULL,
  `GerechtID` INT NOT NULL,
  PRIMARY KEY (`EvenementID`, `GerechtID`));
  
  
  CREATE TABLE if not exists`project2`.`winkel` (
  `winkelID` INT NOT NULL AUTO_INCREMENT,
  `winkelnaam` VARCHAR(45) NULL,
  PRIMARY KEY (`winkelID`));
  
  
  CREATE TABLE if not exists`project2`.`product` (
  `ProductID` INT NOT NULL AUTO_INCREMENT,
  `winkelID` VARCHAR(45) NOT NULL,
  `naamproduct` VARCHAR(45) NULL,
  `hoeveelheidaankoop` VARCHAR(3) NULL,
  `Productcol` VARCHAR(45) NULL,
  `eenheid` VARCHAR(4) NULL,
  PRIMARY KEY (`ProductID`, `winkelID`));

  
  CREATE TABLE if not exists `project2`.`gerechtproduct` (
  idgerechtproduct int not null auto_increment,
  `GerechtID` INT NOT NULL,
  `productID` INT NOT NULL,
 hoeveelheidproduct decimal(8,2) not null,
  PRIMARY KEY (idgerechtproduct));


alter table gerechtproduct
add constraint FK_gerecht
foreign key (gerechtid) references gerecht(gerechtid);


alter table gerechtproduct
add constraint FK_product
foreign key (productid) references product (productid);


create view allegerechten as 
select gerecht.gerechtid , gerecht.naamgerecht , product.naamProduct , gerechtproduct.hoeveelheidproduct,product.eenheid
from gerechtproduct
join gerecht on gerechtproduct.gerechtid = gerecht.gerechtid
join product on gerechtproduct.productid = product.productid

