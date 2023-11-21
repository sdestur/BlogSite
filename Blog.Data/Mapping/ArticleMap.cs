using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Blog.Data.Mapping
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt.",
                ViewCount = 15,
                CategoryId = Guid.Parse("78EFDD72-2F3D-4BD5-8EC6-2234C0C5E01B"),
                ImageId = Guid.Parse("F71F4B9A-AA69-461D-B398-DE31001BF214"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId= Guid.Parse("25ED1BF9-6053-483C-8E46-BFF2C08428E6")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt.",
                ViewCount = 15,
                CategoryId = Guid.Parse("EFDDDBDE-76A6-4EED-88FF-0A4A61AD7AE3"),
                ImageId = Guid.Parse("D30EE921-C884-4719-8C0A-A93147B3A463"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId=
                Guid.Parse("64b435ec-32f3-4b23-905a-c927d433fb2a")
            });
        }
    }
}
