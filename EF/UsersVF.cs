namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("akademisklaug_d.UsersVF")]
    public partial class UsersVF
    {
        public int id { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string userName { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string userPassword { get; set; }

        public int userRights { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string userFirstname { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string userSurname { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string userOccupation { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string userDescription { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string userSecretDescription { get; set; }
    }
}
