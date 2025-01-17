﻿// <auto-generated />
using System;
using API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20210701215908_FK_UsuarioEnVacante")]
    partial class FK_UsuarioEnVacante
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCategoria")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.HasKey("IdCategoria")
                        .HasName("PK__Categori__8A3D240C67C6A53F");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("API.Models.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdRol")
                        .HasName("PK__Rol__2A49584C867FA551");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("API.Models.Solicitud", b =>
                {
                    b.Property<int>("IdSolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("VacanteId")
                        .HasColumnType("int");

                    b.HasKey("IdSolicitud")
                        .HasName("PK__Solicitu__36899CEFD05F3FF4");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("API.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<decimal?>("Cedula")
                        .HasColumnType("numeric(11,0)");

                    b.Property<string>("Contrasena")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Correo")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<decimal?>("Telefono")
                        .HasColumnType("numeric(15,0)");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__5B65BF97B0B36473");

                    b.HasIndex("IdRol");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("API.Models.Vacante", b =>
                {
                    b.Property<int>("IdVacante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Compania")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Correo")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<DateTimeOffset>("Fecha")
                        .IsUnicode(false)
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Horario")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Posicion")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<decimal?>("Telefono")
                        .HasColumnType("numeric(15,0)");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.HasKey("IdVacante")
                        .HasName("PK__Vacante__A58A8FA8D68A2AD6");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Vacante");
                });

            modelBuilder.Entity("API.Models.Solicitud", b =>
                {
                    b.HasOne("API.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("Solicituds")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK__Solicitud__IdUsu__403A8C7D")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("API.Models.Vacante", "IdVacanteNavigation")
                        .WithMany("Solicituds")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK__Solicitud__IdVac__412EB0B6")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("IdUsuarioNavigation");

                    b.Navigation("IdVacanteNavigation");
                });

            modelBuilder.Entity("API.Models.Usuario", b =>
                {
                    b.HasOne("API.Models.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK__Usuario__IdRol__3A81B327")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("API.Models.Vacante", b =>
                {
                    b.HasOne("API.Models.Categoria", "IdCategoriaNavigation")
                        .WithMany("Vacantes")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK__Vacante__IdCateg__3D5E1FD2")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("API.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("Vacantes")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Vacante__IdUsuar__70DDC3D8")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("API.Models.Categoria", b =>
                {
                    b.Navigation("Vacantes");
                });

            modelBuilder.Entity("API.Models.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("API.Models.Usuario", b =>
                {
                    b.Navigation("Solicituds");

                    b.Navigation("Vacantes");
                });

            modelBuilder.Entity("API.Models.Vacante", b =>
                {
                    b.Navigation("Solicituds");
                });
#pragma warning restore 612, 618
        }
    }
}
