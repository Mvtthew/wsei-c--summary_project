//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektZaliczeniowy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int ReservationID { get; set; }
        public int ClientID { get; set; }
        public int ComputerID { get; set; }
        public decimal PriceToPay { get; set; }
        public Nullable<bool> Payed { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Computers Computers { get; set; }
    }
}
