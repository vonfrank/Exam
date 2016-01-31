namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("akademisklaug_d.ContentVF")]
    public partial class ContentVF
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string pageTitle { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string pageContent { get; set; }

        public int pageLayout { get; set; }

        public int menuOrder { get; set; }

        [StringLength(1073741823)]
        public string pageKeywords { get; set; }

        [StringLength(1073741823)]
        public string pageDescription { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string pageDate { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string pageAuthor { get; set; }
    }
}
