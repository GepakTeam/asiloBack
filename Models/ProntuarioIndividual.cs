// Models/ProntuarioIndividual.cs
using System;
using System.ComponentModel.DataAnnotations;

public class ProntuarioIndividual
{
    public ProntuarioIndividual(Guid Id, string Nome, string DataNascimento, double Idade, string LocalNascimento, string Sexo, string Raca, string Telefone, string NomeMae, string NomePai, string NomeResponsavel, string Endereco, string Cep, string PontoReferencia, string Rg, string Cpf, string CarteiraTrabalho, string TituloEleitoral, string CertidaoNascimento, string RelacaoAmigavel, string RelacaoDistanciados, string RelacaoConflituosa, string QuemResideCasa, string Filho, string QntFilho, string ComQuemMoraFilhos, string Moradia, string Doenca, string Deficiencia, string QuaisDeficiencias, string Saude, string AtividadesLazer, string Parceiros, string Acompanhamento, string QualMedicacao, string PlanoSaude, string QualPlanoSaude, string UsoDroga, string QuaisDrogasUsou, string HistoricoUso, string AtendimentoPsicologico, string LocalAtendimentoPsicologico, string TratamentoPsiquiatrico, string LocalTratamentoPsiquiatrico, string TomaAlgumTipoMedicamento, string MotivoEncaminhamentoPsicologico)
    {
        this.Id = Id;
        this.Nome = Nome;
        this.DataNascimento = DataNascimento;
        this.Idade = Idade;
        this.LocalNascimento = LocalNascimento;
        this.Sexo = Sexo;
        this.Raca = Raca;
        this.Telefone = Telefone;
        this.NomeMae = NomeMae;
        this.NomePai = NomePai;
        this.NomeResponsavel = NomeResponsavel;
        this.Endereco = Endereco;
        this.Cep = Cep;
        this.PontoReferencia = PontoReferencia;
        this.Rg = Rg;
        this.Cpf = Cpf;
        this.CarteiraTrabalho = CarteiraTrabalho;
        this.TituloEleitoral = TituloEleitoral;
        this.CertidaoNascimento = CertidaoNascimento;
        this.RelacaoAmigavel = RelacaoAmigavel;
        this.RelacaoDistanciados = RelacaoDistanciados;
        this.RelacaoConflituosa = RelacaoConflituosa;
        this.QuemResideCasa = QuemResideCasa;
        this.Filho = Filho;
        this.QntFilho = QntFilho;
        this.ComQuemMoraFilhos = ComQuemMoraFilhos;
        this.Moradia = Moradia;
        this.Doenca = Doenca;
        this.Deficiencia = Deficiencia;
        this.QuaisDeficiencias = QuaisDeficiencias;
        this.Saude = Saude;
        this.AtividadesLazer = AtividadesLazer;
        this.Parceiros = Parceiros;
        this.Acompanhamento = Acompanhamento;
        this.QualMedicacao = QualMedicacao;
        this.PlanoSaude = PlanoSaude;
        this.QualPlanoSaude = QualPlanoSaude;
        this.UsoDroga = UsoDroga;
        this.QuaisDrogasUsou = QuaisDrogasUsou;
        this.HistoricoUso = HistoricoUso;
        this.AtendimentoPsicologico = AtendimentoPsicologico;
        this.LocalAtendimentoPsicologico = LocalAtendimentoPsicologico;
        this.TratamentoPsiquiatrico = TratamentoPsiquiatrico;
        this.LocalTratamentoPsiquiatrico = LocalTratamentoPsiquiatrico;
        this.TomaAlgumTipoMedicamento = TomaAlgumTipoMedicamento;
        this.MotivoEncaminhamentoPsicologico = MotivoEncaminhamentoPsicologico;
    }
    public Guid Id { get; set; }//---

    [Required(ErrorMessage = "O nome do residente deve ser informado")]
    public string Nome { get; set; }//---

    [Required(ErrorMessage = "A data de nascimento do residente deve ser informada")]
    public string DataNascimento { get; set; }//---

    [Required(ErrorMessage = "A idade do residente deve ser informada")]
    [Range(60, 110, ErrorMessage = "A idade deve estar entre 60 e 110 anos de idade")]
    public double Idade { get; set; }//---

    [Required(ErrorMessage = "Informe o local de nascimento do idoso")]
    public string LocalNascimento { get; set; }//---

    [Required(ErrorMessage = "Informe o gênero do idoso")]
    public string Sexo { get; set; }//---

    [Required(ErrorMessage = "Informe a raça à qual o idoso pertence")]
    public string Raca { get; set; }//---

    [Required(ErrorMessage = "Informe o número de telefone de contato")]
    [StringLength(12, MinimumLength = 12, ErrorMessage = "O campo de telefone deve conter o DDD e o número")]
    public string Telefone { get; set; }//---

    [Required(ErrorMessage = "Informe o nome da mãe do residente")]
    public string NomeMae { get; set; }//---

    [Required(ErrorMessage = "Informe o nome do pai do residente")]
    public string NomePai { get; set; }//---

    [Required(ErrorMessage = "Insira o nome do responsável legal pelo residente")]
    public string NomeResponsavel { get; set; }//---

    [Required(ErrorMessage = "Insira o endereço de onde o residente morava")]
    public string Endereco { get; set; }//---

    [Required(ErrorMessage = "Insira o CEP da residência do residente")]
    [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP deve conter 8 dígitos")]
    public string Cep { get; set; }//---

    [Required(ErrorMessage = "Insira o ponto de referência (se houver)")]
    public string PontoReferencia { get; set; }//---

    [Required(ErrorMessage = "Insira o RG do residente")]
    [StringLength(10, MinimumLength = 10, ErrorMessage = "O RG deve conter no máximo 10 dígitos")]
    public string Rg { get; set; }//---

    [Required(ErrorMessage = "Insira o CPF do residente")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve conter 11 dígitos")]
    public string Cpf { get; set; }//---

    [Required(ErrorMessage = "Informe a carteira de trabalho do residente")]
    [StringLength(8, MinimumLength = 8, ErrorMessage = "A carteira de trabalho deve conter 8 dígitos")]
    public string CarteiraTrabalho { get; set; }//---

    [Required(ErrorMessage = "Informe o título de eleitor do residente")]
    [StringLength(12, MinimumLength = 12, ErrorMessage = "O número do título de eleitor deve ter 12 dígitos")]
    public string TituloEleitoral { get; set; }//---

    [Required(ErrorMessage = "Informe a certidão de nascimento")]
    [StringLength(32, MinimumLength = 32, ErrorMessage = "A certidão de nascimento é composta de 32 dígitos")]
    public string CertidaoNascimento { get; set; }//---

    [Required(ErrorMessage = "Informe a relação amigável")]
    public string RelacaoAmigavel { get; set; }//---

    [Required(ErrorMessage = "Informe a relação distanciada")]
    public string RelacaoDistanciados { get; set; }//---

    [Required(ErrorMessage = "Informe a relação conflituosa")]
    public string RelacaoConflituosa { get; set; }//---

    [Required(ErrorMessage = "Informe quem reside na casa")]
    public string QuemResideCasa { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente tem filhos")]
    public string Filho { get; set; }//---


    public string QntFilho { get; set; }//---

    public string ComQuemMoraFilhos { get; set; }//---

    [Required(ErrorMessage = "Informe o tipo de moradia")]
    public string Moradia { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente tem alguma doença")]
    public string Doenca { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente tem alguma deficiência")]
    public string Deficiencia { get; set; }//---


    public string QuaisDeficiencias { get; set; }//---

    [Required(ErrorMessage = "Informe a situação de saúde do residente")]
    public string Saude { get; set; }//---

    [Required(ErrorMessage = "Informe as atividades de lazer do residente")]
    public string AtividadesLazer { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente tem parceiros")]
    public string Parceiros { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente tem acompanhamento médico")]
    public string Acompanhamento { get; set; }//---


    public string QualMedicacao { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente tem plano de saúde")]
    public string PlanoSaude { get; set; }//---


    public string QualPlanoSaude { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente faz uso de drogas")]
    public string UsoDroga { get; set; }//---


    public string QuaisDrogasUsou { get; set; }//---


    public string HistoricoUso { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente tem acompanhamento psicológico")]
    public string AtendimentoPsicologico { get; set; }//---

    public string LocalAtendimentoPsicologico { get; set; }//---

    [Required(ErrorMessage = "tratamento psiquiatrico")]
    public string TratamentoPsiquiatrico { get; set; }//---


    public string LocalTratamentoPsiquiatrico { get; set; }//---

    [Required(ErrorMessage = "Informe se o residente toma algum tipo de medicamento")]
    public string TomaAlgumTipoMedicamento { get; set; }//---

    [Required(ErrorMessage = "Informe o motivo do encaminhamento psicológico")]
    public string MotivoEncaminhamentoPsicologico { get; set; }
}
