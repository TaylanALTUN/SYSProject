using Microsoft.EntityFrameworkCore;
using SYSProject.Core.Entities.Concrete;
using SYSProject.Core.Utilities.Security.Hashing;
using SYSProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.DataAccess.Concrete.EntityFramework.Contexts
{
    public class SYSInterviewContext : DbContext
    {
        public SYSInterviewContext()
        {

        }
        public SYSInterviewContext(DbContextOptions<SYSInterviewContext> options)
       : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=SELECTTAYLAN\SQLSELECT;Database=SYSInterview;User Id=sa;Password=slc123.;");
           /// optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; DataBase=SYSInterview;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Ürün1",
                SaleUnitPrice = 1000,
                BuyUnitPrice = 700,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
                UpdatedBy = null,
                UpdatedDate = null,
                DeletedBy = null,
                DeletedDate = null
            }, new Product
            {
                Id = 2,
                Name = "Ürün2",
                SaleUnitPrice = 500,
                BuyUnitPrice = 400,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
                UpdatedBy = null,
                UpdatedDate = null,
                DeletedBy = null,
                DeletedDate = null
            },
               new Product
               {
                   Id = 3,
                   Name = "Ürün3",
                   SaleUnitPrice = 7000,
                   BuyUnitPrice = 5000,
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
                   CreatedBy = 1,
                   UpdatedBy = null,
                   UpdatedDate = null,
                   DeletedBy = null,
                   DeletedDate = null
               },
               new Product
               {
                   Id = 4,
                   Name = "Ürün4",
                   SaleUnitPrice = 2800,
                   BuyUnitPrice = 2000,
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
                   CreatedBy = 1,
                   UpdatedBy = null,
                   UpdatedDate = null,
                   DeletedBy = null,
                   DeletedDate = null
               },
               new Product
               {
                   Id = 5,
                   Name = "Ürün5",
                   SaleUnitPrice = 9000,
                   BuyUnitPrice = 6000,
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
                   CreatedBy = 1,
                   UpdatedBy = null,
                   UpdatedDate = null,
                   DeletedBy = null,
                   DeletedDate = null
               });
            #endregion
            #region Users

            byte[] passwordHash, passwordSalt;
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123"));
            }

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                FirstName = "Taylan",
                LastName = "Altun",
                UserName = "Taylan",
                Email = "taylanaltun@gmail.com",
                PasswordSalt = passwordSalt,
                PasswordHash = passwordHash,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                CreatedBy = 1,
                UpdatedBy = null,
                UpdatedDate = null,
                DeletedBy = null,
                DeletedDate = null
            });
            #endregion
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
