﻿using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Data.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace Data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
        // Property used for soft deleting users
        public bool IsDeleted { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}