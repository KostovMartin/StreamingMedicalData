﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StreamingMedicalData;

#nullable disable

namespace StreamingMedicalData.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230421074248_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StreamingMedicalData.Diagnose", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("OutPatientEGN")
                        .HasColumnType("text");

                    b.Property<string>("Primary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secondary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OutPatientEGN");

                    b.ToTable("Diagnose");
                });

            modelBuilder.Entity("StreamingMedicalData.Epicrisis", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CheckupAfterDischarge")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClinicalExaminations")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complications")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Consultations")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfSurgery")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DischargeStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DiseaseCourse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DoctorsNames")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FairCondition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GPRecommendations")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("History")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OtherDocuments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostoperativeStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Recommendations")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Regimen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SampleProtocol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Epicrisis");
                });

            modelBuilder.Entity("StreamingMedicalData.Out", b =>
                {
                    b.Property<string>("PatientEGN")
                        .HasColumnType("text");

                    b.Property<long>("AgeInDays")
                        .HasColumnType("bigint");

                    b.Property<long>("BedDays")
                        .HasColumnType("bigint");

                    b.Property<long>("BirthNum")
                        .HasColumnType("bigint");

                    b.Property<long>("BirthPractice")
                        .HasColumnType("bigint");

                    b.Property<long>("BirthWeight")
                        .HasColumnType("bigint");

                    b.Property<string>("ClinicalPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Dead")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Delay")
                        .HasColumnType("bigint");

                    b.Property<long>("EndCourse")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("EpicrisisId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ExaminationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("HLDateFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HLNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("HLTotalDays")
                        .HasColumnType("bigint");

                    b.Property<long>("IZNo")
                        .HasColumnType("bigint");

                    b.Property<long>("IZYear")
                        .HasColumnType("bigint");

                    b.Property<double>("InMedicalWard")
                        .HasColumnType("double precision");

                    b.Property<long>("Laparoscopic")
                        .HasColumnType("bigint");

                    b.Property<long>("MotherIZNo")
                        .HasColumnType("bigint");

                    b.Property<long>("MotherIZYear")
                        .HasColumnType("bigint");

                    b.Property<long>("NZOKPay")
                        .HasColumnType("bigint");

                    b.Property<long>("OutAPr")
                        .HasColumnType("bigint");

                    b.Property<string>("OutClinicalPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OutDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("OutMainDiagId")
                        .HasColumnType("bigint");

                    b.Property<double>("OutMedicalWard")
                        .HasColumnType("double precision");

                    b.Property<long>("OutType")
                        .HasColumnType("bigint");

                    b.Property<long>("OutUin")
                        .HasColumnType("bigint");

                    b.Property<long>("PatientBranch")
                        .HasColumnType("bigint");

                    b.Property<string>("PatientEGN1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("PatientHRegion")
                        .HasColumnType("bigint");

                    b.Property<long>("Payer")
                        .HasColumnType("bigint");

                    b.Property<long>("ResignId")
                        .HasColumnType("bigint");

                    b.Property<string>("SendClinicalPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("SendUrgency")
                        .HasColumnType("bigint");

                    b.Property<long>("SenderUin")
                        .HasColumnType("bigint");

                    b.Property<long>("Severity")
                        .HasColumnType("bigint");

                    b.Property<long>("StateAtDischarge")
                        .HasColumnType("bigint");

                    b.Property<long>("Uin")
                        .HasColumnType("bigint");

                    b.Property<long>("Urgency")
                        .HasColumnType("bigint");

                    b.Property<long>("WeightInGrams")
                        .HasColumnType("bigint");

                    b.Property<long>("longype")
                        .HasColumnType("bigint");

                    b.HasKey("PatientEGN");

                    b.HasIndex("EpicrisisId");

                    b.HasIndex("OutMainDiagId");

                    b.HasIndex("PatientEGN1");

                    b.HasIndex("ResignId");

                    b.HasIndex("SenderUin");

                    b.ToTable("OutPatients");
                });

            modelBuilder.Entity("StreamingMedicalData.OutMainDiag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Primary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secondary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OutMainDiag");
                });

            modelBuilder.Entity("StreamingMedicalData.Patient", b =>
                {
                    b.Property<string>("EGN")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Given")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("PersonType")
                        .HasColumnType("bigint");

                    b.Property<long>("Sex")
                        .HasColumnType("bigint");

                    b.Property<string>("Sur")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EGN");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("StreamingMedicalData.Practice", b =>
                {
                    b.Property<long>("No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("No"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Branch")
                        .HasColumnType("bigint");

                    b.Property<long>("HealthRegion")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("No");

                    b.ToTable("Practice");
                });

            modelBuilder.Entity("StreamingMedicalData.Resign", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("OutRefuse")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Resign");
                });

            modelBuilder.Entity("StreamingMedicalData.SendDiagnose", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("OutPatientEGN")
                        .HasColumnType("text");

                    b.Property<string>("Primary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Secondary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OutPatientEGN");

                    b.ToTable("SendDiagnose");
                });

            modelBuilder.Entity("StreamingMedicalData.Sender", b =>
                {
                    b.Property<long>("Uin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Uin"));

                    b.Property<long>("DeputyUin")
                        .HasColumnType("bigint");

                    b.Property<long>("NumNapr")
                        .HasColumnType("bigint");

                    b.Property<long>("PracticeNo")
                        .HasColumnType("bigint");

                    b.Property<long>("Speciality")
                        .HasColumnType("bigint");

                    b.HasKey("Uin");

                    b.HasIndex("PracticeNo");

                    b.ToTable("Sender");
                });

            modelBuilder.Entity("StreamingMedicalData.Diagnose", b =>
                {
                    b.HasOne("StreamingMedicalData.Out", null)
                        .WithMany("Diagnose")
                        .HasForeignKey("OutPatientEGN");
                });

            modelBuilder.Entity("StreamingMedicalData.Out", b =>
                {
                    b.HasOne("StreamingMedicalData.Epicrisis", "Epicrisis")
                        .WithMany()
                        .HasForeignKey("EpicrisisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamingMedicalData.OutMainDiag", "OutMainDiag")
                        .WithMany()
                        .HasForeignKey("OutMainDiagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamingMedicalData.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientEGN1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamingMedicalData.Resign", "Resign")
                        .WithMany()
                        .HasForeignKey("ResignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamingMedicalData.Sender", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderUin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Epicrisis");

                    b.Navigation("OutMainDiag");

                    b.Navigation("Patient");

                    b.Navigation("Resign");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("StreamingMedicalData.SendDiagnose", b =>
                {
                    b.HasOne("StreamingMedicalData.Out", null)
                        .WithMany("SendDiagnose")
                        .HasForeignKey("OutPatientEGN");
                });

            modelBuilder.Entity("StreamingMedicalData.Sender", b =>
                {
                    b.HasOne("StreamingMedicalData.Practice", "Practice")
                        .WithMany()
                        .HasForeignKey("PracticeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Practice");
                });

            modelBuilder.Entity("StreamingMedicalData.Out", b =>
                {
                    b.Navigation("Diagnose");

                    b.Navigation("SendDiagnose");
                });
#pragma warning restore 612, 618
        }
    }
}
