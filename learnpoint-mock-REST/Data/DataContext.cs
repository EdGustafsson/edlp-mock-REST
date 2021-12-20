using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using learnpoint_mock_REST.Entities;

namespace learnpoint_mock_REST.Data
{
    public class DataContext : DbContext
    {
        public DbSet<StudentsApiResponse> StudentsApiResponses { get; set; }
        public DbSet<GroupsApiResponse> GroupsApiResponses { get; set; }
        public DbSet<StaffMembersApiResponse> StaffMembersApiResponses { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
