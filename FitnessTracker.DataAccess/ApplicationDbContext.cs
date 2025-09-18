using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.DataAccess
{
    public class ApplicationDbContext :DbContext  
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,DisplayOrder=1,MuscleGroup="Chest",
                ImageUrl = "/images/chest.jpg"

            }, new Category
            {
                Id = 2,
                DisplayOrder = 2,
                MuscleGroup = "biceps",
                ImageUrl = "/images/biceps.jpg"

            }, new Category
            {
                Id = 3,
                DisplayOrder = 3,
                MuscleGroup = "Tricep",
                ImageUrl = "/images/tricep.jpg"
            }, new Category
            {
                Id = 4,
                DisplayOrder = 4,
                MuscleGroup = "shoulder",
                ImageUrl = "/images/shoulder.jpg"
            }, new Category
            {
                Id = 5,
                DisplayOrder = 5,
                MuscleGroup = "legs",
                ImageUrl = "/images/legs.jpg"
            }, new Category
            {
                Id = 6,
                DisplayOrder = 6,
                MuscleGroup = "Back",
                ImageUrl = "/images/back.jpg"
            }, new Category
            {
                Id = 7,
                DisplayOrder = 7,
                MuscleGroup = "Neck",
                ImageUrl = "/images/neck.jpg"
            }
            );
        }
    }
}
