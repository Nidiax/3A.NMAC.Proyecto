using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Work_IO.Services.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    Usuario = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Contrasenia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    TipoNa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asesores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    CuentaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asesores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asesores_Cuentas_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    TipoVacante = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    AsesorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordenes_Asesores_AsesorId",
                        column: x => x.AsesorId,
                        principalTable: "Asesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordenes_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Genero = table.Column<bool>(nullable: false),
                    Fecha_Nam = table.Column<DateTime>(nullable: false),
                    Lugar_Nam = table.Column<string>(nullable: true),
                    Estado_civil = table.Column<string>(nullable: true),
                    Curp = table.Column<string>(nullable: false),
                    NSS = table.Column<int>(nullable: false),
                    RFC = table.Column<int>(nullable: false),
                    OrdenId = table.Column<int>(nullable: false),
                    NacionalidadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidatos_Nacionalidad_NacionalidadId",
                        column: x => x.NacionalidadId,
                        principalTable: "Nacionalidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidatos_Ordenes_OrdenId",
                        column: x => x.OrdenId,
                        principalTable: "Ordenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    TipoD = table.Column<string>(nullable: true),
                    CandidatoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_Candidatos_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Estatus = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Nombre_informante = table.Column<string>(nullable: false),
                    Puesto_informante = table.Column<string>(nullable: false),
                    Puesto_candidato = table.Column<string>(nullable: true),
                    Sueldo = table.Column<int>(nullable: false),
                    Inicio_laboral = table.Column<DateTime>(nullable: false),
                    Fecha_separacion = table.Column<DateTime>(nullable: false),
                    Puestos_anteriores = table.Column<string>(nullable: true),
                    Motivos = table.Column<string>(nullable: false),
                    Tipo_contrato = table.Column<string>(nullable: true),
                    Fun_ultimopuesto = table.Column<string>(nullable: true),
                    Desempenio = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    CandidatoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referencias_Candidatos_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asesores_CuentaId",
                table: "Asesores",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_NacionalidadId",
                table: "Candidatos",
                column: "NacionalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_OrdenId",
                table: "Candidatos",
                column: "OrdenId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_CandidatoId",
                table: "Documentos",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_AsesorId",
                table: "Ordenes",
                column: "AsesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_EmpresaId",
                table: "Ordenes",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Referencias_CandidatoId",
                table: "Referencias",
                column: "CandidatoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Referencias");

            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropTable(
                name: "Nacionalidad");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "Asesores");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Cuentas");
        }
    }
}
