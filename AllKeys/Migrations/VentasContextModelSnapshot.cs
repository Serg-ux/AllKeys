﻿// <auto-generated />
using AllKeys.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AllKeys.Migrations
{
    [DbContext(typeof(VentasContext))]
    partial class VentasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AllKeys.Modelo.Copia", b =>
                {
                    b.Property<int>("CopiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CopiaCod")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("UsuarioRegistradoId")
                        .HasColumnType("int");

                    b.Property<int>("VideojuegoId")
                        .HasColumnType("int");

                    b.HasKey("CopiaId");

                    b.HasIndex("UsuarioRegistradoId");

                    b.HasIndex("VideojuegoId");

                    b.ToTable("Copias");
                });

            modelBuilder.Entity("AllKeys.Modelo.Descuento", b =>
                {
                    b.Property<int>("DescuentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescuentoCod")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("DescuentoId");

                    b.ToTable("Descuentos");
                });

            modelBuilder.Entity("AllKeys.Modelo.ObtenerDescuento", b =>
                {
                    b.Property<int>("ObtenerDescuentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DescuentoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioRegistradoId")
                        .HasColumnType("int");

                    b.HasKey("ObtenerDescuentoId");

                    b.HasIndex("DescuentoId");

                    b.HasIndex("UsuarioRegistradoId");

                    b.ToTable("ObtenerDescuento");
                });

            modelBuilder.Entity("AllKeys.Modelo.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RolNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("RolId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RolId = 1,
                            RolNombre = "Admin"
                        },
                        new
                        {
                            RolId = 2,
                            RolNombre = "Usuario"
                        },
                        new
                        {
                            RolId = 3,
                            RolNombre = "Premium"
                        });
                });

            modelBuilder.Entity("AllKeys.Modelo.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioColor_Fav")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioContra")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioCorreo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("UsuarioTlf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            RolId = 1,
                            UsuarioColor_Fav = "amarillo",
                            UsuarioContra = "abc123.",
                            UsuarioCorreo = "admin@gmail.com",
                            UsuarioNombre = "Admin",
                            UsuarioTlf = "616756340"
                        },
                        new
                        {
                            UsuarioId = 2,
                            RolId = 2,
                            UsuarioColor_Fav = "amarillo",
                            UsuarioContra = "abc123.",
                            UsuarioCorreo = "user1@gmail.com",
                            UsuarioNombre = "User1",
                            UsuarioTlf = "694234651"
                        },
                        new
                        {
                            UsuarioId = 3,
                            RolId = 3,
                            UsuarioColor_Fav = "azul",
                            UsuarioContra = "abc123.",
                            UsuarioCorreo = "user2@gmail.com",
                            UsuarioNombre = "User2",
                            UsuarioTlf = "194244554"
                        },
                        new
                        {
                            UsuarioId = 4,
                            RolId = 2,
                            UsuarioColor_Fav = "azul",
                            UsuarioContra = "abc123.",
                            UsuarioCorreo = "carlos@gmail.com",
                            UsuarioNombre = "Carlos",
                            UsuarioTlf = "616736340"
                        },
                        new
                        {
                            UsuarioId = 5,
                            RolId = 2,
                            UsuarioColor_Fav = "verde",
                            UsuarioContra = "abc123.",
                            UsuarioCorreo = "martin@gmail.com",
                            UsuarioNombre = "Martin",
                            UsuarioTlf = "611236340"
                        });
                });

            modelBuilder.Entity("AllKeys.Modelo.Videojuego", b =>
                {
                    b.Property<int>("VideojuegoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Disponible")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("VideojuegoCompania")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("VideojuegoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("VideojuegoId");

                    b.ToTable("Videojuegos");

                    b.HasData(
                        new
                        {
                            VideojuegoId = 1,
                            Descripccion = "Juego competitivo basado en plantar bombas y cubrir",
                            Disponible = 1,
                            Precio = 12.5,
                            Tipo = "Shooter",
                            VideojuegoCompania = "Valve,",
                            VideojuegoName = "Csgo"
                        },
                        new
                        {
                            VideojuegoId = 2,
                            Descripccion = "Juego competitivo basado en plantar bombas y cubrir",
                            Disponible = 1,
                            Precio = 12.5,
                            Tipo = "Shooter",
                            VideojuegoCompania = "Valve,",
                            VideojuegoName = "Csgo"
                        },
                        new
                        {
                            VideojuegoId = 3,
                            Descripccion = "Shooter",
                            Disponible = 1,
                            Precio = 30.0,
                            Tipo = "Shooter",
                            VideojuegoCompania = "Activision,",
                            VideojuegoName = "Call of Duty"
                        },
                        new
                        {
                            VideojuegoId = 4,
                            Descripccion = "Juego creativo",
                            Disponible = 1,
                            Precio = 16.0,
                            Tipo = "Survival",
                            VideojuegoCompania = "Mojang,",
                            VideojuegoName = "Minecraft"
                        },
                        new
                        {
                            VideojuegoId = 5,
                            Descripccion = "Perdida de tiempo",
                            Disponible = 1,
                            Precio = 0.0,
                            Tipo = "MMO",
                            VideojuegoCompania = "Riot Games",
                            VideojuegoName = "League of Legends"
                        });
                });

            modelBuilder.Entity("AllKeys.Modelo.UsuarioRegistrado", b =>
                {
                    b.HasBaseType("AllKeys.Modelo.Usuario");

                    b.Property<string>("Tarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(18)")
                        .HasMaxLength(18);

                    b.Property<int>("UsuarioRegistradoId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("UsuarioRegistrado");
                });

            modelBuilder.Entity("AllKeys.Modelo.Copia", b =>
                {
                    b.HasOne("AllKeys.Modelo.UsuarioRegistrado", "UsuarioRegistrado")
                        .WithMany("Copias")
                        .HasForeignKey("UsuarioRegistradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllKeys.Modelo.Videojuego", "Videojuego")
                        .WithMany("Copias")
                        .HasForeignKey("VideojuegoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AllKeys.Modelo.ObtenerDescuento", b =>
                {
                    b.HasOne("AllKeys.Modelo.Descuento", "Descuento")
                        .WithMany("ObtenerDescuentos")
                        .HasForeignKey("DescuentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllKeys.Modelo.UsuarioRegistrado", "UsuarioRegistrado")
                        .WithMany("ObtenerDescuentos")
                        .HasForeignKey("UsuarioRegistradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AllKeys.Modelo.Usuario", b =>
                {
                    b.HasOne("AllKeys.Modelo.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AllKeys.Modelo.UsuarioRegistrado", b =>
                {
                    b.HasOne("AllKeys.Modelo.Usuario", "Usuario")
                        .WithOne("UsuarioRegistrado")
                        .HasForeignKey("AllKeys.Modelo.UsuarioRegistrado", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
