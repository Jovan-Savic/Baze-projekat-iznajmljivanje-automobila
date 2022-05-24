CREATE DATABASE Autoizdaja;
USE Autoizdaja;

CREATE TABLE Proizvodjac
(
id int primary key identity(1,1),
naziv nvarchar(30) not null,
)
CREATE TABLE Osoba(
id int primary key identity(1,1),
jmbg nvarchar(13),
ime nvarchar(20),
prezime nvarchar(20),
email nvarchar(40),
sifra nvarchar(20)
)
CREATE TABLE Automobil(
id int primary key identity(1,1),
id_proizvodjaca int foreign key references Proizvodjac(id),
model nvarchar(20),
tablica nvarchar(9),
registracija date,
godiste date
)
INSERT INTO Automobil VALUES (1,'Clio','BG318AC','2025-04-13','1991-03-01')
INSERT INTO Automobil VALUES (1,'Megane','BG4852GG','2023-11-07','2005-08-01')
INSERT INTO Automobil VALUES (4,'Yaris','BG1299MX','2025-09-19','2010-05-21')
INSERT INTO Automobil VALUES (6,'Punto','SA484SM','2030-01-31','2007-12-28')

CREATE TABLE Ugovor(
id int primary key identity(1,1),
id_osobe int foreign key references Osoba(id),
id_automobil int foreign key references Automobil(id),
imekl nvarchar(20),
prezimekl nvarchar(20),
jmbgkl nvarchar(13),
od date,
do date,
cena int
)
INSERT INTO Ugovor VALUES(1,4,'Darko','Stosic','2108003773931','2022-05-22','2022-05-27','30')
INSERT INTO Ugovor VALUES(1,6,'Darko','Stosic','2108003773931','2022-06-01','2022-06-02','28')
INSERT INTO Ugovor VALUES(2,7,'Janko','Veselinovic','2108003773991','2022-05-27','2022-06-01','25')

SELECT ime , model , imekl, prezimekl, jmbgkl, od, do ,cena*DATEDIFF(DAY,od,do) as Cena from Ugovor LEFT JOIN Osoba ON id_osobe = Osoba.id LEFT JOIN Automobil ON id_automobil = Automobil.id
