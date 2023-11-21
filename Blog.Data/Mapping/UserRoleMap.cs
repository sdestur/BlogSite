using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mapping
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("25ED1BF9-6053-483C-8E46-BFF2C08428E6"),
                RoleId= Guid.Parse("FCC0843C-9C96-422F-9CD2-50F42D736AF3")
            },
            new AppUserRole 
            {
                UserId= Guid.Parse("64b435ec-32f3-4b23-905a-c927d433fb2a"),
                RoleId= Guid.Parse("4BE6D7AD-8B8D-473E-AFC3-1D92047E88D4")
            });
        }
    }
}
