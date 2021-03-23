using Data.Configurations;
using Data.Entities;
using Data.Enum;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    //dotnet ef --startup-project.\PizzonApi\PizzonApi.csproj migrations add ProductSchema -p.\Data\Data.csproj
    //dotnet ef --startup-project.\PizzonApi\PizzonApi.csproj database update -p.\Data\Data.csproj
    //dotnet ef migrations add addedTableName -s solutionName -p projectName
    //dotnet ef migrations add gdfg -s .\PizzonApi\PizzonApi.csproj -p.\Data\Data.csproj
    //dotnet ef database update -s .\PizzonApi\PizzonApi.csproj -p.\Data\Data.csproj
    public class PizzonDbContext: DbContext
    {
        public PizzonDbContext(DbContextOptions<PizzonDbContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
   

            builder.ApplyConfiguration(new AboutUsConfiguration());
            builder.ApplyConfiguration(new BannerConfiguration());
            builder.ApplyConfiguration(new BreadcrumbConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new AssociateConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new Categoryfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new SettingConfiguration());
            builder.ApplyConfiguration(new SocialLinkConfiguration());
            builder.ApplyConfiguration(new TestimonialConfiguration());
            builder.ApplyConfiguration(new StockConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ProductPhotoConfiguration());

            base.OnModelCreating(builder);


            //   builder.Entity<Banner>().HasData(
            //   #region Banner/isBanner
            // new Banner
            // {
            //     Id = 2,
            //     PhotoUrl = "banner-bg-1.png",
            //     IsBanner = true,
            //     IsService = false,
            //     Header = "Quality Foods",
            //     Body = "Healthy Food for healthy body",
            //     AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //     ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //     AddedBy = "System",
            //     ModifiedBy = "System"
            // },
            //       new Banner
            //       {
            //           Id = 3,
            //           PhotoUrl = "banner-bg-2.png",
            //           IsBanner = true,
            //           IsService = false,
            //           Header = "Quality Foods",
            //           Body = "Healthy Food for healthy body",
            //           AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           AddedBy = "System",
            //           ModifiedBy = "System"

            //       },
            //       new Banner
            //       {
            //           Id = 4,
            //           PhotoUrl = "banner-bg-3.png",
            //           IsBanner = true,
            //           IsService = false,
            //           Header = "Quality Foods",
            //           Body = "Healthy Food for healthy body",
            //           AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           AddedBy = "System",
            //           ModifiedBy = "System"

            //       },
            //   #endregion

            //   #region Banner/isService
            //new Banner
            //{
            //    Id = 5,
            //    PhotoUrl = "order-1.svg",
            //    IsBanner = false,
            //    IsService = true,
            //    Header = "ORDER YOUR FOOD",
            //    Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            //                  "sed do eius-Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            //                  "sed do eius-Lorem ipsum dolor sit amet, conse",
            //    AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    AddedBy = "System",
            //    ModifiedBy = "System"

            //},
            //       new Banner
            //       {
            //           Id = 6,
            //           PhotoUrl = "order-2.svg",
            //           IsBanner = false,
            //           IsService = true,
            //           Header = "DELIVERY OR PICK UP",
            //           Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            //                  "sed do eius-Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            //                  "sed do eius-Lorem ipsum dolor sit amet, conse",
            //           AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           AddedBy = "System",
            //           ModifiedBy = "System"

            //       },
            //       new Banner
            //       {
            //           Id = 7,
            //           PhotoUrl = "order-3.svg",
            //           IsBanner = false,
            //           IsService = true,
            //           Header = "DELICIOUS RECEIPE",
            //           Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            //                  "sed do eius-Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
            //                  "sed do eius-Lorem ipsum dolor sit amet, conse",
            //           AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           AddedBy = "System",
            //           ModifiedBy = "System"

            //       } 
            //       #endregion
            //       );
            //   builder.Entity<Product>().HasData(
            //   #region Product/isPromo
            //               new Product
            //               {
            //                   Id = 2,
            //                   Name = "Mexican Green Wave",
            //                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
            //                         "incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam , quis " +
            //                         "nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            //                         "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore " +
            //                         "eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident,   " +
            //                         "sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //                   Detail = "pizza for promo",
            //                   Size = ProductSize.Small,
            //                   ProductType = "Pizza",
            //                   IsPromo = true,
            //                   OrderBy = 1,
            //                   CategoryId = 1,
            //                   PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1613554071/speciality-1.jpg",
            //                   AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //                   ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //                   AddedBy = "System",
            //                   ModifiedBy = "System"

            //               },
            //       new Product
            //       {
            //           Id = 11,
            //           Name = "Double Cheese Pizza",
            //           Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
            //                         "incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam , quis " +
            //                         "nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            //                         "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore " +
            //                         "eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident,   " +
            //                         "sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //           Detail = "pizza for promo",
            //           Size = ProductSize.Medium,
            //           ProductType = "Pizza",
            //           IsPromo = true,
            //           OrderBy = 1,
            //           CategoryId = 1,
            //           PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1613554071/speciality-2.jpg",
            //           AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           AddedBy = "System",
            //           ModifiedBy = "System"

            //       },
            //       new Product
            //       {
            //           Id = 12,
            //           Name = "Margherita pizza",
            //           Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
            //                         "incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam , quis " +
            //                         "nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            //                         "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore " +
            //                         "eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident,   " +
            //                         "sunt in culpa qui officia deserunt mollit anim id est laborum.",
            //           Detail = "pizza for promo",
            //           Size = ProductSize.Large,
            //           ProductType = "Pizza",
            //           IsPromo = true,
            //           OrderBy = 1,
            //           CategoryId = 1,
            //           PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1613554071/speciality-3.jpg",
            //           AddedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           ModifiedDate = DateTime.ParseExact("17/06/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //           AddedBy = "System",
            //           ModifiedBy = "System"
            //       } 
            //       #endregion
            //       );

            #region Chefs
            //    builder.Entity<Associate>().HasData(

            //new Associate()
            //{
            //    Name = "Ilkin Nazar",
            //    AddedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    ModifiedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    AddedBy = "System",
            //    ModifiedBy = "System",
            //    Id = 45,
            //    PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1614938772/chef-2.jpg",
            //    Position = "Sous Chef"
            //},
            //new Associate()
            //{
            //    Name = "Ilkin Nazar",
            //    AddedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    ModifiedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    AddedBy = "System",
            //    ModifiedBy = "System",
            //    Id = 42,
            //    PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1614938772/chef-2.jpg",
            //    Position = "Sous Chef"
            //},
            //new Associate()
            //{
            //    Name = "Ilkin Nazar",
            //    AddedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    ModifiedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    AddedBy = "System",
            //    ModifiedBy = "System",
            //    Id = 48,
            //    PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1614938772/chef-2.jpg",
            //    Position = "Sous Chef"
            //},
            //new Associate()
            //{
            //    Name = "Ilkin Nazar",
            //    Id = 40,
            //    PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1614938772/chef-2.jpg",
            //    Position = "Sous Chef"
            //    AddedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    ModifiedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
            //    AddedBy = "System",
            //    ModifiedBy = "System",
            //}
            //); 
            #endregion
            #region NewsBlog
        //    builder.Entity<Blog>().HasData(
        //new Blog()
        //{
        //    Name = "1Possession so comparison inquietude he conviction ",
        //    Author = "john doe",
        //    Id = 3,
        //    Tag = "",
        //    IsNew = true,
        //    OrderBy = 2,
        //    PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1614938772/chef-2.jpg",
        //    Text = "",
        //    AddedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
        //    ModifiedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
        //    AddedBy = "System",
        //    ModifiedBy = "System",
        //},
        //new Blog()
        //{
        //    Name = "1Possession so comparison inquietude he conviction ",
        //    Author = "john doe",
        //    Id = 4,
        //    Tag = "",
        //    IsNew = true,
        //    OrderBy = 7,
        //    PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1614938772/chef-2.jpg",
        //    Text = "",
        //    AddedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
        //    ModifiedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
        //    AddedBy = "System",
        //    ModifiedBy = "System",
        //},
        //new Blog()
        //{
        //    Name = "1Possession so comparison inquietude he conviction ",
        //    Author = "john doe",
        //    Id = 9,
        //    Tag = "",
        //    IsNew = true,
        //    OrderBy = 5,
        //    PhotoUrl = "https://res.cloudinary.com/dt3uqlzmf/image/upload/v1614938772/chef-2.jpg",
        //    Text = "",
        //    AddedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
        //    ModifiedDate = DateTime.ParseExact("23/03/2021 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
        //    AddedBy = "System",
        //    ModifiedBy = "System",
        //}
        //);
            #endregion
        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Breadcrumb> Breadcrumbs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Associate> Associates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
    }

}

