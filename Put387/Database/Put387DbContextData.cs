﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Put387.Database
{
    public partial class Put387DbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Uloga>().HasData(new List<Uloga>
                {
                    new Uloga
                    {
                        Id = 1,
                        Naziv = "Admin",

                    },
                    new Uloga
                    {
                        Id = 2,
                        Naziv = "Vozac",
                    },
                    new Uloga
                    {
                        Id = 3,
                        Naziv = "Putnik",
                    }
                }
           );

            modelBuilder.Entity<Grad>().HasData(new List<Grad>
                {
                    new Grad
                    {
                        Id = 1,
                        Naziv = "Sarajevo",

                    },
                    new Grad
                    {
                        Id = 2,
                        Naziv = "Mostar",
                    },
                    new Grad
                    {
                        Id = 3,
                        Naziv = "Konjic",
                    }
                }
            );

            modelBuilder.Entity<Kategorija>().HasData(new List<Kategorija>
                {
                    new Kategorija
                    {
                        Id = 1,
                        Naziv = "Junior vozac",
                        Slika = File.ReadAllBytes("img/kat1.png")

                    },
                    new Kategorija
                    {
                        Id = 2,
                        Naziv = "Senior vozac",
                        Slika = File.ReadAllBytes("img/kat2.png")

                    }
                }
            );
            Korisnik admin = new Korisnik
            {
                Id = 1,
                Ime = "Omer",
                Prezime = "Omerovic",
                Email = "omer@put387.com",
                Telefon = "+38762101010",
                Aktivan = true,
                Username = "admin",
                ulogaId = 1,
                gradId = 1,
                Slika = File.ReadAllBytes("img/defaultProfile.png"),
                DatumRegistracije = DateTime.Now
            };

            admin.PasswordSalt = Helper.HashGenerator.GenerateSalt();
            admin.PasswordHash = Helper.HashGenerator.GenerateHash(admin.PasswordSalt, "admin");

            modelBuilder.Entity<Korisnik>().HasData(admin);

            Korisnik vozac = new Korisnik
            {
                Id = 2,
                Ime = "Mario",
                Prezime = "Maric",
                Email = "mario@put387.com",
                Telefon = "+38762101010",
                Aktivan = true,
                Username = "vozac_mario",
                ulogaId = 2,
                gradId = 2,
                Slika = File.ReadAllBytes("img/defaultProfile.png"),
                DatumRegistracije = DateTime.Now
            };

            vozac.PasswordSalt = Helper.HashGenerator.GenerateSalt();
            vozac.PasswordHash = Helper.HashGenerator.GenerateHash(vozac.PasswordSalt, "vozacMario");

            modelBuilder.Entity<Korisnik>().HasData(vozac);

            Korisnik putnik = new Korisnik
            {
                Id = 3,
                Ime = "Ema",
                Prezime = "Emic",
                Email = "ema@put387.com",
                Telefon = "+38762101010",
                Aktivan = true,
                Username = "putnik_ema",
                ulogaId = 3,
                gradId = 3,
                Slika = File.ReadAllBytes("img/defaultProfile.png"),
                DatumRegistracije = DateTime.Now
            };

            putnik.PasswordSalt = Helper.HashGenerator.GenerateSalt();
            putnik.PasswordHash = Helper.HashGenerator.GenerateHash(putnik.PasswordSalt, "putnikEma");

            modelBuilder.Entity<Korisnik>().HasData(putnik);

            Korisnik vozac2 = new Korisnik
            {
                Id = 4,
                Ime = "Leo",
                Prezime = "Prezime",
                Email = "leo@put387.com",
                Telefon = "+38762101010",
                Aktivan = true,
                Username = "vozac_leo",
                ulogaId = 2,
                gradId = 1,
                Slika = File.ReadAllBytes("img/defaultProfile.png"),
                DatumRegistracije = DateTime.Now
            };

            vozac2.PasswordSalt = Helper.HashGenerator.GenerateSalt();
            vozac2.PasswordHash = Helper.HashGenerator.GenerateHash(vozac2.PasswordSalt, "vozacLeo");

            modelBuilder.Entity<Korisnik>().HasData(vozac2);

            Korisnik putnik2 = new Korisnik
            {
                Id = 5,
                Ime = "Rijad",
                Prezime = "Rijadic",
                Email = "rijad@put387.com",
                Telefon = "+38762101010",
                Aktivan = true,
                Username = "putnik_rijad",
                ulogaId = 3,
                gradId = 3,
                Slika = File.ReadAllBytes("img/defaultProfile.png"),
                DatumRegistracije = DateTime.Now
            };

            putnik2.PasswordSalt = Helper.HashGenerator.GenerateSalt();
            putnik2.PasswordHash = Helper.HashGenerator.GenerateHash(putnik2.PasswordSalt, "putnikRijad");

            modelBuilder.Entity<Korisnik>().HasData(putnik2);


            modelBuilder.Entity<Vozilo>().HasData(new List<Vozilo>
                {
                    new Vozilo
                    {
                        Id = 1,
                       KorisnikId = 2,
                       BrojRegistracije = "14O-M-1I1",
                       Model = "",
                       Proizvodjac = "Audi",
                       TipGoriva = "Dizel",
                    },
                    new Vozilo
                    {
                        Id = 2,
                       KorisnikId = 4,
                       BrojRegistracije = "54O-M-1I1",
                       Model = "",
                       Proizvodjac = "BMW",
                       TipGoriva = "Benzin",
                    }
                }
);

            modelBuilder.Entity<Mjesto>().HasData(new List<Mjesto>
                {
                    new Mjesto
                    {
                        Id = 1,
                        Naziv = "Sarajevo",

                    },
                    new Mjesto
                    {
                        Id = 2,
                        Naziv = "Mostar",
                    },
                    new Mjesto
                    {
                        Id = 3,
                        Naziv = "Konjic",
                    },
                    new Mjesto
                    {
                        Id = 4,
                        Naziv = "Zenica",
                    },
                    new Mjesto
                    {
                        Id = 5,
                        Naziv = "Travnik",
                    },
                     new Mjesto
                    {
                        Id = 6,
                        Naziv = "Bihac",
                    },
                     new Mjesto
                     {
                         Id=7,
                         Naziv="Jablanica"
                     },
                     new Mjesto
                     {
                         Id=8,
                         Naziv="Livno"
                     },
                     new Mjesto
                     {
                         Id=9,
                         Naziv="Lukavac"
                     },
                     new Mjesto
                     {
                         Id=10,
                         Naziv="Gorazde"
                     }

                }
            );

            modelBuilder.Entity<Medalja>().HasData(new List<Medalja>
                {
                    new Medalja
                    {
                        Id = 1,
                        Naziv = "Plava",
                        kategorijaId = 1,
                        Ikonica = File.ReadAllBytes("img/iconPlava.png"),
                        MinBrojAkcija = 2,
                        MaxBrojAkcija = 5,
                        Opis = "Minimalno 2 a maksimalno 5 voznji za ovu medalju"
                    },
                    new Medalja
                    {
                        Id = 2,
                        Naziv = "Zuta",
                        kategorijaId = 1,
                        Ikonica = File.ReadAllBytes("img/iconZuta.png"),
                        MinBrojAkcija = 6,
                        MaxBrojAkcija = 15,
                        Opis = "Minimalno 6 a maksimalno 15 voznji za ovu medalju"
                    },
                }
            );

            modelBuilder.Entity<MedaljaKorisnik>().HasData(new List<MedaljaKorisnik>
                {
                    new MedaljaKorisnik
                    {
                        Id = 1,
                        medaljaId = 1,
                        korisnikId = 2,
                        DatumKreiranja = DateTime.Now

                    },
                    new MedaljaKorisnik
                    {
                        Id = 2,
                        medaljaId = 2,
                        korisnikId = 3,
                        DatumKreiranja = DateTime.Now
                    }
                }
           );

            modelBuilder.Entity<TipVoznje>().HasData(new List<TipVoznje>
                {
                    new TipVoznje
                    {
                        Id = 1,
                        Naziv = "Kratka",

                    },
                    new TipVoznje
                    {
                        Id = 2,
                        Naziv = "Duga",
                    }
                }
           );

            modelBuilder.Entity<Voznja>().HasData(new List<Voznja>
                {
                    new Voznja
                    {
                        Id = 1,
                        polazisteId = 1,
                        odredisteId = 2,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 4,
                        Cijena = 0,
                        DatumObjave = new DateTime (2021,10,05),
                        DatumVrijemePolaska = new DateTime (2021,10,25),
                        Napomena = "Zabranjeno pusenje u autu!",
                        tipVoznjeId = 1,
                        vozacId = 2
                    },
                     new Voznja
                    {
                        Id = 2,
                        polazisteId = 2,
                        odredisteId = 3,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 2,
                        Cijena = 10,
                        DatumObjave = new DateTime (2021,10,01),
                        DatumVrijemePolaska = new DateTime (2021,10,27),
                        Napomena = "Nema pauza",
                        tipVoznjeId = 1,
                        vozacId = 2
                    },
                      new Voznja
                    {
                        Id = 3,
                        polazisteId = 2,
                        odredisteId = 3,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 2,
                        Cijena = 10,
                        DatumObjave = new DateTime (2020,12,27),
                        DatumVrijemePolaska = new DateTime (2021,01,07),
                        Napomena = "Stajanje nakon pola sata!",
                        tipVoznjeId = 2,
                        vozacId = 2
                    },

                        new Voznja
                    {
                        Id = 4,
                        polazisteId = 3,
                        odredisteId = 4,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 4,
                        Cijena = 5,
                        DatumObjave = new DateTime (2021,12,03),
                        DatumVrijemePolaska = new DateTime (2021,12,27),
                        Napomena = "Nema ogranicenja",
                        tipVoznjeId = 2,
                        vozacId = 4
                    },
                            new Voznja
                    {
                        Id = 5,
                        polazisteId = 2,
                        odredisteId = 4,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 4,
                        Cijena = 5,
                        DatumObjave = new DateTime (2021,04,04),
                        DatumVrijemePolaska = new DateTime (2021,04,07),
                        Napomena = "Nema ogranicenja 2",
                        tipVoznjeId = 2,
                        vozacId = 4
                    },
                            new Voznja
                    {
                        Id = 6,
                        polazisteId = 1,
                        odredisteId = 4,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 4,
                        Cijena = 3,
                        DatumObjave = new DateTime (2021,07,04),
                        DatumVrijemePolaska = new DateTime (2021,08,17),
                        Napomena = "Bez kucnih ljubimaca",
                        tipVoznjeId = 2,
                        vozacId = 4
                    },
                    new Voznja
                    {
                        Id = 7,
                        polazisteId = 1,
                        odredisteId = 4,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 3,
                        Cijena = 0,
                        DatumObjave = new DateTime (2021,07,04),
                        DatumVrijemePolaska = new DateTime (2021,12,10),
                        Napomena = "Korisnik nije unio podatke nije unio podatke",
                        tipVoznjeId = 2,
                        vozacId = 2
                    },
                     new Voznja
                    {
                        Id = 8,
                        polazisteId = 7,
                        odredisteId = 8,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 4,
                        Cijena = 0,
                        DatumObjave = new DateTime (2021,07,05),
                        DatumVrijemePolaska = new DateTime (2021,12,10),
                        Napomena = "Korisnik nije unio podatke",
                        tipVoznjeId = 2,
                        vozacId = 4
                    },
                     new Voznja
                    {
                        Id = 9,
                        polazisteId = 9,
                        odredisteId = 10,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 4,
                        Cijena = 10,
                        DatumObjave = new DateTime (2021,08,08),
                        DatumVrijemePolaska = new DateTime (2021,12,15),
                        Napomena = "Korisnik nije unio podatke",
                        tipVoznjeId = 2,
                        vozacId = 2
                    },
                      new Voznja
                    {
                        Id = 10,
                        polazisteId = 1,
                        odredisteId = 10,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 1,
                        Cijena = 0,
                        DatumObjave = new DateTime (2021,08,08),
                        DatumVrijemePolaska = new DateTime (2021,12,16),
                        Napomena = "Zadnja vrata pokvarena",
                        tipVoznjeId = 1,
                        vozacId = 2
                    },
                      new Voznja
                    {
                        Id = 11,
                        polazisteId = 1,
                        odredisteId = 8,
                        Aktivna = true,
                        BrojMjesta=5,
                        BrojSlobodnihMjesta = 2,
                        Cijena = 7,
                        DatumObjave = new DateTime (2021,08,08),
                        DatumVrijemePolaska = new DateTime (2022,01,01),
                        Napomena = "Stajanje kod restorana",
                        tipVoznjeId = 2,
                        vozacId = 4
                    },
                }
           );

            modelBuilder.Entity<VoznjaKorisnici>().HasData(new List<VoznjaKorisnici>
                {
                    new VoznjaKorisnici
                    {
                        Id = 1,
                        korisnikId = 3,
                        voznjaId = 1
                    },
                    new VoznjaKorisnici
                    {
                        Id = 2,
                        korisnikId = 3,
                        voznjaId = 2
                    },
                    new VoznjaKorisnici
                    {
                        Id = 3,
                        korisnikId = 3,
                        voznjaId = 3
                    },
                    new VoznjaKorisnici
                    {
                        Id = 4,
                        korisnikId = 5,
                        voznjaId = 2
                    },
                    new VoznjaKorisnici
                    {
                        Id = 5,
                        korisnikId = 5,
                        voznjaId = 4
                    },
                    new VoznjaKorisnici
                    {
                        Id = 6,
                        korisnikId = 3,
                        voznjaId = 5
                    },
                }
           );

            modelBuilder.Entity<Zahtjev>().HasData(new List<Zahtjev>
                {
                    new Zahtjev
                    {
                        Id = 1,
                        korisnikId = 3,
                        voznjaId = 1,
                        DatumKreiranja = new DateTime (2021,10,15),
                        BrojMjesta = 1,
                        Status = true,
                        isReviewed = true,
                        isPaid = true
                    },
                    new Zahtjev
                    {
                        Id = 2,
                        korisnikId = 3,
                        voznjaId = 2,
                        DatumKreiranja = new DateTime (2021,10,20),
                        BrojMjesta = 1,
                        Status = true,
                        isReviewed = true,
                        isPaid = true
                    },
                    new Zahtjev
                    {
                        Id = 3,
                        korisnikId = 3,
                        voznjaId = 3,
                        DatumKreiranja = new DateTime (2021,01,05),
                        BrojMjesta = 1,
                        Status = true,
                        isReviewed = true,
                        isPaid = true
                    },
                    new Zahtjev
                    {
                        Id = 4,
                        korisnikId = 5,
                        voznjaId = 2,
                        DatumKreiranja = new DateTime (2021,12,25),
                        BrojMjesta = 1,
                        Status = true,
                        isReviewed = true,
                        isPaid = true
                    },
                    new Zahtjev
                    {
                       Id = 5,
                        korisnikId = 5,
                        voznjaId = 4,
                        DatumKreiranja = new DateTime (2021,12,24),
                        BrojMjesta = 1,
                        Status = true,
                        isReviewed = true,
                        isPaid = true
                    },
                    new Zahtjev
                    {
                       Id = 6,
                        korisnikId = 3,
                        voznjaId = 5,
                        DatumKreiranja = new DateTime (2021,04,02),
                        BrojMjesta = 1,
                        Status = true,
                        isReviewed = true,
                        isPaid = true
                    },
                    new Zahtjev
                    {
                       Id = 7,
                        korisnikId = 3,
                        voznjaId = 6,
                        DatumKreiranja = new DateTime (2021,08,15),
                        BrojMjesta = 1,
                        Status = false,
                        isReviewed = false,
                        isPaid = false
                    },
                    new Zahtjev
                    {
                       Id = 8,
                        korisnikId = 5,
                        voznjaId = 6,
                        DatumKreiranja = new DateTime (2021,08,14),
                        BrojMjesta = 1,
                        Status = false,
                        isReviewed = false,
                        isPaid = false
                    },
                }
);
           

            modelBuilder.Entity<VoznjaDojam>().HasData(new List<VoznjaDojam>
                {
                    new VoznjaDojam
                    {
                        Id = 1,
                        voznjaId = 1,
                        Ocjena = 5,
                        korisnikId = 2,
                        DatumKreiranja = DateTime.Now,
                        Komentar = "Sve super"
                    },
                    new VoznjaDojam
                    {
                        Id = 2,
                        voznjaId = 2,
                        Ocjena = 2,
                        korisnikId = 2,
                        DatumKreiranja = DateTime.Now,
                        Komentar = "Nista nije bilo kako treba"
                    },
                    new VoznjaDojam
                    {
                        Id = 3,
                        voznjaId = 3,
                        Ocjena = 4,
                        korisnikId = 4,
                        DatumKreiranja = DateTime.Now,
                        Komentar = "Sve super!"
                    },
                    new VoznjaDojam
                    {
                        Id = 4,
                        voznjaId = 2,
                        Ocjena = 5,
                        korisnikId = 2,
                        DatumKreiranja = DateTime.Now,
                        Komentar = "Sve super"
                    },
                    new VoznjaDojam
                    {
                        Id = 5,
                        voznjaId = 5,
                        Ocjena = 1,
                        korisnikId = 4,
                        DatumKreiranja = DateTime.Now,
                        Komentar = "Veoma lose!"
                    },
                }
           );
        }
    }
}
