using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase{

  [HttpGet]
  public Pessoa ListPessoa() {
    Pessoa Pessoa = new Pessoa("Richard", 25, "12546589765");
    Contrato NovoContrato = new Contrato("123456", 153.67);

    Pessoa.Contratos.Add(NovoContrato);

    return Pessoa;
  }

  [HttpPost]
  public Pessoa InsertPessoa(Pessoa Pessoa) {
    return Pessoa;
  }

  [HttpPut("{Id}")]
  public string UpdatePessoa(int Id, Pessoa Pessoa) {
    Console.WriteLine(Id);
    Console.WriteLine(Pessoa);
    return "Dados do Id " + Id + " atualizados!";
  } 

  [HttpDelete("{Id}")]
  public string DeletePerson(int Id) {
    return "Dados do Id " + Id + " deletado com sucesso!";
  }

}