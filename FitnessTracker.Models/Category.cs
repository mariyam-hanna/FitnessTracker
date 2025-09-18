using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        public string MuscleGroup { get; set; }
        public int DisplayOrder { get; set; }

        public string ImageUrl { get; set; }
        public List<Workout> Workouts { get; set; }
    }
}
