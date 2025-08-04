using EjercicioGrupal;
using System;

SalaComun Sala1 = new SalaComun("Sala 103", "Planta Baja");
Sala1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(3)), "Fernanda", 23);
Sala1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(3)), "Jose", 15);
Sala1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(1)), "Jeremy", 51);

Auditorio Auditiorio1 = new Auditorio("Simon Bolivar", "Sección Oeste", false);
Auditiorio1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(2)), "Maria", 80);
Auditiorio1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(2)), "Jessica", 30);
Auditiorio1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(1)), "Pablo", 100);
Auditorio Auditiorio2 = new Auditorio("Miguel de Cervantes", "Sección Norte", true);
Auditiorio2.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(2)), "Mishell", 75);
Auditiorio2.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(2)), "Ana", 60);
Auditiorio2.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(1)), "Paola", 90);

Laboratorio Laboratorio1 = new Laboratorio("Laboratorio de Programación", "Planta Alta", true, false);
Laboratorio1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Carlos", 15);
Laboratorio1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Elmer", 19);
Laboratorio1.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "David", 25);
Laboratorio Laboratorio2 = new Laboratorio("Laboratorio de Quimica", "Planta Alta", false, true);
Laboratorio2.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Gabriela", 9);
Laboratorio2.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Rossmery", 13);
Laboratorio2.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Alexis", 30);
Laboratorio Laboratorio3 = new Laboratorio("Laboratorio de Programación", "Planta Alta", true, true);
Laboratorio3.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Diego", 10);
Laboratorio3.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Paolo", 15);
Laboratorio3.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Sebastian", 25);
Laboratorio Laboratorio4 = new Laboratorio("Laboratorio de clases", "Planta Alta", false, false);
Laboratorio4.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Giovanna", 10);
Laboratorio4.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Sandra", 15);
Laboratorio4.Reservar(DateOnly.FromDateTime(DateTime.Now.AddDays(10)), "Antonia", 25);