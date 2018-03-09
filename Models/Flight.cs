namespace DotNetMidtermA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flight
    {
        public int FlightId { get; set; }
         

        public int FlightTypeId { get; set; }

        public int ProvinceId { get; set; }

        public bool ExtraBag { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public virtual FlightType FlightType { get; set; }

        public virtual Province Province { get; set; }
    }
}
