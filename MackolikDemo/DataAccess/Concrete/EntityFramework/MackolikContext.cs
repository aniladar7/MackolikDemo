﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MackolikContext:DbContext
    {
        public MackolikContext()
        {
            Database.Connection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MackolikDb;Trusted_Connection=True;";
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<ScoreBoard> ScoreBoards { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamStatistic> TeamStatistics  { get; set; }
        public DbSet<Season>  Seasons { get; set; }
        public DbSet<Referee>  Referees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasOptional(s => s.Stadium)
                .WithRequired(st => st.Team); 

            modelBuilder.Entity<Team>()
                .HasRequired<Fixture>(t => t.CurrentFixture)
                .WithMany(f => f.Teams)
                .HasForeignKey<int>(t => t.CurrentFixtureId);

            modelBuilder.Entity<Stadium>()
                .HasRequired<Fixture>(s => s.CurrentFixture)
                .WithMany(f => f.Stadiums)
                .HasForeignKey<int>(s => s.CurrentFixtureId);
            
            modelBuilder.Entity<Team>()
                .HasMany<Season>(t => t.Seasons)
                .WithMany(s => s.Teams)
                .Map(map =>
                { 
                    map.MapLeftKey("TeamId");
                    map.MapRightKey("SeasonId");
                    map.ToTable("TeamSeasons");
                });

            modelBuilder.Entity<Player>().Property(p => p.FirtsName).IsRequired();
            modelBuilder.Entity<Player>().Property(p => p.FirtsName).HasMaxLength(50);
            modelBuilder.Entity<Player>().Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Player>().Property(p => p.LastName).HasMaxLength(50);
            modelBuilder.Entity<Player>().Property(p => p.Country).IsRequired();
            modelBuilder.Entity<Player>().Property(p => p.Country).HasMaxLength(50);
            modelBuilder.Entity<Player>().Property(p => p.Position).IsRequired();
            modelBuilder.Entity<Player>().Property(p => p.Position).HasMaxLength(50);

            modelBuilder.Entity<Referee>().Property(r => r.FirstName).IsRequired();
            modelBuilder.Entity<Referee>().Property(r => r.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Referee>().Property(r => r.LastName).IsRequired();
            modelBuilder.Entity<Referee>().Property(r => r.LastName).HasMaxLength(50);
            modelBuilder.Entity<Referee>().Property(r => r.Country).IsRequired();
            modelBuilder.Entity<Referee>().Property(r => r.Country).HasMaxLength(50);

            modelBuilder.Entity<Stadium>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Stadium>().Property(s => s.Name).HasMaxLength(50);

            modelBuilder.Entity<Team>().Property(t => t.TeamName).IsRequired();
            modelBuilder.Entity<Team>().Property(t => t.TeamName).HasMaxLength(50);


        }
    }
}
