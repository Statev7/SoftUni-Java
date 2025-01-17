﻿namespace Footballers.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        public Team()
        {
            this.TeamsFootballers = new HashSet<TeamFootballer>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(40)]
        public string Nationality  { get; set; }

        public int Trophies  { get; set; }

        public ICollection<TeamFootballer> TeamsFootballers  { get; set; }
    }
}
