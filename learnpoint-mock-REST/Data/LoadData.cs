//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using learnpoint_mock_REST.Entities;
//using System.IO;
//using System.Text.Json;

//namespace learnpoint_mock_REST.Data
//{
//    public class LoadData
//    {
//        public static async Task LoadStudents(DataContext context)
//        {
//            if (await context.StudentsApiResponses.AnyAsync()) return;

//            var studentsData = await File.ReadAllTextAsync("Data/jsonStudents.json");
//            var studentsApiResponses = JsonSerializer.Deserialize<List<StudentsApiResponse>>(studentsData);

//            await context.AddRangeAsync(studentsApiResponses);
//            await context.SaveChangesAsync();
//        }
//        public static async Task LoadGroups(DataContext context)
//        {
//            if (await context.GroupsApiResponses.AnyAsync()) return;

//            var groupsData = await File.ReadAllTextAsync("Data/jsonGroups.json");
//            var groupsApiResponses = JsonSerializer.Deserialize<List<GroupsApiResponse>>(groupsData);

//            await context.AddRangeAsync(groupsApiResponses);
//            await context.SaveChangesAsync();
//        }
//        public static async Task LoadStaffMembers(DataContext context)
//        {
//            if (await context.StaffMembersApiResponses.AnyAsync()) return;

//            var staffMembersData = await File.ReadAllTextAsync("Data/jsonStaffMembers.json");
//            var staffMembersApiResponses = JsonSerializer.Deserialize<List<StaffMembersApiResponse>>(staffMembersData);

//            await context.AddRangeAsync(staffMembersApiResponses);
//            await context.SaveChangesAsync();
//        }
//    }
//}

