//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreHospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        public int ID_Paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int ID_Tipo_Documento { get; set; }
        public string Documento { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public System.DateTime Fecha__Nacimiento { get; set; }
    }
}
