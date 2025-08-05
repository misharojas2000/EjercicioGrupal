using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGrupal
{
    public enum TipoEvento
    {
        Clase,
        Conferencia,
        Practica
    }
    public enum EstadoReserva
    {
        Pendiente,
        Aprobada,
        Rechazada
    }
    public abstract class Sala
    {
        public string Nombre;
        public int Capacidad;
        public string Ubicacion;
        public bool Reservada = false;
        public DateOnly? FechaReservada = null;
        public EstadoReserva Estado = EstadoReserva.Pendiente;

        public Sala(string nombre, int capacidad, string ubicacion)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            Ubicacion = ubicacion;
        }
        public abstract void Reservar(DateOnly fecha, string organizador, int capacidadRequerida, TipoEvento tipo);
    }

    public class SalaComun : Sala
    {
        public SalaComun(string nombre, string ubicacion) : base(nombre, 50, ubicacion)
        {
        }
        public override void Reservar(DateOnly fecha, string organizador, int capacidadRequerida, TipoEvento tipo)
        {
            if (FechaReservada.HasValue && FechaReservada.Value < DateOnly.FromDateTime(DateTime.Now))
            {
                Reservada = false;
                FechaReservada = null;
                Estado = EstadoReserva.Pendiente;
                return;
            }

            if (capacidadRequerida > Capacidad)
            {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"La sala {Nombre} solo tiene capacidad para {Capacidad} personas. \n");
                return;
            }

            if (Reservada && FechaReservada == fecha)
            {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"La sala {Nombre} ya esta reservada para la fecha {FechaReservada.Value}. \n");
                return;
            }

            if (fecha < DateOnly.FromDateTime(DateTime.Now))
            {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"La fecha {fecha} no es valida, debe ser una fecha futura. \n");
                return;
            }

            Reservada = true;
            FechaReservada = fecha;
            Estado = EstadoReserva.Aprobada;
            Console.WriteLine($"La sala {Nombre} ha sido reservada para la fecha {fecha} por {organizador}. \n");
        }
    }

    public class Auditorio : Sala
    {
        public bool TienePantalla;

        public Auditorio(string nombre, string ubicacion, bool tienePantalla) : base(nombre, 80, ubicacion)
        {
            TienePantalla = tienePantalla;
        }

        public override void Reservar(DateOnly fecha, string organizador, int capacidadRequerida, TipoEvento tipo)
        {
            if (FechaReservada.HasValue && FechaReservada.Value < DateOnly.FromDateTime(DateTime.Now))
            {
                Reservada = false;
                FechaReservada = null;
                Estado = EstadoReserva.Pendiente;
                return;
            }

            if (capacidadRequerida > Capacidad)
            {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"El auditorio {Nombre} solo tiene capacidad para {Capacidad} personas. \n");
                return;
            }

                if (Reservada && FechaReservada == fecha)
                {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"El auditorio {Nombre} ya esta reservado para la fecha {FechaReservada.Value}. \n");
                    return;
                }
            if (fecha < DateOnly.FromDateTime(DateTime.Now))
            {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"La fecha {fecha} no es valida, debe ser una fecha futura. \n");
                return;
            }

            if (TienePantalla)
            {
                Console.WriteLine($"El auditorio {Nombre} cuenta con pantalla para presentaciones.");
            }
            Reservada = true;
            FechaReservada = fecha;
            Estado = EstadoReserva.Aprobada;
            Console.WriteLine($"El auditorio {Nombre} ha sido reservado para la fecha {fecha} por {organizador}. \n");
        }
    }

        public class Laboratorio : Sala
        {
            bool TieneComputadoras;
            bool TieneProyector;
            public Laboratorio(string nombre, string ubicacion, bool tieneComputadoras, bool tieneProyector) : base(nombre, 20, ubicacion)
            {
                TieneComputadoras = tieneComputadoras;
                TieneProyector = tieneProyector;
            }

            public override void Reservar(DateOnly fecha, string organizador, int capacidadRequerida, TipoEvento tipo)
            {
                if (FechaReservada.HasValue && FechaReservada.Value < DateOnly.FromDateTime(DateTime.Now))
                {
                    Reservada = false;
                    FechaReservada = null;
                    Estado = EstadoReserva.Pendiente;
                    return;
                }

        if (capacidadRequerida > Capacidad)
        {
            Console.WriteLine($"El laboratorio {Nombre} solo tiene capacidad para {Capacidad} personas. \n");
            return;
        }
                    if (Reservada && FechaReservada == fecha)
                {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"El laboratorio {Nombre} ya esta reservado para la fecha {FechaReservada.Value}. \n");
                    return;
                }

                  if (fecha < DateOnly.FromDateTime(DateTime.Now))
                {
                Estado = EstadoReserva.Rechazada;
                Console.WriteLine($"El laboratorio {fecha} no es valida, debe ser una fecha futura. \n");
                    return;
                }
                if (TieneComputadoras && TieneProyector)
                {
                    Console.WriteLine($"El laboratorio {Nombre} cuenta con computadoras y proyector para uso de los estudiantes.");
                }
                else if (TieneComputadoras)
                {
                    Console.WriteLine($"El laboratorio {Nombre} cuenta con computadoras para uso de los estudiantes.");
                }
                else if (TieneProyector)
                {
                    Console.WriteLine($"El laboratorio {Nombre} cuenta con proyector.");
                }
                else 
                {
                    Console.WriteLine($"El laboratorio {Nombre} no cuenta con computadoras ni proyector.");
                }

                    Reservada = true;
                FechaReservada = fecha;
            Estado = EstadoReserva.Aprobada;
            Console.WriteLine($"El laboratorio {Nombre} ha sido reservado para la fecha {fecha} por {organizador}. \n");
            }
        }
}
