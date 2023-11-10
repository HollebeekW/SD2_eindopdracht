# Software Development 2 Eindopdracht
## Wesley Hollebeek, S1117975

---

### Belangrijk
- Er worden standaard drie account meegeleverd: <code>admin@email.com</code>, <code>employee@email.com</code> en <code>user@email.com</code>. Elk met het wachtwoord <code>Pass1!</code>. Deze hebben respectievelijk de rollen Admin, Employee en User
- Het meegeleverde user-account heeft wel een abbonement toegewezen (Budget), de twee anderen en nieuwe geregisteerde accounts niet.

---

### Data
Er wordt een migration meegeleverd, met daarin:
- 100 users, 100 items en 20 auteurs, gefaket met gebruik van Bogus
- De vier abbonementen zoals op Brightspace staat: Jeugd, Budget, Basis en Top
- vijf categorieën: Boek, CD, Game, DVD en Blu-Ray

De standaard accounts en rollen worden beide gemaakt in de <code>Program.cs</code>. Ik hanteerde qua rollen zelf:
- Bezoeker = User
- Medewerker = Employee
- Beheerder = Admin

---

### Features
- Bezoekers (Users) kunnen:
	- Auteurs, categorieën en items inzien
	- items reserveren en lenen (wanneer ze niet geblokkeerd zijn)
	- hun abbonement kiezen en aanpassen
	- items sorteren en zoeken op titel, categorie, auteur voor- en achternaam, jaar van uitgave en voorraad

- Medewerkers (Employees) kunnen:
	- Alles wat een bezoeker kan
	- auteurs, categorieën en items aanmaken en bewerken
	- volledige CRUD op abbonementen
	- abbonementen en boetes verwijderen van gebruikers

- Beheerders (Admins) kunnen:
	- Alles wat een medewerker kan
	- Auteurs, categorieën en items verwijderen
	- Accounts (de-)blokkeren
	- Rollen van gebruikers aanpassen en verwijderen

- Geblokkeerde accounts kunnen geen items lenen
- Bij het verwijderen van een auteur of categorie worden ook alle items met die auteur of categorie verwijderd
- bij het verwijderen van een abbonement wordt deze ook bij de users die dit abbonement hebben verwijderd
