//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiEmpleados.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cargo
    {
        public Cargo()
        {
            this.Empleado = new HashSet<Empleado>();
        }
    
        public int idCargo { get; set; }
        public string nombre { get; set; }
        public decimal salarioBase { get; set; }
    
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}