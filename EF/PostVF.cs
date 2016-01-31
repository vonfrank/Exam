namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("akademisklaug_d.PostVF")]
    public partial class PostVF
    {
        public int id { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string postTitle { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string postContent { get; set; }

        public int postType { get; set; }

        [StringLength(1073741823)]
        public string postKeywords { get; set; }

        [StringLength(1073741823)]
        public string postDescription { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string postDate { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string postAuthor { get; set; }
    }
}
