using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using ProvaA2.Models;
using ProvaA2.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>();

var app = builder.Build();

app.MapGet("/", () => "Api Prova A2");

app.MapPost("api/funcionario/cadastrar", ([FromBody] Funcionario funcionario,
    [FromServices] AppDataContext ctx) =>
{
    List<ValidationResult> erros = new List<ValidationResult>();
    if (!Validator.TryValidateObject(funcionario, new ValidationContext(funcionario), erros, true))
    {
        return Results.BadRequest(erros);
    }

    Funcionario? funcionarioEncontrado = ctx.Funcionarios.FirstOrDefault(x => x.CPF == funcionario.CPF);
    if (funcionarioEncontrado is null)
    {
        ctx.Funcionarios.Add(funcionario);
        ctx.SaveChanges();
        return Results.Created("", funcionario);
    }
    return Results.BadRequest("Já existe um funcionário com este CPF!");
});


app.MapGet("api/funcionario/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound("Não existem funcionários na tabela!");
});

app.MapPost("api/folha/cadastrar", ([FromBody] Folha folha, [FromServices] AppDataContext ctx) =>
{
    Calculo calculo = new();
    
    List<ValidationResult> erros = new List<ValidationResult>();
    if (!Validator.TryValidateObject(folha, new ValidationContext(folha), erros, true))
    {
        return Results.BadRequest(erros);
    }
    Funcionario? funcionario = ctx.Funcionarios.Find(folha.FuncionarioId);
    if (funcionario is null)
    {
        return Results.NotFound("Não existe nenhum funcionário com este Id!");
    }
    folha.Funcionario = funcionario;
    folha.SalarioBruto = folha.Valor * folha.Quantidade;
    folha.ImpostoIrrf = calculo.CalcularIrrf(folha.SalarioBruto);
    folha.ImpostoInss = calculo.CalcularInss(folha.SalarioBruto);
    folha.ImpostoFgts = calculo.CalcularFgts(folha.SalarioBruto);
    folha.SalarioLiquido = folha.SalarioBruto - folha.ImpostoIrrf - folha.ImpostoInss;
    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);
});

app.MapGet("api/folha/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Folhas.Any())
    {
        // Funcionario? funcionario = ctx.Funcionarios.FirstOrDefault(x => x.CPF == cpf);

        List<Folha> folhas = ctx.Folhas.ToList();

        for (int I = 0; I <= folhas.Count - 1; I++)
        {
            Funcionario? funcionario = ctx.Funcionarios.FirstOrDefault(x => x.Id == folhas[I].FuncionarioId);
            folhas[I].Funcionario = funcionario;
        }

        return Results.Ok(folhas);
    }
    return Results.NotFound("Não existem funcionários na tabela!");
});

app.MapGet("api/folha/buscar/{cpf}/{mes}/{ano}", ([FromRoute] string cpf, int mes, int ano, [FromServices] AppDataContext ctx) =>
{
    if (ctx.Folhas.Any())
    {
        Funcionario? funcionario = ctx.Funcionarios.FirstOrDefault(x => x.CPF == cpf);
        if (funcionario is null)
        {
            return Results.BadRequest("O cpf informado não foi encontrado!");
        }

        Folha? folha = ctx.Folhas.Where(f => f.FuncionarioId == funcionario.Id).Where(f => f.Mes == mes).Where(f => f.Ano == ano).First();
        if (folha is null)
        {
            return Results.BadRequest("Não foi possivel encontrar a folha!");
        }

        return Results.Ok(folha);
    }
    return Results.BadRequest("Não foi possivel encontrar a folha!");
});

app.Run();
