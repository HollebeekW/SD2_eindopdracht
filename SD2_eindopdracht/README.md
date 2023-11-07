# Software Development 2 Eindopdracht
## Wesley Hollebeek, S1117975

### Belangrijk
- Er worden standaard drie account meegeleverd: admin@email.com, employee@email.com en user@email.com. Elk met het wachtwoord "Pass1!". Dit wachtwoord is evnetueel te veranderen in Program.cs, op line 74.
- Het meegeleverde user-account heeft wel een abbonement toegewezen (met Id 2), de twee anderen en nieuwe geregisteerde accounts niet.
- Ik had zelf errors in de UserItemController.cs, de applicatie builde en deed het verder wel gewoon volledig.

### Data
Er wordt (fake) data geseed, de code hiervoor staat deels in /Data/Seeder.cs en in Program.cs:
- De standaard categorieën en abbonement typen worden vanuit al gemaakte data geseed
- Auteurs, users en items worden d.m.v. fake data (met gebruik van Bogus) geseed.
- De rollen en de drie standaard users worden gemaakt in de Program.cs
- Standaard worden er 20 fake auteurs, items en gebruikers gemaakt. Deze aantallen zijn te veranderen in Data/ApplicationDbContext.cs, op line 35. Er moet dan wel een nieuwe Migration aangemaakt worden, de meegeleverde migration heeft alle seeding data al inbegrepen.

### Feautures
- Account aanmaken, d.m.v. Microsoft's Asp.net Identity framework
- Volledige CRUD op auteurs, items, categorieën, abbonement types
- Rol-gebaseerde authorisatie
- Admins kunnen gebruikers verwijderen en rollen van gebruiker weghalen en toevoegen
- Items kunnen gereserveerd worden per gebruiker. Hierbij wordt de voorraad van het item geüpdated, ook met het verwijderen uit de "winkelmand"
- Maximumitems voor "Budget" abbonement (Id 2) kan niet worden overschreden
- De prijs voor het reserveren wordt getoont en geüpdatet wanneer er een item wordt toegevoegd of verwijderd