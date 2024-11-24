using System;
using System.ComponentModel.DataAnnotations;

namespace Asilo.Models
{
    public class ProntuarioEnfermagem
    {
        
        public ProntuarioEnfermagem(Guid ID, string Nome, string DataNascimento, string DataExame, string NivelConciencia, string PupilasSituacao, string PupilaPD, string PupilaPE, string Fotorreacao, string SistemaCardioCirculatorio, string CarotideosEsquerdo, string CarotideosDireito, string BraquiaisEsquerdo, string BraquiaisDireito, string RadiaisEsquerdo, string RadiaisDireito, string FemoraisEsquerdo, string FemoraisDireito, string PediososEsquerdo, string PediososDireito, string PopliteosEsquerdo, string PopliteosDireito, string PerfusaoPeriferica, string Edema, string Padrao, string MurmurioVesicular, string ExpansaoTorax, string RuidosAdventicios, string AceitacaoDieta, string Denticao, string Abdome, string Rha, string Massa, string Evacuacao, string Genito, string Urina, string Vesical, string Cutanea, string Sensorial, string Umidade, string Atividade, string Mobilidade, string Nutricao, string Friccao, string DiagnosticosEnfermagem, string ControleSinaisVitaisData, string ControleSinaisVitaisHorario, string ControleSinaisVitaisPa, string ControleSinaisVitaisFc, string ControleSinaisVitaisFr, string ControleSinaisVitaisTemp, string ControleSinaisVitaisPvc, string ControleSinaisVitaisGlicemia, string ControleSinaisVitaisAnotacoes)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;//Alteração
            this.DataExame = DataExame;//Alteração
            this.NivelConciencia = NivelConciencia;
            this.PupilasSituacao = PupilasSituacao;
            this.PupilaPD = PupilaPD;
            this.PupilaPE = PupilaPE;
            this.Fotorreacao = Fotorreacao;
            this.SistemaCardioCirculatorio = SistemaCardioCirculatorio;
            this.CarotideosEsquerdo = CarotideosEsquerdo;
            this.CarotideosDireito = CarotideosDireito;
            this.BraquiaisEsquerdo = BraquiaisEsquerdo;
            this.BraquiaisDireito = BraquiaisDireito;
            this.RadiaisEsquerdo = RadiaisEsquerdo;
            this.RadiaisDireito = RadiaisDireito;
            this.FemoraisEsquerdo = FemoraisEsquerdo;
            this.FemoraisDireito = FemoraisDireito;
            this.PediososEsquerdo = PediososEsquerdo;
            this.PediososDireito = PediososDireito;
            this.PopliteosEsquerdo = PopliteosEsquerdo;
            this.PopliteosDireito = PopliteosDireito;
            this.PerfusaoPeriferica = PerfusaoPeriferica;
            this.Edema = Edema;
            this.Padrao = Padrao;
            this.MurmurioVesicular = MurmurioVesicular;
            this.ExpansaoTorax = ExpansaoTorax;
            this.RuidosAdventicios = RuidosAdventicios;
            this.AceitacaoDieta = AceitacaoDieta;
            this.Denticao = Denticao;
            this.Abdome = Abdome;
            this.Rha = Rha;
            this.Massa = Massa;
            this.Evacuacao = Evacuacao;
            this.Genito = Genito;
            this.Urina = Urina;
            this.Vesical = Vesical;
            this.Cutanea = Cutanea;
            this.Sensorial = Sensorial;
            this.Umidade = Umidade;
            this.Atividade = Atividade;
            this.Mobilidade = Mobilidade;
            this.Nutricao = Nutricao;
            this.Friccao = Friccao;
            this.DiagnosticosEnfermagem = DiagnosticosEnfermagem;
            this.ControleSinaisVitaisData = ControleSinaisVitaisData;
            this.ControleSinaisVitaisHorario = ControleSinaisVitaisHorario;
            this.ControleSinaisVitaisPa = ControleSinaisVitaisPa;
            this.ControleSinaisVitaisFc = ControleSinaisVitaisFc;
            this.ControleSinaisVitaisFr = ControleSinaisVitaisFr;
            this.ControleSinaisVitaisTemp = ControleSinaisVitaisTemp;
            this.ControleSinaisVitaisPvc = ControleSinaisVitaisPvc;
            this.ControleSinaisVitaisGlicemia = ControleSinaisVitaisGlicemia;
            this.ControleSinaisVitaisAnotacoes = ControleSinaisVitaisAnotacoes;
        }
        public Guid ID { get; set; } //---

        [Required(ErrorMessage = "O nome � obrigat�rio")]
        public string Nome { get; set; } //---

        [Required(ErrorMessage = "A data de nascimento � obrigat�ria")]
        public string DataNascimento { get; set; } //---

        [Required(ErrorMessage = "A data do exame � obrigat�ria")]
        public string DataExame { get; set; } //---

        [Required(ErrorMessage = "O n�vel de consci�ncia � obrigat�rio")]
        public string NivelConciencia { get; set; } //---

        [Required(ErrorMessage = "A situa��o das pupilas � obrigat�ria")]
        public string PupilasSituacao { get; set; } //--

        [Required(ErrorMessage = "O campo Pupila PD � obrigat�rio")]
        public string PupilaPD { get; set; } //---

        [Required(ErrorMessage = "O campo Pupila PE � obrigat�rio")]
        public string PupilaPE { get; set; } //---

        [Required(ErrorMessage = "A fotorrea��o � obrigat�ria")]
        public string Fotorreacao { get; set; } //---

        [Required(ErrorMessage = "O sistema cardiorrespirat�rio � obrigat�rio")]
        public string SistemaCardioCirculatorio { get; set; } //---

        [Required(ErrorMessage = "O campo Carot�deos Esquerdo � obrigat�rio")]
        public string CarotideosEsquerdo { get; set; } //---

        [Required(ErrorMessage = "O campo Carot�deos Direito � obrigat�rio")]
        public string CarotideosDireito { get; set; } //---

        [Required(ErrorMessage = "O campo Braquiais Esquerdo � obrigat�rio")]
        public string BraquiaisEsquerdo { get; set; } //---

        [Required(ErrorMessage = "O campo Braquiais Direito � obrigat�rio")]
        public string BraquiaisDireito { get; set; }//---

        [Required(ErrorMessage = "O campo Radiais Esquerdo � obrigat�rio")]
        public string RadiaisEsquerdo { get; set; }//---

        [Required(ErrorMessage = "O campo Radiais Direito � obrigat�rio")]
        public string RadiaisDireito { get; set; } //---

        [Required(ErrorMessage = "O campo Femurais Esquerdo � obrigat�rio")]
        public string FemoraisEsquerdo { get; set; } //---

        [Required(ErrorMessage = "O campo Femurais Direito � obrigat�rio")]
        public string FemoraisDireito { get; set; } //---

        [Required(ErrorMessage = "O campo Pediosos Esquerdo � obrigat�rio")]
        public string PediososEsquerdo { get; set; } //---

        [Required(ErrorMessage = "O campo Pediosos Direito � obrigat�rio")]
        public string PediososDireito { get; set; } //---

        [Required(ErrorMessage = "O campo Popliteos Esquerdo � obrigat�rio")]
        public string PopliteosEsquerdo { get; set; } //---

        [Required(ErrorMessage = "O campo Popliteos Direito � obrigat�rio")]
        public string PopliteosDireito { get; set; } //---

        [Required(ErrorMessage = "A perfus�o perif�rica � obrigat�ria")]
        public string PerfusaoPeriferica { get; set; } //---

        [Required(ErrorMessage = "O campo Edema � obrigat�rio")]
        public string Edema { get; set; }//---

        [Required(ErrorMessage = "O padr�o � obrigat�rio")]
        public string Padrao { get; set; } //---

        [Required(ErrorMessage = "O murm�rio vesicular � obrigat�rio")]
        public string MurmurioVesicular { get; set; } //---

        [Required(ErrorMessage = "A expans�o do t�rax � obrigat�ria")]
        public string ExpansaoTorax { get; set; } //---

        [Required(ErrorMessage = "Os ru�dos advent�cios s�o obrigat�rios")]
        public string RuidosAdventicios { get; set; } //---

        [Required(ErrorMessage = "A aceita��o da dieta � obrigat�ria")]
        public string AceitacaoDieta { get; set; } //---

        [Required(ErrorMessage = "O campo denti��o � obrigat�rio")]
        public string Denticao { get; set; }//---

        [Required(ErrorMessage = "O abdome � obrigat�rio")]
        public string Abdome { get; set; }//---

        [Required(ErrorMessage = "O campo RHA � obrigat�rio")]
        public string Rha { get; set; }//---

        [Required(ErrorMessage = "O campo Massa � obrigat�rio")]
        public string Massa { get; set; }//---

        [Required(ErrorMessage = "O campo Evacua��o � obrigat�rio")]
        public string Evacuacao { get; set; }//---

        [Required(ErrorMessage = "O campo G�nito � obrigat�rio")]
        public string Genito { get; set; }//---

        [Required(ErrorMessage = "O campo Urina � obrigat�rio")]
        public string Urina { get; set; }//---

        [Required(ErrorMessage = "O campo Vesical � obrigat�rio")]
        public string Vesical { get; set; } //---

        [Required(ErrorMessage = "O campo Cut�nea � obrigat�rio")]
        public string Cutanea { get; set; } //---

        [Required(ErrorMessage = "O campo Sensorial � obrigat�rio")]
        public string Sensorial { get; set; }//---

        [Required(ErrorMessage = "O campo Umidade � obrigat�rio")]
        public string Umidade { get; set; }//---

        [Required(ErrorMessage = "O campo Atividade � obrigat�rio")]
        public string Atividade { get; set; }//---

        [Required(ErrorMessage = "O campo Mobilidade � obrigat�rio")]
        public string Mobilidade { get; set; } //---

        [Required(ErrorMessage = "O campo Nutri��o � obrigat�rio")]
        public string Nutricao { get; set; } //---

        [Required(ErrorMessage = "O campo Fric��o � obrigat�rio")]
        public string Friccao { get; set; }//---

        [Required(ErrorMessage = "O diagn�stico de enfermagem � obrigat�rio")]
        public string DiagnosticosEnfermagem { get; set; }//---

        [Required(ErrorMessage = "A data do controle de sinais vitais � obrigat�ria")]
        public string ControleSinaisVitaisData { get; set; }//----

        [Required(ErrorMessage = "O horário do controle de sinais vitais é obrigatório")]
        public string ControleSinaisVitaisHorario { get; set; }//---

        [Required(ErrorMessage = "A press�o arterial (PA) � obrigat�ria")]
        public string ControleSinaisVitaisPa { get; set; }//---

        [Required(ErrorMessage = "A frequ�ncia card�aca (FC) � obrigat�ria")]
        public string ControleSinaisVitaisFc { get; set; }//---

        [Required(ErrorMessage = "A frequ�ncia respirat�ria (FR) � obrigat�ria")]
        public string ControleSinaisVitaisFr { get; set; }//---

        [Required(ErrorMessage = "A temperatura � obrigat�ria")]
        public string ControleSinaisVitaisTemp { get; set; }//---

        [Required(ErrorMessage = "O campo PVC � obrigat�rio")]
        public string ControleSinaisVitaisPvc { get; set; }//---

        [Required(ErrorMessage = "A glicemia � obrigat�ria")]
        public string ControleSinaisVitaisGlicemia { get; set; }//---

        [Required(ErrorMessage = "As anota��es s�o obrigat�rias")]
        public string ControleSinaisVitaisAnotacoes { get; set; }//----
    }
}
