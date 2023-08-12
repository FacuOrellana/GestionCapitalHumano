using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionCapitalHumano.Migrations
{
    /// <inheritdoc />
    public partial class V1_CambiosEnModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.IdArea);
                });

            migrationBuilder.CreateTable(
                name: "Capacitacion",
                columns: table => new
                {
                    IdCapacitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    DuracionHoras = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitacion", x => x.IdCapacitacion);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    IdContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    Sueldo = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Seniority = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.IdContrato);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdArea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.IdDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "EquipoTrabajo",
                columns: table => new
                {
                    IdEquipoTrabajo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdDepartamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoTrabajo", x => x.IdEquipoTrabajo);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    IdExperiencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Duracion = table.Column<TimeSpan>(type: "time", nullable: true),
                    IdEmpleado = table.Column<int>(type: "int", nullable: true),
                    IdTipoExperiencia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.IdExperiencia);
                });

            migrationBuilder.CreateTable(
                name: "Habilidad",
                columns: table => new
                {
                    IdHabilidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidad", x => x.IdHabilidad);
                });

            migrationBuilder.CreateTable(
                name: "ObraSocial",
                columns: table => new
                {
                    IdObraSocial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aporte = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObraSocial", x => x.IdObraSocial);
                });

            migrationBuilder.CreateTable(
                name: "PuestoTrabajo",
                columns: table => new
                {
                    IdPuestoTrabajo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuestoTrabajo", x => x.IdPuestoTrabajo);
                });

            migrationBuilder.CreateTable(
                name: "Sindicato",
                columns: table => new
                {
                    IdSindicato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aporte = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sindicato", x => x.IdSindicato);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    IdTarea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdPuestoTrabajo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.IdTarea);
                });

            migrationBuilder.CreateTable(
                name: "TipoExperiencia",
                columns: table => new
                {
                    IdTipoExperiencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoExperiencia", x => x.IdTipoExperiencia);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Legajo = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ciudad = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    ObraSocialIdObraSocial = table.Column<int>(type: "int", nullable: false),
                    ContratoIdContrato = table.Column<int>(type: "int", nullable: false),
                    SindicatoIdSindicato = table.Column<int>(type: "int", nullable: false),
                    PuestoTrabajoIdPuestoTrabajo = table.Column<int>(type: "int", nullable: false),
                    EquipoTrabajoIdEquipoTrabajo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Contrato_ContratoIdContrato",
                        column: x => x.ContratoIdContrato,
                        principalTable: "Contrato",
                        principalColumn: "IdContrato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_EquipoTrabajo_EquipoTrabajoIdEquipoTrabajo",
                        column: x => x.EquipoTrabajoIdEquipoTrabajo,
                        principalTable: "EquipoTrabajo",
                        principalColumn: "IdEquipoTrabajo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_ObraSocial_ObraSocialIdObraSocial",
                        column: x => x.ObraSocialIdObraSocial,
                        principalTable: "ObraSocial",
                        principalColumn: "IdObraSocial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_PuestoTrabajo_PuestoTrabajoIdPuestoTrabajo",
                        column: x => x.PuestoTrabajoIdPuestoTrabajo,
                        principalTable: "PuestoTrabajo",
                        principalColumn: "IdPuestoTrabajo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_Sindicato_SindicatoIdSindicato",
                        column: x => x.SindicatoIdSindicato,
                        principalTable: "Sindicato",
                        principalColumn: "IdSindicato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    IdAsistencia = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    HoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "datetime2", fixedLength: true, maxLength: 10, nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabla1", x => x.IdAsistencia);
                    table.ForeignKey(
                        name: "FK__Asistenci__IdEmp__5CD6CB2B",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado_Capacitacion",
                columns: table => new
                {
                    IdEmpleado_Capacitacion = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdCapacitacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado_Capacitacion", x => x.IdEmpleado_Capacitacion);
                    table.ForeignKey(
                        name: "FK_Empleado_Capacitacion_Capacitacion",
                        column: x => x.IdCapacitacion,
                        principalTable: "Capacitacion",
                        principalColumn: "IdCapacitacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_Capacitacion_Empleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado_Habilidad",
                columns: table => new
                {
                    IdEmpleado_Habilidad = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: true),
                    IdHabilidad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dawdawd", x => x.IdEmpleado_Habilidad);
                    table.ForeignKey(
                        name: "FK_Empleado_Habilidad_Empleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado");
                    table.ForeignKey(
                        name: "FK_Empleado_Habilidad_Habilidad",
                        column: x => x.IdHabilidad,
                        principalTable: "Habilidad",
                        principalColumn: "IdHabilidad");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_IdEmpleado",
                table: "Asistencia",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_ContratoIdContrato",
                table: "Empleado",
                column: "ContratoIdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_EquipoTrabajoIdEquipoTrabajo",
                table: "Empleado",
                column: "EquipoTrabajoIdEquipoTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_ObraSocialIdObraSocial",
                table: "Empleado",
                column: "ObraSocialIdObraSocial");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_PuestoTrabajoIdPuestoTrabajo",
                table: "Empleado",
                column: "PuestoTrabajoIdPuestoTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_SindicatoIdSindicato",
                table: "Empleado",
                column: "SindicatoIdSindicato");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_Capacitacion_IdCapacitacion",
                table: "Empleado_Capacitacion",
                column: "IdCapacitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_Capacitacion_IdEmpleado",
                table: "Empleado_Capacitacion",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_Habilidad_IdEmpleado",
                table: "Empleado_Habilidad",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_Habilidad_IdHabilidad",
                table: "Empleado_Habilidad",
                column: "IdHabilidad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Asistencia");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Empleado_Capacitacion");

            migrationBuilder.DropTable(
                name: "Empleado_Habilidad");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "TipoExperiencia");

            migrationBuilder.DropTable(
                name: "Capacitacion");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Habilidad");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "EquipoTrabajo");

            migrationBuilder.DropTable(
                name: "ObraSocial");

            migrationBuilder.DropTable(
                name: "PuestoTrabajo");

            migrationBuilder.DropTable(
                name: "Sindicato");
        }
    }
}
