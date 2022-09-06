namespace src.Models;

public class Contrato
{
  public Contrato() {
    this.DataCriacao = DateTime.Now;
    this.TokenId = "00000";
    this.Valor = 0;
  }

  public Contrato(string TokenId, double Valor) {
    this.DataCriacao = DateTime.Now;
    this.TokenId = TokenId;
    this.Valor = Valor;
    this.Pago = false;
  }

  public DateTime DataCriacao { get; set; }
  public string TokenId { get; set; }
  public double Valor { get; set; }
  public bool Pago { get; set; }
}