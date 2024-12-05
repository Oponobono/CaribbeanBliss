﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Caribbean2.Migrations
{
    [DbContext(typeof(CaribbeanContext))]
    [Migration("20241204235749_InitialCreates")]
    partial class InitialCreates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Caribbean2.Models.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<bool>("ClienteEstado")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idRol")
                        .HasColumnType("int");

                    b.Property<int?>("idRolNavigationIdRol")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCliente");

                    b.HasIndex("idRolNavigationIdRol");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Caribbean2.Models.Consulta", b =>
                {
                    b.Property<int>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConsulta"));

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaConsulta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("NombresApellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdConsulta");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("Caribbean2.Models.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"));

                    b.Property<string>("EmailEmpleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("EstadoEmpleado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("IdEmpleado");

                    b.HasIndex("EmailEmpleado")
                        .IsUnique();

                    b.HasIndex("RolId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Caribbean2.Models.Huesped", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaLlegada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEstadoHuesped")
                        .HasColumnType("int");

                    b.Property<string>("LugarResidencia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("NumeroContacto")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("NumeroIdentificacion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadoHuesped");

                    b.ToTable("Huespedes");
                });

            modelBuilder.Entity("Caribbean2.Models.HuespedEstado", b =>
                {
                    b.Property<int>("IdEstadoHuesped")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstadoHuesped"));

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdEstadoHuesped");

                    b.ToTable("HuespedEstados");

                    b.HasData(
                        new
                        {
                            IdEstadoHuesped = 1,
                            NombreEstado = "Activo"
                        },
                        new
                        {
                            IdEstadoHuesped = 3,
                            NombreEstado = "Proceso Check-Out"
                        },
                        new
                        {
                            IdEstadoHuesped = 4,
                            NombreEstado = "Check-Out Completado"
                        },
                        new
                        {
                            IdEstadoHuesped = 5,
                            NombreEstado = "Cancelado"
                        },
                        new
                        {
                            IdEstadoHuesped = 6,
                            NombreEstado = "Aplazado"
                        },
                        new
                        {
                            IdEstadoHuesped = 7,
                            NombreEstado = "Suspendido"
                        });
                });

            modelBuilder.Entity("Caribbean2.Models.Metrica", b =>
                {
                    b.Property<int>("IdMetrica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMetrica"));

                    b.Property<int>("Cancelaciones")
                        .HasColumnType("int");

                    b.Property<double>("DuracionPromedioEstadia")
                        .HasColumnType("float");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ImpactoFinancieroCancelaciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IngresosTotales")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumeroHuespedes")
                        .HasColumnType("int");

                    b.Property<int>("OcupacionDiaria")
                        .HasColumnType("int");

                    b.Property<int>("OcupacionMensual")
                        .HasColumnType("int");

                    b.Property<int>("OcupacionSemanal")
                        .HasColumnType("int");

                    b.Property<double>("PromedioDiasAnticipacionReserva")
                        .HasColumnType("float");

                    b.Property<int>("ReservasNuevas")
                        .HasColumnType("int");

                    b.Property<int>("SuscritosBoletin")
                        .HasColumnType("int");

                    b.Property<double>("TasaOcupacion")
                        .HasColumnType("float");

                    b.HasKey("IdMetrica");

                    b.ToTable("Metricas");
                });

            modelBuilder.Entity("Caribbean2.Models.Pago", b =>
                {
                    b.Property<int>("IdPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPago"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<string>("TipoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdPago");

                    b.HasIndex("IdReserva");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("Caribbean2.Models.Permiso", b =>
                {
                    b.Property<int>("IdPermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPermiso"));

                    b.Property<string>("DescripcionPermiso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePermiso")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPermiso");

                    b.HasIndex("NombrePermiso")
                        .IsUnique();

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Caribbean2.Models.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReserva"));

                    b.Property<decimal>("Anticipo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<int>("IdHabitacion")
                        .HasColumnType("int");

                    b.Property<string>("Notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPersonas")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdReserva");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEstado");

                    b.HasIndex("IdHabitacion");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Caribbean2.Models.ReservaEstado", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdEstado");

                    b.ToTable("ReservaEstados");

                    b.HasData(
                        new
                        {
                            IdEstado = 1,
                            Nombre = "Pendiente"
                        },
                        new
                        {
                            IdEstado = 2,
                            Nombre = "Confirmada"
                        },
                        new
                        {
                            IdEstado = 3,
                            Nombre = "En Progreso"
                        },
                        new
                        {
                            IdEstado = 4,
                            Nombre = "Completada"
                        },
                        new
                        {
                            IdEstado = 5,
                            Nombre = "Cancelada"
                        });
                });

            modelBuilder.Entity("Caribbean2.Models.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"));

                    b.Property<string>("DescripcionRol")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("EstadoRol")
                        .HasColumnType("bit");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdRol");

                    b.HasIndex("NombreRol")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            IdRol = 1,
                            DescripcionRol = "Cliente",
                            EstadoRol = true,
                            NombreRol = "Cliente"
                        },
                        new
                        {
                            IdRol = 2,
                            DescripcionRol = "Empleado",
                            EstadoRol = false,
                            NombreRol = "Empleado"
                        },
                        new
                        {
                            IdRol = 3,
                            DescripcionRol = "Administrador",
                            EstadoRol = true,
                            NombreRol = "Administrador"
                        },
                        new
                        {
                            IdRol = 4,
                            DescripcionRol = "Gerente",
                            EstadoRol = false,
                            NombreRol = "Gerente"
                        });
                });

            modelBuilder.Entity("Caribbean2.Models.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServicio"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("EstadoServicio")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("PrecioServicio")
                        .HasColumnType("money");

                    b.HasKey("IdServicio");

                    b.ToTable("Servicios");

                    b.HasData(
                        new
                        {
                            IdServicio = 1,
                            Descripcion = "Vive la emoción del paracaidismo con un salto en tándem. Disfruta de vistas impresionantes y la adrenalina de caer en caída libre, acompañado de un instructor experto. Un servicio único para quienes buscan una experiencia extrema y memorable, ¡haz realidad tu sueño de volar!",
                            EstadoServicio = true,
                            Nombre = "Paracaidismo",
                            PrecioServicio = 99.99m
                        },
                        new
                        {
                            IdServicio = 5,
                            Descripcion = "Recibe asesoramiento experto con nuestras guías de viaje personalizadas que te ayudarán a descubrir lo mejor del Caribe.",
                            EstadoServicio = true,
                            Nombre = "Viaje Personalizadas",
                            PrecioServicio = 69.99m
                        },
                        new
                        {
                            IdServicio = 8,
                            Descripcion = "Viaja con comodidad en nuestros vehículos de lujo, equipados para ofrecerte la mejor experiencia de transporte.",
                            EstadoServicio = true,
                            Nombre = "Transporte de Lujo",
                            PrecioServicio = 49.99m
                        },
                        new
                        {
                            IdServicio = 9,
                            Descripcion = "Diviértete en nuestro parque acuático, con emocionantes toboganes, piscinas de olas y zonas de relajación. Ideal para toda la familia, ofrece atracciones para todos los gustos, desde aventuras acuáticas hasta momentos de descanso. Ven y disfruta de un día lleno de diversión y frescura bajo el sol",
                            EstadoServicio = true,
                            Nombre = "Parque acuático",
                            PrecioServicio = 119.00m
                        },
                        new
                        {
                            IdServicio = 10,
                            Descripcion = "Relájate y rejuvenece con nuestros servicios de spa de primera clase, diseñados para ofrecerte una experiencia de bienestar.",
                            EstadoServicio = true,
                            Nombre = "Servicios de Spa",
                            PrecioServicio = 39.99m
                        },
                        new
                        {
                            IdServicio = 11,
                            Descripcion = "Saborea una selección de platos gourmet preparados por chefs expertos, con ingredientes frescos y locales.",
                            EstadoServicio = true,
                            Nombre = "Cenas Gourmet",
                            PrecioServicio = 59.99m
                        });
                });

            modelBuilder.Entity("Caribbean2.Models.Suscripcion", b =>
                {
                    b.Property<int>("IdSuscripcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSuscripcion"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaSuscripcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdSuscripcion");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Suscripciones");
                });

            modelBuilder.Entity("Caribbean2.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioID"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombresApellidos")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("ResetPasswordExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResetPasswordToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RolIdRol")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TipoIdentificacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UsuarioID");

                    b.HasIndex("Correo")
                        .IsUnique();

                    b.HasIndex("IdRol");

                    b.HasIndex("Identificacion")
                        .IsUnique();

                    b.HasIndex("RolIdRol");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioID = 1,
                            Contrasena = "nimad4321",
                            Correo = "admin@admincorreo.com",
                            Estado = true,
                            FechaRegistro = new DateTime(2024, 12, 4, 18, 57, 46, 25, DateTimeKind.Local).AddTicks(2778),
                            IdRol = 3,
                            Identificacion = "1",
                            NombresApellidos = "admin",
                            Telefono = "1",
                            TipoIdentificacion = "CC"
                        });
                });

            modelBuilder.Entity("Habitacion", b =>
                {
                    b.Property<int>("IdHabitacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHabitacion"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("NumeroHabitacion")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioHabitacion")
                        .HasColumnType("money");

                    b.HasKey("IdHabitacion");

                    b.HasIndex("IdEstado");

                    b.ToTable("Habitaciones");

                    b.HasData(
                        new
                        {
                            IdHabitacion = 1,
                            Capacidad = 2,
                            Descripcion = "Habitación Deluxe con diseño moderno, equipada con comodidades premium para una experiencia única de confort.",
                            IdEstado = 1,
                            Nombre = "Deluxe",
                            NumeroHabitacion = 0,
                            PrecioHabitacion = 359.99m
                        },
                        new
                        {
                            IdHabitacion = 2,
                            Capacidad = 8,
                            Descripcion = "Habitación ideal para familias, amplia y cómoda, con capacidad para grupos grandes y servicios adaptados a sus necesidades.",
                            IdEstado = 1,
                            Nombre = "Familiar",
                            NumeroHabitacion = 0,
                            PrecioHabitacion = 239.99m
                        },
                        new
                        {
                            IdHabitacion = 3,
                            Capacidad = 1,
                            Descripcion = "Habitación perfecta para una sola persona, diseñada para garantizar privacidad y un espacio acogedor.",
                            IdEstado = 1,
                            Nombre = "Individual",
                            NumeroHabitacion = 0,
                            PrecioHabitacion = 119.99m
                        },
                        new
                        {
                            IdHabitacion = 4,
                            Capacidad = 2,
                            Descripcion = "Habitación VIP con servicios exclusivos, lujo excepcional y diseño elegante para huéspedes exigentes.",
                            IdEstado = 1,
                            Nombre = "VIP",
                            NumeroHabitacion = 0,
                            PrecioHabitacion = 539.99m
                        });
                });

            modelBuilder.Entity("HabitacionEstado", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdEstado");

                    b.ToTable("HabitacionEstados");

                    b.HasData(
                        new
                        {
                            IdEstado = 1,
                            Nombre = "Disponible"
                        },
                        new
                        {
                            IdEstado = 2,
                            Nombre = "Ocupada"
                        },
                        new
                        {
                            IdEstado = 3,
                            Nombre = "Inhabilitada"
                        });
                });

            modelBuilder.Entity("HuespedReserva", b =>
                {
                    b.Property<int>("HuespedesId")
                        .HasColumnType("int");

                    b.Property<int>("ReservasIdReserva")
                        .HasColumnType("int");

                    b.HasKey("HuespedesId", "ReservasIdReserva");

                    b.HasIndex("ReservasIdReserva");

                    b.ToTable("ReservaHuesped", (string)null);
                });

            modelBuilder.Entity("ReservaServicio", b =>
                {
                    b.Property<int>("ReservasIdReserva")
                        .HasColumnType("int");

                    b.Property<int>("ServiciosIdServicio")
                        .HasColumnType("int");

                    b.HasKey("ReservasIdReserva", "ServiciosIdServicio");

                    b.HasIndex("ServiciosIdServicio");

                    b.ToTable("ReservaServicio", (string)null);
                });

            modelBuilder.Entity("RolPermiso", b =>
                {
                    b.Property<int>("IdPermiso")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("IdPermiso", "IdRol");

                    b.HasIndex("IdRol");

                    b.ToTable("RolPermiso");
                });

            modelBuilder.Entity("Caribbean2.Models.Cliente", b =>
                {
                    b.HasOne("Caribbean2.Models.Rol", "idRolNavigation")
                        .WithMany()
                        .HasForeignKey("idRolNavigationIdRol");

                    b.Navigation("idRolNavigation");
                });

            modelBuilder.Entity("Caribbean2.Models.Empleado", b =>
                {
                    b.HasOne("Caribbean2.Models.Rol", "Rol")
                        .WithMany("Empleados")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Caribbean2.Models.Huesped", b =>
                {
                    b.HasOne("Caribbean2.Models.HuespedEstado", "EstadoHuesped")
                        .WithMany("Huespedes")
                        .HasForeignKey("IdEstadoHuesped");

                    b.Navigation("EstadoHuesped");
                });

            modelBuilder.Entity("Caribbean2.Models.Pago", b =>
                {
                    b.HasOne("Caribbean2.Models.Reserva", "Reserva")
                        .WithMany("Pagos")
                        .HasForeignKey("IdReserva")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Caribbean2.Models.Reserva", b =>
                {
                    b.HasOne("Caribbean2.Models.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caribbean2.Models.ReservaEstado", "Estado")
                        .WithMany("Reservas")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Habitacion", "Habitacion")
                        .WithMany("Reservas")
                        .HasForeignKey("IdHabitacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Estado");

                    b.Navigation("Habitacion");
                });

            modelBuilder.Entity("Caribbean2.Models.Usuarios", b =>
                {
                    b.HasOne("Caribbean2.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Caribbean2.Models.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolIdRol");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Habitacion", b =>
                {
                    b.HasOne("HabitacionEstado", "EstadoHabitacion")
                        .WithMany("Habitaciones")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoHabitacion");
                });

            modelBuilder.Entity("HuespedReserva", b =>
                {
                    b.HasOne("Caribbean2.Models.Huesped", null)
                        .WithMany()
                        .HasForeignKey("HuespedesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caribbean2.Models.Reserva", null)
                        .WithMany()
                        .HasForeignKey("ReservasIdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReservaServicio", b =>
                {
                    b.HasOne("Caribbean2.Models.Reserva", null)
                        .WithMany()
                        .HasForeignKey("ReservasIdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caribbean2.Models.Servicio", null)
                        .WithMany()
                        .HasForeignKey("ServiciosIdServicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RolPermiso", b =>
                {
                    b.HasOne("Caribbean2.Models.Permiso", null)
                        .WithMany()
                        .HasForeignKey("IdPermiso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Caribbean2.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Caribbean2.Models.Cliente", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Caribbean2.Models.HuespedEstado", b =>
                {
                    b.Navigation("Huespedes");
                });

            modelBuilder.Entity("Caribbean2.Models.Reserva", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Caribbean2.Models.ReservaEstado", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Caribbean2.Models.Rol", b =>
                {
                    b.Navigation("Empleados");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Habitacion", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("HabitacionEstado", b =>
                {
                    b.Navigation("Habitaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
