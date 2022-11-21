namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            AdminBases = new HashSet<AdminBas>();
            RecordsBases = new HashSet<RecordsBas>();
        }

        public int Id { get; set; }

        public int NameRoleID { get; set; }

        [Required]
        public string FullName { get; set; }

        public int LoginPasswordID { get; set; }

        public string Photo { get; set; }

        public int? NameRoleIDNavigationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminBas> AdminBases { get; set; }

        public virtual LoginPassword LoginPassword { get; set; }

        public virtual NameOfRole NameOfRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecordsBas> RecordsBases { get; set; }
    }
}
