using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaCirandinha.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coordenadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DadosCoordenador_Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DadosCoordenador_Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DadosCoordenador_DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordenadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DadosProfessor_Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DadosProfessor_Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DadosProfessor_DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorMaterias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MateriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorMaterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessorMaterias_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessorMaterias_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProfessorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turmas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DadosAluno_Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DadosAluno_Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DadosAluno_DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endereco_Rua = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Endereco_Numero = table.Column<int>(type: "int", nullable: false),
                    Endereco_Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco_Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco_Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Endereco_Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Responsavel_Mae_Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Responsavel_Mae_Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Responsavel_Mae_DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Responsavel_Pai_Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Responsavel_Pai_Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Responsavel_Pai_DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TurmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Turmas_Id",
                        column: x => x.Id,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atividades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TurmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Avaliacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NotaMaxima = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ProfessorMateriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividades_ProfessorMaterias_ProfessorMateriaId",
                        column: x => x.ProfessorMateriaId,
                        principalTable: "ProfessorMaterias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Atividades_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoAtividades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlunoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlunoId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtividadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nota = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoAtividades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunoAtividades_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlunoAtividades_Alunos_AlunoId1",
                        column: x => x.AlunoId1,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoAtividades_Atividades_AtividadeId",
                        column: x => x.AtividadeId,
                        principalTable: "Atividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoAtividades_AlunoId",
                table: "AlunoAtividades",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoAtividades_AlunoId1",
                table: "AlunoAtividades",
                column: "AlunoId1");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoAtividades_AtividadeId",
                table: "AlunoAtividades",
                column: "AtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_ProfessorMateriaId",
                table: "Atividades",
                column: "ProfessorMateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_TurmaId",
                table: "Atividades",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorMaterias_MateriaId",
                table: "ProfessorMaterias",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorMaterias_ProfessorId",
                table: "ProfessorMaterias",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_ProfessorId",
                table: "Turmas",
                column: "ProfessorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoAtividades");

            migrationBuilder.DropTable(
                name: "Coordenadores");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Atividades");

            migrationBuilder.DropTable(
                name: "ProfessorMaterias");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
