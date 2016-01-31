namespace EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<ContentVF> ContentVF { get; set; }
        public virtual DbSet<PostTypeVF> PostTypeVF { get; set; }
        public virtual DbSet<PostVF> PostVF { get; set; }
        public virtual DbSet<UsersVF> UsersVF { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentVF>()
                .Property(e => e.pageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ContentVF>()
                .Property(e => e.pageContent)
                .IsUnicode(false);

            modelBuilder.Entity<ContentVF>()
                .Property(e => e.pageKeywords)
                .IsUnicode(false);

            modelBuilder.Entity<ContentVF>()
                .Property(e => e.pageDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ContentVF>()
                .Property(e => e.pageDate)
                .IsUnicode(false);

            modelBuilder.Entity<ContentVF>()
                .Property(e => e.pageAuthor)
                .IsUnicode(false);

            modelBuilder.Entity<PostTypeVF>()
                .Property(e => e.postType)
                .IsUnicode(false);

            modelBuilder.Entity<PostVF>()
                .Property(e => e.postTitle)
                .IsUnicode(false);

            modelBuilder.Entity<PostVF>()
                .Property(e => e.postContent)
                .IsUnicode(false);

            modelBuilder.Entity<PostVF>()
                .Property(e => e.postKeywords)
                .IsUnicode(false);

            modelBuilder.Entity<PostVF>()
                .Property(e => e.postDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PostVF>()
                .Property(e => e.postDate)
                .IsUnicode(false);

            modelBuilder.Entity<PostVF>()
                .Property(e => e.postAuthor)
                .IsUnicode(false);

            modelBuilder.Entity<UsersVF>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<UsersVF>()
                .Property(e => e.userPassword)
                .IsUnicode(false);

            modelBuilder.Entity<UsersVF>()
                .Property(e => e.userFirstname)
                .IsUnicode(false);

            modelBuilder.Entity<UsersVF>()
                .Property(e => e.userSurname)
                .IsUnicode(false);

            modelBuilder.Entity<UsersVF>()
                .Property(e => e.userOccupation)
                .IsUnicode(false);

            modelBuilder.Entity<UsersVF>()
                .Property(e => e.userDescription)
                .IsUnicode(false);

            modelBuilder.Entity<UsersVF>()
                .Property(e => e.userSecretDescription)
                .IsUnicode(false);
        }
    }
}
