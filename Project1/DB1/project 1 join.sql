create view alleInfoVerrichtingen as 
select bedrag , datum , persoon.idpersoon , omschrijving , naam , voornaam from (verrichting
join typeverrichting on typeverrichting.idtypeverrichting = verrichting.idtypeverrichting)
join persoon on persoon.idpersoon = verrichting.idpersoon
;