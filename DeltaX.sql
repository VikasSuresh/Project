Create Database DeltaX
Use DeltaX
GO
--Drop Table Actors
--Drop Table Movies
--Drop Table Producers


Create Table Movies(
Movie_id int identity Constraint pk_Movieid Primary Key,
Name Varchar(50) not null,
YearOfRelease int not null,
Plot varchar(500) not null,
Poster image not null,

);

Create Table Actors(
Actor_id int identity Constraint pk_actorid Primary Key ,
Name Varchar(50) not null,
Sex char(1) not null Constraint ch_Sex Check(Sex in ('M','F')),
DOB varchar(20) not null,
Bio varchar(200)
);




--Alter table Movies Add actor_id int Constraint fk_actorid foreign key references Actors(Actor_id)



Create Table Producers(
Producer_id int identity Constraint pk_producerid Primary Key ,
Name Varchar(50) not null,
Sex char(1) not null Constraint chp_Sex Check(Sex in ('M','F')),
DOB varchar(20) not null,
Bio varchar(200)
);
--Alter table Movies Add Producer_ID int Constraint fk_ProducerId foreign key references Producers(Producer_id)



--Alter table Movies Drop constraint fk_actorid
--Alter Table Movies Drop Constraint fk_ProducerId

-- Insertion



INSERT INTO Movies  
SELECT  'Avengers-Infinity War',2018,'The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\vsvik\Desktop\avenger.jpg', Single_Blob) as Picture

INSERT INTO Movies  
SELECT  'Deadpool 2 ',2018,'Foul-mouthed mutant mercenary Wade Wilson (AKA. Deadpool), brings together a team of fellow mutant rogues to protect a young boy with supernatural abilities from the brutal, time-traveling cyborg, Cable.', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\vsvik\Desktop\Deadpool.jpg', Single_Blob) as Picture

INSERT INTO Movies  
SELECT  'The Dark Knight',2008,'When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\vsvik\Desktop\Batman.jpg', Single_Blob) as Picture

INSERT INTO Movies  
SELECT  'Rampage',2018,'When three different animals become infected with a dangerous pathogen, a primatologist and a geneticist team up to stop them from destroying Chicago.', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\vsvik\Desktop\Rampage.jpg', Single_Blob) as Picture

--Truncate table Actors 
Alter table Actors Add Movieid int Constraint fk_movieid foreign key references Movies(Movie_id)
Insert Into Actors Values('Robert Downey Jr','M','1965-04-04','Downey Jr. made his debut as an actor at the age of five in the film Pound (1970), written and directed by his father, Robert Downey Sr.',1)
Insert Into Actors Values('Chris Hemsworth','M','1983-08-11','Chris Hemsworth was born in Melbourne, Australia, to Leonie (van Os), a teacher of English, and Craig Hemsworth, a social-services counselor.',1)
Insert Into Actors Values('Scarlett Johansson','F','1984-11-22','ChScarlett Johansson was born in New York City. Her mother, Melanie Sloan, is from a Jewish family from the Bronx, and her father, Karsten Johansson, is a Danish-born architect, from Copenhagen',1)
Insert Into Actors Values('ScarRyan Reynolds','M','1976-10-23','Ryan Rodney Reynolds was born on October 23, 1976 in Vancouver, British Columbia, Canada, the youngest of four children.',2)
Insert Into Actors Values('Dwayne Johnson','M','1972-05-02','Dwayne Douglas Johnson, also known as The Rock, was born on May 2, 1972 in Hayward, California, to Ata Johnson and Canadian-born professional wrestler Rocky Johnson.',4)
Insert Into Actors Values('Christian Bale','M','1974-01-30','Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer "Jenny" (James) and David Charles Howard Bale',3)

--Truncate Table Producers
Alter table Producers Add Movieid int Constraint fk_Movie_id foreign key references Movies(Movie_id)
Insert Into Producers Values('Kevin Feige','M','1973-06-02','Feige was raised in Westfield, New Jersey where he graduated from Westfield High School His grandfather had been a television producer in the 1950s.',1)
Insert Into Producers Values('Simon Kinberg','M','1973-08-02','Simon David Kinberg (born August 2, 1973)[3] is a British-born American screenwriter, film and television producer, and director.',2)
Insert Into Producers Values('Charles Roven','M','1949-08-02','Charles Roven (born August 2, 1949)[1] is an American film producer and the president and co-founder of Atlas Entertainment.',3)
Insert Into Producers Values('Brad Peyton','M','1978-05-27','Brad Peyton (born May 27, 1978) is a Canadian film director, writer, and producer. He is best known for directing the 2015 disaster film, San Andreas..',4)

--Select m.Name as 'Name',m.YearOfRelease as 'Year',a.Name as 'Actors',p.Name as 'Producers'  from Movies m join Actors a on a.Movieid=m.Movie_id join Producers p on p.movieid=m.Movie_id;  