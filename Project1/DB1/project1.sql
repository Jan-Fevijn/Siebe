drop database if exists project1;

create database if not exists project1;

use project1;

create table if not exists typeverrichting(
idtypeVerrichting int not null ,
omschrijving varchar(45) not null,
primary key (idtypeVerrichting)
);

create table if not exists verrichting(
idVerrichting int not null auto_increment,
bedrag decimal(8,2) not null,
datum date not null,
idtypeVerrichting int not null,
primary key (idVerrichting)
);

alter table verrichting
ADD constraint FK_typeVerrichting
	foreign key (idtypeVerrichting)
    references typeverrichting(idtypeVerrichting)
    On DELETE NO ACTION
    ON UPDATE NO ACTION;

insert into typeverrichting ( idtypeverrichting,omschrijving)values ( 1101,'voeding');

insert into verrichting ( bedrag,datum,idtypeVerrichting) values ( 10.5,'2020-10-10,1101',1101);

create table if not exists persoon (
idpersoon int not null auto_increment,
naam varchar(45) not null,
voornaam varchar(45) not null ,
email varchar(60) not null,
primary key (idpersoon)
);

insert into persoon (naam,voornaam,email) values('hindryckx','siebe','siebehindryckx@atheneumjanfevijn.be');

alter table verrichting
add idpersoon int not null default 1 ;

alter table verrichting
add constraint FK_persoon
foreign key (idpersoon ) References persoon (idpersoon);

alter table persoon
add admin int not null default 0 ;