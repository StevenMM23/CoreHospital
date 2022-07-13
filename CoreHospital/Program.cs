using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreHospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hospitalContext = new HOSPITALCOREPFEntities1();
            
            var d = new Doctor()
            { 
                Nombre="Jean",
                Apellido="Gomez",
                Cedula="001205302",
                Direccion = "La fe",
                Telefono ="8498987821",
                ID_Especialidad=2,
                Fecha_Nacimiento= DateTime.Parse("1995/07/12")
            };

            hospitalContext.Doctors.Add(d);
            hospitalContext.SaveChanges();

            var x = new Paciente()
            {
                Nombre = "Ambar",
                Apellido = "Mercedez",
                ID_Tipo_Documento = 1,
                Documento = "4012055021",
                Pais = "Republica Dominicana",
                Ciudad = "Santo Domingo",
                Direccion = "El Millon",
                Telefono = "8094722123",
                Correo = "Ambar@gmail.com",
                Fecha__Nacimiento = DateTime.Parse("2005/06/10")

            };
            hospitalContext.Pacientes.Add(x);
            hospitalContext.SaveChanges();

            var E = new Especialidad()
            {
                ID_Especialidad = 4,
                Nombre_Especialidad = "Pediatria"
            };
            hospitalContext.Especialidads.Add(E);
            hospitalContext.SaveChanges();


            var F = new Factura()
            {
                Descripcion = "Revision",
                Precio = 1500.0,
                ID_MetodoPago = 1,
                Articulo = "Revision Mensual",
                SubTotal = 00.00,
                Total = 1505.0,
                Tax = 5.0,
                Fecha = DateTime.Now,
                PrecioTotal = 1505.0
            };
            hospitalContext.Facturas.Add(F);
            hospitalContext.SaveChanges();

            

        }
    }
}
