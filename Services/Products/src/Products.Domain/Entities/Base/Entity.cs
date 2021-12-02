﻿using System;

namespace GeekShopping.Services.Products.Domain.Entities.Base
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
