namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        public int Id { get; set; }

        public int TypeOfServiceID { get; set; }

        [Required]
        public string NameOfService { get; set; }

        public float Price { get; set; }

        public virtual TypeOfService TypeOfService { get; set; }
    }
}
