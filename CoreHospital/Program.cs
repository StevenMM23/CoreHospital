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
                
            };

            hospitalContext.Doctors.Add(d);
            hospitalContext.SaveChanges();

        }
    }
}
