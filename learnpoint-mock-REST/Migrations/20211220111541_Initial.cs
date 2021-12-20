using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace learnpoint_mock_REST.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiError",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiError", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseDefinitionReference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDefinitionReference", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationPlanType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationPlanType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupCategory",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCategory", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "GroupReference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupReference", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupsReferenceData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsReferenceData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffMemberReference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMemberReference", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffMembersReferenceData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMembersReferenceData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentEducationPlanState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveStudent = table.Column<bool>(type: "bit", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEducationPlanState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentHomeAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentHomeAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentReference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentReference", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsReferenceData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsReferenceData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParentGroupReference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    ParentGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentGroupReference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentGroupReference_GroupReference_GroupId",
                        column: x => x.GroupId,
                        principalTable: "GroupReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentGroupReference_ParentGroupReference_ParentGroupId",
                        column: x => x.ParentGroupId,
                        principalTable: "ParentGroupReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInternship = table.Column<bool>(type: "bit", nullable: false),
                    GroupsReferenceDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDefinition_GroupsReferenceData_GroupsReferenceDataId",
                        column: x => x.GroupsReferenceDataId,
                        principalTable: "GroupsReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupsData_GroupsReferenceData_ReferenceDataId",
                        column: x => x.ReferenceDataId,
                        principalTable: "GroupsReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupsReferenceDataId = table.Column<int>(type: "int", nullable: true),
                    StaffMembersReferenceDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupRole_GroupsReferenceData_GroupsReferenceDataId",
                        column: x => x.GroupsReferenceDataId,
                        principalTable: "GroupsReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupRole_StaffMembersReferenceData_StaffMembersReferenceDataId",
                        column: x => x.StaffMembersReferenceDataId,
                        principalTable: "StaffMembersReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffMembersData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMembersData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffMembersData_StaffMembersReferenceData_ReferenceDataId",
                        column: x => x.ReferenceDataId,
                        principalTable: "StaffMembersReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsData_StudentsReferenceData_ReferenceDataId",
                        column: x => x.ReferenceDataId,
                        principalTable: "StudentsReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LifespanFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LifespanUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ParentGroupId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffMembersReferenceDataId = table.Column<int>(type: "int", nullable: true),
                    StudentsReferenceDataId = table.Column<int>(type: "int", nullable: true),
                    CourseDefinitionId = table.Column<int>(type: "int", nullable: true),
                    GroupsDataId = table.Column<int>(type: "int", nullable: true),
                    GroupsDataId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_CourseDefinitionReference_CourseDefinitionId",
                        column: x => x.CourseDefinitionId,
                        principalTable: "CourseDefinitionReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_GroupCategory_CategoryName",
                        column: x => x.CategoryName,
                        principalTable: "GroupCategory",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_GroupsData_GroupsDataId",
                        column: x => x.GroupsDataId,
                        principalTable: "GroupsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_GroupsData_GroupsDataId1",
                        column: x => x.GroupsDataId1,
                        principalTable: "GroupsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_ParentGroupReference_ParentGroupId",
                        column: x => x.ParentGroupId,
                        principalTable: "ParentGroupReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_StaffMembersReferenceData_StaffMembersReferenceDataId",
                        column: x => x.StaffMembersReferenceDataId,
                        principalTable: "StaffMembersReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_StudentsReferenceData_StudentsReferenceDataId",
                        column: x => x.StudentsReferenceDataId,
                        principalTable: "StudentsReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupsApiResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataId = table.Column<int>(type: "int", nullable: true),
                    ErrorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsApiResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupsApiResponses_ApiError_ErrorId",
                        column: x => x.ErrorId,
                        principalTable: "ApiError",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupsApiResponses_GroupsData_DataId",
                        column: x => x.DataId,
                        principalTable: "GroupsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MayExposeMobilePhoneToStudents = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupsReferenceDataId = table.Column<int>(type: "int", nullable: true),
                    StaffMembersDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffMember_GroupsReferenceData_GroupsReferenceDataId",
                        column: x => x.GroupsReferenceDataId,
                        principalTable: "GroupsReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffMember_StaffMembersData_StaffMembersDataId",
                        column: x => x.StaffMembersDataId,
                        principalTable: "StaffMembersData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffMembersApiResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataId = table.Column<int>(type: "int", nullable: true),
                    ErrorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMembersApiResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffMembersApiResponses_ApiError_ErrorId",
                        column: x => x.ErrorId,
                        principalTable: "ApiError",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffMembersApiResponses_StaffMembersData_DataId",
                        column: x => x.DataId,
                        principalTable: "StaffMembersData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressId = table.Column<int>(type: "int", nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupsReferenceDataId = table.Column<int>(type: "int", nullable: true),
                    StudentsDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_GroupsReferenceData_GroupsReferenceDataId",
                        column: x => x.GroupsReferenceDataId,
                        principalTable: "GroupsReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_StudentHomeAddress_HomeAddressId",
                        column: x => x.HomeAddressId,
                        principalTable: "StudentHomeAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_StudentsData_StudentsDataId",
                        column: x => x.StudentsDataId,
                        principalTable: "StudentsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsApiResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataId = table.Column<int>(type: "int", nullable: true),
                    ErrorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsApiResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsApiResponses_ApiError_ErrorId",
                        column: x => x.ErrorId,
                        principalTable: "ApiError",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsApiResponses_StudentsData_DataId",
                        column: x => x.DataId,
                        principalTable: "StudentsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupStaffMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffMemberId = table.Column<int>(type: "int", nullable: true),
                    IsGroupManager = table.Column<bool>(type: "bit", nullable: false),
                    FullGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStaffMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupStaffMember_Group_FullGroupId",
                        column: x => x.FullGroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupStaffMember_StaffMemberReference_StaffMemberId",
                        column: x => x.StaffMemberId,
                        principalTable: "StaffMemberReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupStudent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    FullGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupStudent_Group_FullGroupId",
                        column: x => x.FullGroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupStudent_StudentReference_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffMemberGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    IsGroupManager = table.Column<bool>(type: "bit", nullable: false),
                    FullStaffMemberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMemberGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffMemberGroup_GroupReference_GroupId",
                        column: x => x.GroupId,
                        principalTable: "GroupReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffMemberGroup_StaffMember_FullStaffMemberId",
                        column: x => x.FullStaffMemberId,
                        principalTable: "StaffMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentEducationPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    FullStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEducationPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentEducationPlan_Student_FullStudentId",
                        column: x => x.FullStudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentEducationPlan_StudentEducationPlanState_StateId",
                        column: x => x.StateId,
                        principalTable: "StudentEducationPlanState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    FullStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentGroup_GroupReference_GroupId",
                        column: x => x.GroupId,
                        principalTable: "GroupReference",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentGroup_Student_FullStudentId",
                        column: x => x.FullStudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationPlan",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    StudentEducationPlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationPlan", x => x.Code);
                    table.ForeignKey(
                        name: "FK_EducationPlan_EducationPlanType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "EducationPlanType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationPlan_StudentEducationPlan_StudentEducationPlanId",
                        column: x => x.StudentEducationPlanId,
                        principalTable: "StudentEducationPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupRoleReference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupStaffMemberId = table.Column<int>(type: "int", nullable: true),
                    GroupStudentId = table.Column<int>(type: "int", nullable: true),
                    StaffMemberGroupId = table.Column<int>(type: "int", nullable: true),
                    StudentGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRoleReference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupRoleReference_GroupStaffMember_GroupStaffMemberId",
                        column: x => x.GroupStaffMemberId,
                        principalTable: "GroupStaffMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupRoleReference_GroupStudent_GroupStudentId",
                        column: x => x.GroupStudentId,
                        principalTable: "GroupStudent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupRoleReference_StaffMemberGroup_StaffMemberGroupId",
                        column: x => x.StaffMemberGroupId,
                        principalTable: "StaffMemberGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupRoleReference_StudentGroup_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseDefinition_GroupsReferenceDataId",
                table: "CourseDefinition",
                column: "GroupsReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationPlan_StudentEducationPlanId",
                table: "EducationPlan",
                column: "StudentEducationPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationPlan_TypeId",
                table: "EducationPlan",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_CategoryName",
                table: "Group",
                column: "CategoryName");

            migrationBuilder.CreateIndex(
                name: "IX_Group_CourseDefinitionId",
                table: "Group",
                column: "CourseDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_GroupsDataId",
                table: "Group",
                column: "GroupsDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_GroupsDataId1",
                table: "Group",
                column: "GroupsDataId1");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ParentGroupId",
                table: "Group",
                column: "ParentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_StaffMembersReferenceDataId",
                table: "Group",
                column: "StaffMembersReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_StudentsReferenceDataId",
                table: "Group",
                column: "StudentsReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRole_GroupsReferenceDataId",
                table: "GroupRole",
                column: "GroupsReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRole_StaffMembersReferenceDataId",
                table: "GroupRole",
                column: "StaffMembersReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoleReference_GroupStaffMemberId",
                table: "GroupRoleReference",
                column: "GroupStaffMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoleReference_GroupStudentId",
                table: "GroupRoleReference",
                column: "GroupStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoleReference_StaffMemberGroupId",
                table: "GroupRoleReference",
                column: "StaffMemberGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoleReference_StudentGroupId",
                table: "GroupRoleReference",
                column: "StudentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsApiResponses_DataId",
                table: "GroupsApiResponses",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsApiResponses_ErrorId",
                table: "GroupsApiResponses",
                column: "ErrorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsData_ReferenceDataId",
                table: "GroupsData",
                column: "ReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStaffMember_FullGroupId",
                table: "GroupStaffMember",
                column: "FullGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStaffMember_StaffMemberId",
                table: "GroupStaffMember",
                column: "StaffMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudent_FullGroupId",
                table: "GroupStudent",
                column: "FullGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudent_StudentId",
                table: "GroupStudent",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentGroupReference_GroupId",
                table: "ParentGroupReference",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentGroupReference_ParentGroupId",
                table: "ParentGroupReference",
                column: "ParentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMember_GroupsReferenceDataId",
                table: "StaffMember",
                column: "GroupsReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMember_StaffMembersDataId",
                table: "StaffMember",
                column: "StaffMembersDataId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMemberGroup_FullStaffMemberId",
                table: "StaffMemberGroup",
                column: "FullStaffMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMemberGroup_GroupId",
                table: "StaffMemberGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMembersApiResponses_DataId",
                table: "StaffMembersApiResponses",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMembersApiResponses_ErrorId",
                table: "StaffMembersApiResponses",
                column: "ErrorId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMembersData_ReferenceDataId",
                table: "StaffMembersData",
                column: "ReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupsReferenceDataId",
                table: "Student",
                column: "GroupsReferenceDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_HomeAddressId",
                table: "Student",
                column: "HomeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentsDataId",
                table: "Student",
                column: "StudentsDataId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEducationPlan_FullStudentId",
                table: "StudentEducationPlan",
                column: "FullStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEducationPlan_StateId",
                table: "StudentEducationPlan",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroup_FullStudentId",
                table: "StudentGroup",
                column: "FullStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroup_GroupId",
                table: "StudentGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsApiResponses_DataId",
                table: "StudentsApiResponses",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsApiResponses_ErrorId",
                table: "StudentsApiResponses",
                column: "ErrorId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsData_ReferenceDataId",
                table: "StudentsData",
                column: "ReferenceDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDefinition");

            migrationBuilder.DropTable(
                name: "EducationPlan");

            migrationBuilder.DropTable(
                name: "GroupRole");

            migrationBuilder.DropTable(
                name: "GroupRoleReference");

            migrationBuilder.DropTable(
                name: "GroupsApiResponses");

            migrationBuilder.DropTable(
                name: "StaffMembersApiResponses");

            migrationBuilder.DropTable(
                name: "StudentsApiResponses");

            migrationBuilder.DropTable(
                name: "EducationPlanType");

            migrationBuilder.DropTable(
                name: "StudentEducationPlan");

            migrationBuilder.DropTable(
                name: "GroupStaffMember");

            migrationBuilder.DropTable(
                name: "GroupStudent");

            migrationBuilder.DropTable(
                name: "StaffMemberGroup");

            migrationBuilder.DropTable(
                name: "StudentGroup");

            migrationBuilder.DropTable(
                name: "ApiError");

            migrationBuilder.DropTable(
                name: "StudentEducationPlanState");

            migrationBuilder.DropTable(
                name: "StaffMemberReference");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "StudentReference");

            migrationBuilder.DropTable(
                name: "StaffMember");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "CourseDefinitionReference");

            migrationBuilder.DropTable(
                name: "GroupCategory");

            migrationBuilder.DropTable(
                name: "GroupsData");

            migrationBuilder.DropTable(
                name: "ParentGroupReference");

            migrationBuilder.DropTable(
                name: "StaffMembersData");

            migrationBuilder.DropTable(
                name: "StudentHomeAddress");

            migrationBuilder.DropTable(
                name: "StudentsData");

            migrationBuilder.DropTable(
                name: "GroupsReferenceData");

            migrationBuilder.DropTable(
                name: "GroupReference");

            migrationBuilder.DropTable(
                name: "StaffMembersReferenceData");

            migrationBuilder.DropTable(
                name: "StudentsReferenceData");
        }
    }
}
