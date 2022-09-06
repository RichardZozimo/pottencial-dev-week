using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase{

  [HttpGet]
  public Pessoa ListPessoa() {
    Pessoa pessoa = new Pessoa("Richard", 25, "12546589765");
    Contrato NewContrato = new Contrato("123456", 153.67);
    pessoa.Contratos.Add(NewContrato);
    return pessoa;
  }

  [HttpPost]
  public Pessoa InsertPessoa(Pessoa pessoa) {
    return pessoa;
  }

  [HttpPut("{id}")]
  public string UpdatePessoa(int id, Pessoa Pessoa) {
    Console.WriteLine(id);
    Console.WriteLine(Pessoa);
    return "Dados do id " + id + " atualizados!";
  } 

  [HttpDelete("{id}")]
  public string DeletePerson(int id) {
    return "Dados do id " + id + " deletado com sucesso!";
  }

}