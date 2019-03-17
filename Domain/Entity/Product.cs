using System;

namespace Domain.Entity
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Category CategoryId { get; set; }
    }
}