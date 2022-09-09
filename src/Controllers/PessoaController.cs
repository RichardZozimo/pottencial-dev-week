using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Models;
using src.Persistence;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase{

  private DatabaseContext _context { get; set; }

  public PessoaController(DatabaseContext context) {
    this._context = context;
  }

  [HttpGet]
  public List<Pessoa> ListPessoa() {
    // Pessoa pessoa = new Pessoa("Richard", 25, "12546589765");
    // Contrato NovoContrato = new Contrato("123456", 153.67);
    // pessoa.Contratos.Add(NovoContrato);

    return _context.Pessoas.Include(p => p.Contratos).ToList();
    // para cada pessoa ele inclui os contratos atrelados
  }

  [HttpPost]
  public Pessoa InsertPessoa(Pessoa pessoa) {

    _context.Pessoas.Add(pessoa);
    _context.SaveChanges();

    return pessoa;
  }

  [HttpPut("{id}")]
  public string UpdatePessoa(int id, Pessoa pessoa) {
    
    _context.Pessoas.Update(pessoa);
    _context.SaveChanges();

    return "Dados do Id " + id + " atualizados!";
  } 

  [HttpDelete("{Iid}")]
  public string DeletePessoa(int id) {
    return "Dados do Id " + id + " deletado com sucesso!";
  }

}