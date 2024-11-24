using System;
using System.ComponentModel.DataAnnotations;

namespace Asilo.Models
{
    public class ProntuarioNutricionista
    {
        public ProntuarioNutricionista(Guid ID, string Nome, string DataAvaliacao, int Idade, string DataNascimento, string MotivoConsulta, string EncaminhadoPor, string Convenio, string Telefone, string Endereco, string Escolaridade, string Profissao, string NumeroPessoasCasa, string NumeroAdulto, string NumeroCrianca, string EstadoCivil, string ProblemaSaude, string QualProblemaSaude, string Diabetes, string Hipertensao, string Obesidade, string Dislipidemia, string OutrosProblemas, string AntecedenteDiabetes, string AntecedenteHipertensao, string AntecedenteObesidade, string AntecedenteDislipidemia, string OutrosAntecedentes, string HabitoIntestinal, string CaracteristicaFezes, string HabitoUrinario, string HorasSono, string AtividadeFisica, string FrequenciaAtividadeFisica, string Fuma, string QuantoFuma, string HaQuantoTempoFuma, string FazUsoBebidaAlcoolica, string TipoBebida, string HaQuantoTempoBebida, string FazUsoLaxante, string PorQuantoTempoLaxante, string FazUsoMedicamento, string HaQuantoTempoMedicamento, string QuaisMedicamentos, string IntoleranciaOuAversaoAlimentar, string QualIntolerancia, string HaQuantoTempoIntolerancia, string ControleAlimentacao, string QualControleAlimentacao, string AlteracaoPeso, string EmQuantoTempo, string ConsumoAgua, string ConsumoCafe, string ConsumoMensalSal, string ConsumoAcucar, string ConsumoOleoBanha, string OndeFazRefeicoes, string QuemPreparaRefeicoes, string VelocidadeRefeicao, string AcompanhamentoRefeicao, string PreferenciasAlimentares, string RestricoesAlimentares)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.DataAvaliacao = DataAvaliacao;
            this.Idade = Idade;
            this.DataNascimento = DataNascimento;
            this.MotivoConsulta = MotivoConsulta;
            this.EncaminhadoPor = EncaminhadoPor;
            this.Convenio = Convenio;
            this.Telefone = Telefone;
            this.Endereco = Endereco;
            this.Escolaridade = Escolaridade;
            this.Profissao = Profissao;
            this.NumeroPessoasCasa = NumeroPessoasCasa;
            this.NumeroAdulto = NumeroAdulto;
            this.NumeroCrianca = NumeroCrianca;
            this.EstadoCivil = EstadoCivil;
            this.ProblemaSaude = ProblemaSaude;
            this.QualProblemaSaude = QualProblemaSaude;
            this.Diabetes = Diabetes;
            this.Hipertensao = Hipertensao;
            this.Obesidade = Obesidade;
            this.Dislipidemia = Dislipidemia;
            this.OutrosProblemas = OutrosProblemas;
            this.AntecedenteDiabetes = AntecedenteDiabetes;
            this.AntecedenteHipertensao = AntecedenteHipertensao;
            this.AntecedenteObesidade = AntecedenteObesidade;
            this.AntecedenteDislipidemia = AntecedenteDislipidemia;
            this.OutrosAntecedentes = OutrosAntecedentes;
            this.HabitoIntestinal = HabitoIntestinal;
            this.CaracteristicaFezes = CaracteristicaFezes;
            this.HabitoUrinario = HabitoUrinario;
            this.HorasSono = HorasSono;
            this.AtividadeFisica = AtividadeFisica;
            this.FrequenciaAtividadeFisica = FrequenciaAtividadeFisica;
            this.Fuma = Fuma;
            this.QuantoFuma = QuantoFuma;
            this.HaQuantoTempoFuma = HaQuantoTempoFuma;
            this.FazUsoBebidaAlcoolica = FazUsoBebidaAlcoolica;
            this.TipoBebida = TipoBebida;
            this.HaQuantoTempoBebida = HaQuantoTempoBebida;
            this.FazUsoLaxante = FazUsoLaxante;
            this.PorQuantoTempoLaxante = PorQuantoTempoLaxante;
            this.FazUsoMedicamento = FazUsoMedicamento;
            this.HaQuantoTempoMedicamento = HaQuantoTempoMedicamento;
            this.QuaisMedicamentos = QuaisMedicamentos;
            this.IntoleranciaOuAversaoAlimentar = IntoleranciaOuAversaoAlimentar;
            this.QualIntolerancia = QualIntolerancia;
            this.HaQuantoTempoIntolerancia = HaQuantoTempoIntolerancia;
            this.ControleAlimentacao = ControleAlimentacao;
            this.QualControleAlimentacao = QualControleAlimentacao;
            this.AlteracaoPeso = AlteracaoPeso;
            this.EmQuantoTempo = EmQuantoTempo;
            this.ConsumoAgua = ConsumoAgua;
            this.ConsumoCafe = ConsumoCafe;
            this.ConsumoMensalSal = ConsumoMensalSal;
            this.ConsumoAcucar = ConsumoAcucar;
            this.ConsumoOleoBanha = ConsumoOleoBanha;
            this.OndeFazRefeicoes = OndeFazRefeicoes;
            this.QuemPreparaRefeicoes = QuemPreparaRefeicoes;
            this.VelocidadeRefeicao = VelocidadeRefeicao;
            this.AcompanhamentoRefeicao = AcompanhamentoRefeicao;
            this.PreferenciasAlimentares = PreferenciasAlimentares;
            this.RestricoesAlimentares = RestricoesAlimentares;
        }
        [Required(ErrorMessage = "O campo ID é obrigatório")]
        public Guid ID { get; set; }//---

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }//---

        [Required(ErrorMessage = "A data de avaliação é obrigatória")]
        public string DataAvaliacao { get; set; }//---

        [Required(ErrorMessage = "A idade é obrigatória")]
        public int Idade { get; set; }//---

        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        public string DataNascimento { get; set; }//----

        [Required(ErrorMessage = "O motivo da consulta é obrigatório")]
        public string MotivoConsulta { get; set; }//---

        [Required(ErrorMessage = "O campo encaminhado por é obrigatório")]
        public string EncaminhadoPor { get; set; }//---

        [Required(ErrorMessage = "O campo convênio é obrigatório")]
        public string Convenio { get; set; }//---

        [Required(ErrorMessage = "O telefone é obrigatório")]
        public string Telefone { get; set; }//---

        [Required(ErrorMessage = "O endereço é obrigatório")]
        public string Endereco { get; set; }//---

        [Required(ErrorMessage = "A escolaridade é obrigatória")]
        public string Escolaridade { get; set; }//----

        [Required(ErrorMessage = "A profissão é obrigatória")]
        public string Profissao { get; set; }//---

        [Required(ErrorMessage = "O número de pessoas na casa é obrigatório")]
        public string NumeroPessoasCasa { get; set; }//---

        [Required(ErrorMessage = "O número de adultos é obrigatório")]
        public string NumeroAdulto { get; set; }//---

        [Required(ErrorMessage = "O número de crianças é obrigatório")]
        public string NumeroCrianca { get; set; }//---

        [Required(ErrorMessage = "O estado civil é obrigatório")]
        public string EstadoCivil { get; set; }//---

        [Required(ErrorMessage = "O campo problema de saúde é obrigatório")]
        public string ProblemaSaude { get; set; }//---

        public string QualProblemaSaude { get; set; }

        [Required(ErrorMessage = "O campo diabetes é obrigatório")]
        public string Diabetes { get; set; }//---

        [Required(ErrorMessage = "O campo hipertensão é obrigatório")]
        public string Hipertensao { get; set; }//---

        [Required(ErrorMessage = "O campo obesidade é obrigatório")]
        public string Obesidade { get; set; }//---

        [Required(ErrorMessage = "O campo dislipidemia é obrigatório")]
        public string Dislipidemia { get; set; }//---

        [Required(ErrorMessage = "Outros problemas de saúde")]
        public string OutrosProblemas { get; set; }//---

        // Antecedentes familiares
        [Required(ErrorMessage = "Antecedente de diabetes é obrigatório")]
        public string AntecedenteDiabetes { get; set; }//---

        [Required(ErrorMessage = "Antecedente de hipertensão é obrigatório")]
        public string AntecedenteHipertensao { get; set; }//---

        [Required(ErrorMessage = "Antecedente de obesidade é obrigatório")]
        public string AntecedenteObesidade { get; set; }//---

        [Required(ErrorMessage = "Antecedente de dislipidemia é obrigatório")]
        public string AntecedenteDislipidemia { get; set; }//---

        public string OutrosAntecedentes { get; set; }//---

        [Required(ErrorMessage = "O hábito intestinal é obrigatório")]
        public string HabitoIntestinal { get; set; }//---

        [Required(ErrorMessage = "A característica das fezes é obrigatória")]
        public string CaracteristicaFezes { get; set; }//---

        [Required(ErrorMessage = "O hábito urinário é obrigatório")]
        public string HabitoUrinario { get; set; }//---

        [Required(ErrorMessage = "O número de horas de sono é obrigatório")]
        public string HorasSono { get; set; }//---

        [Required(ErrorMessage = "O campo atividade física é obrigatório")]
        public string AtividadeFisica { get; set; }//---

        [Required(ErrorMessage = "A frequência da atividade física é obrigatória")]
        public string FrequenciaAtividadeFisica { get; set; }//---

        [Required(ErrorMessage = "O campo fumar é obrigatório")]
        public string Fuma { get; set; }//--

        public string QuantoFuma { get; set; }//--

        public string HaQuantoTempoFuma { get; set; }//---

        [Required(ErrorMessage = "Faz uso de bebida alcoólica?")]
        public string FazUsoBebidaAlcoolica { get; set; }//---

        [Required(ErrorMessage = "Qual o tipo de bebida?")]
        public string TipoBebida { get; set; }//---

      
        public string HaQuantoTempoBebida { get; set; }//---

   
        public string FazUsoLaxante { get; set; }//---


        public string PorQuantoTempoLaxante { get; set; }//---

        [Required(ErrorMessage = "Faz uso de medicamento?")]
        public string FazUsoMedicamento { get; set; }//---


        public string HaQuantoTempoMedicamento { get; set; }//---


        public string QuaisMedicamentos { get; set; }//---

        [Required(ErrorMessage = "Intolerância ou aversão alimentar?")]
        public string IntoleranciaOuAversaoAlimentar { get; set; }//---

   
        public string QualIntolerancia { get; set; }//---

        [Required(ErrorMessage = "Há quanto tempo tem intolerância?")]
        public string HaQuantoTempoIntolerancia { get; set; }//---

      
        public string ControleAlimentacao { get; set; }//---


        public string QualControleAlimentacao { get; set; }//---

        [Required(ErrorMessage = "Alteração de peso?")]
        public string AlteracaoPeso { get; set; }//---

        public string EmQuantoTempo { get; set; }//---

        [Required(ErrorMessage = "Consumo de água?")]
        public string ConsumoAgua { get; set; }//---

        [Required(ErrorMessage = "Consumo de café?")]
        public string ConsumoCafe { get; set; }//---

        [Required(ErrorMessage = "Consumo mensal de sal?")]
        public string ConsumoMensalSal { get; set; }//---

        [Required(ErrorMessage = "Consumo de açúcar?")]
        public string ConsumoAcucar { get; set; }//---

        [Required(ErrorMessage = "Consumo de óleo/banha?")]
        public string ConsumoOleoBanha { get; set; }//---

        [Required(ErrorMessage = "Onde faz as refeições?")]
        public string OndeFazRefeicoes { get; set; }//---

        [Required(ErrorMessage = "Quem prepara as refeições?")]
        public string QuemPreparaRefeicoes { get; set; }//---

        [Required(ErrorMessage = "Qual a velocidade das refeições?")]
        public string VelocidadeRefeicao { get; set; }//---

        [Required(ErrorMessage = "Acompanhamento da refeição?")]
        public string AcompanhamentoRefeicao { get; set; }//---

        [Required(ErrorMessage = "Preferências alimentares?")]
        public string PreferenciasAlimentares { get; set; }//---

        [Required(ErrorMessage = "Restrições alimentares?")]
        public string RestricoesAlimentares { get; set; }//---
    }
}
