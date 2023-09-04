using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StreamingMedicalData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Epicrisis",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    History = table.Column<string>(type: "text", nullable: false),
                    FairCondition = table.Column<string>(type: "text", nullable: false),
                    ClinicalExaminations = table.Column<string>(type: "text", nullable: false),
                    Consultations = table.Column<string>(type: "text", nullable: false),
                    Regimen = table.Column<string>(type: "text", nullable: false),
                    DiseaseCourse = table.Column<string>(type: "text", nullable: false),
                    Complications = table.Column<string>(type: "text", nullable: false),
                    DateOfSurgery = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SampleProtocol = table.Column<string>(type: "text", nullable: false),
                    PostoperativeStatus = table.Column<string>(type: "text", nullable: false),
                    DischargeStatus = table.Column<string>(type: "text", nullable: false),
                    Recommendations = table.Column<string>(type: "text", nullable: false),
                    CheckupAfterDischarge = table.Column<string>(type: "text", nullable: false),
                    GPRecommendations = table.Column<string>(type: "text", nullable: false),
                    OtherDocuments = table.Column<string>(type: "text", nullable: false),
                    DoctorsNames = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epicrisis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutMainDiag",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Primary = table.Column<string>(type: "text", nullable: false),
                    Secondary = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutMainDiag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    EGN = table.Column<string>(type: "text", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sex = table.Column<long>(type: "bigint", nullable: false),
                    Given = table.Column<string>(type: "text", nullable: false),
                    Sur = table.Column<string>(type: "text", nullable: false),
                    Family = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    PersonType = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.EGN);
                });

            migrationBuilder.CreateTable(
                name: "Practice",
                columns: table => new
                {
                    No = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Branch = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HealthRegion = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practice", x => x.No);
                });

            migrationBuilder.CreateTable(
                name: "Resign",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OutRefuse = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sender",
                columns: table => new
                {
                    Uin = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PracticeNo = table.Column<long>(type: "bigint", nullable: false),
                    Speciality = table.Column<long>(type: "bigint", nullable: false),
                    NumNapr = table.Column<long>(type: "bigint", nullable: false),
                    DeputyUin = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sender", x => x.Uin);
                    table.ForeignKey(
                        name: "FK_Sender_Practice_PracticeNo",
                        column: x => x.PracticeNo,
                        principalTable: "Practice",
                        principalColumn: "No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutPatients",
                columns: table => new
                {
                    PatientEGN = table.Column<string>(type: "text", nullable: false),
                    SendUrgency = table.Column<long>(type: "bigint", nullable: false),
                    SendClinicalPath = table.Column<string>(type: "text", nullable: false),
                    Uin = table.Column<long>(type: "bigint", nullable: false),
                    ExaminationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Urgency = table.Column<long>(type: "bigint", nullable: false),
                    ClinicalPath = table.Column<string>(type: "text", nullable: false),
                    NZOKPay = table.Column<long>(type: "bigint", nullable: false),
                    InMedicalWard = table.Column<double>(type: "double precision", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Severity = table.Column<long>(type: "bigint", nullable: false),
                    Delay = table.Column<long>(type: "bigint", nullable: false),
                    Payer = table.Column<long>(type: "bigint", nullable: false),
                    IZYear = table.Column<long>(type: "bigint", nullable: false),
                    IZNo = table.Column<long>(type: "bigint", nullable: false),
                    OutMedicalWard = table.Column<double>(type: "double precision", nullable: false),
                    OutUin = table.Column<long>(type: "bigint", nullable: false),
                    OutDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OutType = table.Column<long>(type: "bigint", nullable: false),
                    OutClinicalPath = table.Column<string>(type: "text", nullable: false),
                    EpicrisisId = table.Column<long>(type: "bigint", nullable: false),
                    OutMainDiagId = table.Column<long>(type: "bigint", nullable: false),
                    BedDays = table.Column<long>(type: "bigint", nullable: false),
                    StateAtDischarge = table.Column<long>(type: "bigint", nullable: false),
                    Laparoscopic = table.Column<long>(type: "bigint", nullable: false),
                    EndCourse = table.Column<long>(type: "bigint", nullable: false),
                    PatientEGN1 = table.Column<string>(type: "text", nullable: false),
                    PatientBranch = table.Column<long>(type: "bigint", nullable: false),
                    PatientHRegion = table.Column<long>(type: "bigint", nullable: false),
                    longype = table.Column<long>(type: "bigint", nullable: false),
                    SenderUin = table.Column<long>(type: "bigint", nullable: false),
                    SendDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HLDateFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HLNo = table.Column<string>(type: "text", nullable: false),
                    HLTotalDays = table.Column<long>(type: "bigint", nullable: false),
                    AgeInDays = table.Column<long>(type: "bigint", nullable: false),
                    WeightInGrams = table.Column<long>(type: "bigint", nullable: false),
                    BirthPractice = table.Column<long>(type: "bigint", nullable: false),
                    BirthNum = table.Column<long>(type: "bigint", nullable: false),
                    ResignId = table.Column<long>(type: "bigint", nullable: false),
                    BirthWeight = table.Column<long>(type: "bigint", nullable: false),
                    MotherIZYear = table.Column<long>(type: "bigint", nullable: false),
                    MotherIZNo = table.Column<long>(type: "bigint", nullable: false),
                    OutAPr = table.Column<long>(type: "bigint", nullable: false),
                    Dead = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutPatients", x => x.PatientEGN);
                    table.ForeignKey(
                        name: "FK_OutPatients_Epicrisis_EpicrisisId",
                        column: x => x.EpicrisisId,
                        principalTable: "Epicrisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutPatients_OutMainDiag_OutMainDiagId",
                        column: x => x.OutMainDiagId,
                        principalTable: "OutMainDiag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutPatients_Patient_PatientEGN1",
                        column: x => x.PatientEGN1,
                        principalTable: "Patient",
                        principalColumn: "EGN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutPatients_Resign_ResignId",
                        column: x => x.ResignId,
                        principalTable: "Resign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutPatients_Sender_SenderUin",
                        column: x => x.SenderUin,
                        principalTable: "Sender",
                        principalColumn: "Uin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnose",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Primary = table.Column<string>(type: "text", nullable: false),
                    Secondary = table.Column<string>(type: "text", nullable: false),
                    OutPatientEGN = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnose", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnose_OutPatients_OutPatientEGN",
                        column: x => x.OutPatientEGN,
                        principalTable: "OutPatients",
                        principalColumn: "PatientEGN");
                });

            migrationBuilder.CreateTable(
                name: "SendDiagnose",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Primary = table.Column<string>(type: "text", nullable: false),
                    Secondary = table.Column<string>(type: "text", nullable: false),
                    OutPatientEGN = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendDiagnose", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SendDiagnose_OutPatients_OutPatientEGN",
                        column: x => x.OutPatientEGN,
                        principalTable: "OutPatients",
                        principalColumn: "PatientEGN");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnose_OutPatientEGN",
                table: "Diagnose",
                column: "OutPatientEGN");

            migrationBuilder.CreateIndex(
                name: "IX_OutPatients_EpicrisisId",
                table: "OutPatients",
                column: "EpicrisisId");

            migrationBuilder.CreateIndex(
                name: "IX_OutPatients_OutMainDiagId",
                table: "OutPatients",
                column: "OutMainDiagId");

            migrationBuilder.CreateIndex(
                name: "IX_OutPatients_PatientEGN1",
                table: "OutPatients",
                column: "PatientEGN1");

            migrationBuilder.CreateIndex(
                name: "IX_OutPatients_ResignId",
                table: "OutPatients",
                column: "ResignId");

            migrationBuilder.CreateIndex(
                name: "IX_OutPatients_SenderUin",
                table: "OutPatients",
                column: "SenderUin");

            migrationBuilder.CreateIndex(
                name: "IX_SendDiagnose_OutPatientEGN",
                table: "SendDiagnose",
                column: "OutPatientEGN");

            migrationBuilder.CreateIndex(
                name: "IX_Sender_PracticeNo",
                table: "Sender",
                column: "PracticeNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnose");

            migrationBuilder.DropTable(
                name: "SendDiagnose");

            migrationBuilder.DropTable(
                name: "OutPatients");

            migrationBuilder.DropTable(
                name: "Epicrisis");

            migrationBuilder.DropTable(
                name: "OutMainDiag");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Resign");

            migrationBuilder.DropTable(
                name: "Sender");

            migrationBuilder.DropTable(
                name: "Practice");
        }
    }
}
