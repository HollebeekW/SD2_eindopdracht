# Software Development 2 Eindopdracht
## Wesley Hollebeek, S1117975

---

### Belangrijk
- Er worden standaard drie account meegeleverd: <code>admin@email.com</code>, <code>employee@email.com</code> en <code>user@email.com</code>. Elk met het wachtwoord <code>Pass1!</code>.
- Het meegeleverde user-account heeft wel een abbonement toegewezen (Budget), de twee anderen en nieuwe geregisteerde accounts niet

---

### Data
Er wordt een migration meegeleverd, met daarin:
- 100 users, 100 items en 20 auteurs, gefaket met gebruik van Bogus
- De vier abbonementen zoals op Brightspace staat: Jeugd, Budget, Basis en Top
- vijf categorieën: Boek, CD, Game, DVD en Blu-Ray
- 
De standaard accounts en rollen worden beide gemaakt in de <code>Program.cs</code>. Ik hanteerde qua rollen zelf:
- Bezoeker = User
- Medewerker = Employee
- Beheerder = Admin

---

### Features
- Volledige CRUD op auteurs, items, categorieën en abbonementen, op basis van rollen:
	- Bezoekers (users) kunnen alleen alles inzien
	- Medewerkers (employees) kunnen ook alles bewerken, de itemvoorraad beheren en boetes van bezoekers inzien en verwijderen
	- Beheerders (admins) kunnen ook alles verwijderen, gebruikers een rol geven of verwijderen en gebruikers (de-)blokkeren
- Gebruikers kunnen een abbonement kiezen en verwijderen
- Gebruikers kunnen items reserveren, hierbij wordt ook gelet op:
	- Itemvoorraad, items die niet op voorraad zijn kunnen niet worden gereserveerd
	- Maximum aantal items dat per keer te reserveren is per abbonement. Dit kan niet overschreden worden
	- De prijs, dit wordt per item per abbonement berekend
- Er kan gesorteerd worden bij items op:
	- Item naam
	- Categorie
	- Auteur voornaam
	- Auteur achternaam
	- Jaar van uitgeven
	- Voorraad
- Als laatste kan er bij items gezocht worden op alle bovenstaande termen
