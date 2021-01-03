//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PropertyRentalManagementMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [DisplayName("Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yyyy}")]
        [Required]
        public System.DateTime AppointmentDate { get; set; }

        [DisplayName("Manager Id")]
        [Required]
        public int ManagerId { get; set; }

        [DisplayName("Tenant Name")]
        public int TenantId { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayName("Appointment Time")]
        public System.TimeSpan AppoitmentTime { get; set; }
    
        public virtual Manager Manager { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
