namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminBases")]
    public partial class AdminBas
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        [Required]
        public string UniqKeyAdmin { get; set; }

        public virtual User User { get; set; }
    }
}
