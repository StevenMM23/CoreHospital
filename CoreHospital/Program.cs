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
                Nombre = "Steven",
                Apellido = "Martinez",
                Cedula = "234234245",
                Direccion = "Caseldiablo",
                Telefono = "8097285852",
                ID_Especialidad = 8,
                Fecha_Nacimiento = DateTime.Parse("2002/05/17")
            };

            hospitalContext.Doctors.Add(d);
            hospitalContext.SaveChanges();

        }
    }
}
