﻿using System;
using System.Collections.Generic;

namespace AppAnimals.Models
{
    public partial class AnimalLocation
    {
        public AnimalLocation()
        {
            Animals = new HashSet<Animals>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Animals> Animals { get; set; }
    }
}
