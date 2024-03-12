﻿using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; }

        //Migration atarken EntityFramework için gerekli
        public Brand()
        {
        }

        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}
