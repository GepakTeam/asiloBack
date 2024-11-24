using System;
using System.ComponentModel.DataAnnotations;

public class ProntuarioPsicologo
{
    public ProntuarioPsicologo(Guid ID, string Nome, string DataNascimento, string RG, string CPF, string Responsavel, string Endereco, string Municipio, string Saude, string Consciente, string Religiao, string Filho, string QntFilho, string Acolhimento, string Historico)
    {
        this.ID = ID;
        this.Nome = Nome;
        this.DataNascimento = DataNascimento;
        this.RG = RG;
        this.CPF = CPF;
        this.Responsavel = Responsavel;
        this.Endereco = Endereco;
        this.Municipio = Municipio;
        this.Saude = Saude;
        this.Consciente = Consciente;
        this.Religiao = Religiao;
        this.Filho = Filho;
        this.QntFilho = QntFilho;
        this.Acolhimento = Acolhimento;
        this.Historico = Historico;
    }
    [Key]
    [Required(ErrorMessage = "O campo ID � obrigat�rio")]
    public Guid ID { get; set; }//---

    [Required(ErrorMessage = "O campo nome � obrigat�rio")]
    [MaxLength(100, ErrorMessage = "O nome n�o pode exceder 100 caracteres")]
    public string Nome { get; set; }//---

    [Required(ErrorMessage = "A data de nascimento � obrigat�ria")]
    public string DataNascimento { get; set; }//---

    [Required(ErrorMessage = "O RG � obrigat�rio")]
    [MaxLength(20, ErrorMessage = "O RG n�o pode exceder 20 caracteres")]
    public string RG { get; set; }//----

    [Required(ErrorMessage = "O CPF � obrigat�rio")]
    [MaxLength(20, ErrorMessage = "O CPF n�o pode exceder 20 caracteres")]
    public string CPF { get; set; }//---

    [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
    [MaxLength(100, ErrorMessage = "O respons�vel n�o pode exceder 100 caracteres")]
    public string Responsavel { get; set; }//---

    [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
    [MaxLength(200, ErrorMessage = "O endere�o n�o pode exceder 200 caracteres")]
    public string Endereco { get; set; }//---

    [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
    [MaxLength(100, ErrorMessage = "O munic�pio n�o pode exceder 100 caracteres")]
    public string Municipio { get; set; }//---

    [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
    [MaxLength(100, ErrorMessage = "O campo sa�de n�o pode exceder 100 caracteres")]
    public string Saude { get; set; }//---

    [Required(ErrorMessage = "O campo consciente � obrigat�rio")]
    public string Consciente { get; set; }//---

    [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
    [MaxLength(100, ErrorMessage = "A religi�o n�o pode exceder 100 caracteres")]
    public string Religiao { get; set; }//---

    [Required(ErrorMessage = "O campo filho � obrigat�rio")]
    public string Filho { get; set; }//---

    public string QntFilho { get; set; }

    [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
    [MaxLength(500, ErrorMessage = "O acolhimento n�o pode exceder 500 caracteres")]
    public string Acolhimento { get; set; }//---

    [Required(ErrorMessage = "Todos os campos devem ser preenchidos")]
    [MaxLength(1000, ErrorMessage = "O hist�rico n�o pode exceder 1000 caracteres")]
    public string Historico { get; set; }
}
