using System.ComponentModel.DataAnnotations;

namespace ProvaA2.Models;

public class Funcionario
{
    public Funcionario()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public Funcionario(string nome, string cpf)
    {
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        CPF = cpf;
        CriadoEm = DateTime.Now;
    }

    public string Id { get; set; }
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public string? CPF { get; set; }
    public DateTime CriadoEm { get; set; }
}