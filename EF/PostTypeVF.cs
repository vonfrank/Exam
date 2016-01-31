namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("akademisklaug_d.PostTypeVF")]
    public partial class PostTypeVF
    {
        public int id { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string postType { get; set; }
    }
}
