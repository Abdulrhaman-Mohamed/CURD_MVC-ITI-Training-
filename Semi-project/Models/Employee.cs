namespace Semi_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string name_ { get; set; }

        public int? age { get; set; }

        [Column(TypeName = "money")]
        public decimal? salary { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        public int? Dept_ID { get; set; }

        public virtual Department Department { get; set; }
    }
}
