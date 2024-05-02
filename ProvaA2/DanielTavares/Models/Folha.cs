using System.ComponentModel.DataAnnotations;
using ProvaA2.Models;
using ProvaA2.Controllers;

public class Folha
{
    public Folha()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public Folha(double valor, int quantidade, int mes, int ano, double salarioBruto, double impostoIrrf, double impostoInss, double impostoFgts, double salarioLiquido, Funcionario funcionario, string funcionarioId)
    {
        Id = Guid.NewGuid().ToString();
        Valor = valor;
        Quantidade = quantidade;
        Mes = mes;
        Ano = ano;

        Calculo calculo = new();

        SalarioBruto = salarioBruto;
        ImpostoIrrf = impostoIrrf;
        ImpostoInss = impostoInss;
        ImpostoFgts = impostoFgts;
        SalarioLiquido = salarioLiquido;

        Funcionario = funcionario;
        FuncionarioId = funcionarioId;
        CriadoEm = DateTime.Now;
    }

    public string Id { get; set; }
    public double Valor { get; set; }
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public int Quantidade { get; set; }
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public int Mes { get; set; }
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public int Ano { get; set; }
    public double SalarioBruto { get; set; }
    public double ImpostoIrrf { get; set; }
    public double ImpostoInss { get; set; }
    public double ImpostoFgts { get; set; }
    public double SalarioLiquido { get; set; }
    public Funcionario? Funcionario { get; set; }
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public string? FuncionarioId { get; set; }
    DateTime CriadoEm { get; set; }
}
