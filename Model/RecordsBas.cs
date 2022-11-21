namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordsBases")]
    public partial class RecordsBas
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfRecord { get; set; }

        public virtual User User { get; set; }
    }
}
