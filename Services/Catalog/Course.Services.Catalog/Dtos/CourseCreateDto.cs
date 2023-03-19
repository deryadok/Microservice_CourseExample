﻿using Course.Services.Catalog.Model;

namespace Course.Services.Catalog.Dtos
{
    internal class CourseCreateDto
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public string UserId { get; set; }

        public FeatureDto Feature { get; set; }

        public string CategoryId { get; set; }
    }
}