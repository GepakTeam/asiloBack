using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class ProntuarioFisioterapeuta
{
    public ProntuarioFisioterapeuta(Guid ID,string DataAvaliacao,string Nome,string Sexo,string Idade,string DataNascimento,string EstadoCivil,string Telefone,string Endereco,string ExamesComplementares,string Medicamentos,string DiagnosticoClinicoPatologico,string QueixaPrincipal,string HMA,string AVD,string AparelhoLocomotor,string AparelhoCardioRespiratorio,string AparelhoCardioVascular,string Ginecologico,string Outros,string DificuldadeComunicacao,string TipoMedicamento,string Dosagem, string Frequencia, string RemedioSemPrescricao, string HabilidadeManusear, string FrequenciaRefeicoes, string DietaEspecial, string IngestaoAlcool, string IngestaoHidrica, string UsaProtese, string Apetite, string PorqueApetite, string Demencia, string EscalaDepressao, string EstadoEmocional, string Peso, string Altura, string PA, string AuscultaCardiaca, string FrequenciaCardiaca, string AuscultaPulmonar, string FrequenciaRespiratoria, string PadraoRespiratorio, string OmbroFlexaoVR, string OmbroFlexaoAdmDireito, string OmbroFlexaoAdmEsquerdo, string OmbroExtensaoVR, string OmbroExtensaoAdmDireito, string OmbroExtensaoAdmEsquerdo, string OmbroAducaoVR, string OmbroAducaoAdmDireito, string OmbroAducaoAdmEsquerdo, string OmbroAbducaoVR, string OmbroAbducaoAdmDireito, string OmbroAbducaoAdmEsquerdo, string OmbroRotInternaVR, string OmbroRotInternaAdmDireito, string OmbroRotInternaAdmEsquerdo, string OmbroRotExternaVR, string OmbroRotExternaAdmDireito, string OmbroRotExternaAdmEsquerdo, string CotoveloFlexaoVR, string CotoveloFlexaoAdmDireito, string CotoveloFlexaoAdmEsquerdo, string CotoveloExtensaoVR, string CotoveloExtensaoAdmDireito, string CotoveloExtensaoAdmEsquerdo, string PunhoFlexaoVR, string PunhoFlexaoAdmDireito, string PunhoFlexaoAdmEsquerdo, string PunhoExtensaoVR, string PunhoExtensaoAdmDireito, string PunhoExtensaoAdmEsquerdo, string PunhoDesvioUlnarVR, string PunhoDesvioUlnarAdmDireito, string PunhoDesvioUlnarAdmEsquerdo, string PunhoDesvioRadialVR, string PunhoDesvioRadialAdmDireito, string PunhoDesvioRadialAdmEsquerdo, string QuadrilFlexaoVR, string QuadrilFlexaoAdmDireito, string QuadrilFlexaoAdmEsquerdo, string QuadrilExtensaoVR, string QuadrilExtensaoAdmDireito, string QuadrilExtensaoAdmEsquerdo, string QuadrilAducaoVR, string QuadrilAducaoAdmDireito, string QuadrilAducaoAdmEsquerdo, string QuadrilAbducaoVR, string QuadrilAbducaoAdmDireito, string QuadrilAbducaoAdmEsquerdo, string QuadrilRotInternaVR, string QuadrilRotInternaAdmDireito, string QuadrilRotInternaAdmEsquerdo, string QuadrilRotExternaVR, string QuadrilRotExternaAdmDireito, string QuadrilRotExternaAdmEsquerdo, string JoelhoFlexaoVR, string JoelhoFlexaoAdmDireito, string JoelhoFlexaoAdmEsquerdo,string JoelhoExtensaoVR, string JoelhoExtensaoAdmDireito, string JoelhoExtensaoAdmEsquerdo, string TornozeloEversaoVR, string TornozeloEversaoAdmDireito, string TornozeloEversaoAdmEsquerdo, string TornozeloDorsiflexaoVR, string TornozeloDorsiflexaoAdmDireito, string TornozeloDorsiflexaoAdmEsquerdo, string TornozeloFlexaoPlantarVR, string TornozeloFlexaoPlantarAdmDireito, string TornozeloFlexaoPlantarAdmEsquerdo, string TornozeloInversaoVR, string TornozeloInversaoAdmDireito, string TornozeloInversaoAdmEsquerdo, string TempoQuedas, string FrequenciaQuedas, string LocalQuedas, string Reflexo, string EquilibrioSentado, string EquilibrioEmPe, string EquilibrioSinalRosemberg, string AtividadeVidaDiaria, int EscalaDor, string RegiaoDor, string PeSagital, string PeFrontal, string JoelhoSagital, string JoelhoFrontal, string CinturaPelvicaSagital, string CinturaPelvicaFrontal, string ColunaSagital, string ColunaFrontal, string CinturaEscapularSagital, string CinturaEscapularFrontal, string CabecaSagital, string CabecaFrontal, string AvaliacaoMarcha, string Observacoes, string DiagnosticoFuncional, string ObjetivosFisioterapicos)
    {
        this.ID = ID;
        this.DataAvaliacao = DataAvaliacao;
        this.Nome = Nome;
        this.Sexo = Sexo;
        this.Idade = Idade;
        this.DataNascimento = DataNascimento;
        this.EstadoCivil = EstadoCivil;
        this.Telefone = Telefone;
        this.Endereco = Endereco;
        this.ExamesComplementares = ExamesComplementares;
        this.Medicamentos = Medicamentos;
        this.DiagnosticoClinicoPatologico = DiagnosticoClinicoPatologico;
        this.QueixaPrincipal = QueixaPrincipal;
        this.HMA = HMA;
        this.AVD = AVD;
        this.AparelhoLocomotor = AparelhoLocomotor;
        this.AparelhoCardioRespiratorio = AparelhoCardioRespiratorio;
        this.AparelhoCardioVascular = AparelhoCardioVascular;
        this.Ginecologico = Ginecologico;
        this.Outros = Outros;
        this.DificuldadeComunicacao = DificuldadeComunicacao;
        this.TipoMedicamento = TipoMedicamento;
        this.Dosagem = Dosagem;
        this.Frequencia = Frequencia;
        this.RemedioSemPrescricao = RemedioSemPrescricao;
        this.HabilidadeManusear = HabilidadeManusear;
        this.FrequenciaRefeicoes = FrequenciaRefeicoes;
        this.DietaEspecial = DietaEspecial;
        this.IngestaoAlcool = IngestaoAlcool;
        this.IngestaoHidrica = IngestaoHidrica;
        this.UsaProtese = UsaProtese;
        this.Apetite = Apetite;
        this.PorqueApetite = PorqueApetite;
        this.Demencia = Demencia;
        this.EscalaDepressao = EscalaDepressao;
        this.EstadoEmocional = EstadoEmocional;
        this.Peso = Peso;
        this.Altura = Altura;
        this.PA = PA;
        this.AuscultaCardiaca = AuscultaCardiaca;
        this.FrequenciaCardiaca = FrequenciaCardiaca;
        this.AuscultaPulmonar = AuscultaPulmonar;
        this.FrequenciaRespiratoria = FrequenciaRespiratoria;
        this.PadraoRespiratorio = PadraoRespiratorio;
        this.OmbroFlexaoVR = OmbroFlexaoVR;
        this.OmbroFlexaoAdmDireito = OmbroFlexaoAdmDireito;
        this.OmbroFlexaoAdmEsquerdo = OmbroFlexaoAdmEsquerdo;
        this.OmbroExtensaoVR = OmbroExtensaoVR;
        this.OmbroExtensaoAdmDireito = OmbroExtensaoAdmDireito;
        this.OmbroExtensaoAdmEsquerdo = OmbroExtensaoAdmEsquerdo;
        this.OmbroAducaoVR = OmbroAducaoVR;
        this.OmbroAducaoAdmDireito = OmbroAducaoAdmDireito;
        this.OmbroAducaoAdmEsquerdo = OmbroAducaoAdmEsquerdo;
        this.OmbroAbducaoVR = OmbroAbducaoVR;
        this.OmbroAbducaoAdmDireito = OmbroAbducaoAdmDireito;
        this.OmbroAbducaoAdmEsquerdo = OmbroAbducaoAdmEsquerdo;
        this.OmbroRotInternaVR = OmbroRotInternaVR;
        this.OmbroRotInternaAdmDireito = OmbroRotInternaAdmDireito;
        this.OmbroRotInternaAdmEsquerdo = OmbroRotInternaAdmEsquerdo;
        this.OmbroRotExternaVR = OmbroRotExternaVR;
        this.OmbroRotExternaAdmDireito = OmbroRotExternaAdmDireito;
        this.OmbroRotExternaAdmEsquerdo = OmbroRotExternaAdmEsquerdo;
        this.CotoveloFlexaoVR = CotoveloFlexaoVR;
        this.CotoveloFlexaoAdmDireito = CotoveloFlexaoAdmDireito;
        this.CotoveloFlexaoAdmEsquerdo = CotoveloFlexaoAdmEsquerdo;
        this.CotoveloExtensaoVR = CotoveloExtensaoVR;
        this.CotoveloExtensaoAdmDireito = CotoveloExtensaoAdmDireito;
        this.CotoveloExtensaoAdmEsquerdo = CotoveloExtensaoAdmEsquerdo;
        this.PunhoFlexaoVR = PunhoFlexaoVR;
        this.PunhoFlexaoAdmDireito = PunhoFlexaoAdmDireito;
        this.PunhoFlexaoAdmEsquerdo = PunhoFlexaoAdmEsquerdo;
        this.PunhoExtensaoVR = PunhoExtensaoVR;
        this.PunhoExtensaoAdmDireito = PunhoExtensaoAdmDireito;
        this.PunhoExtensaoAdmEsquerdo = PunhoExtensaoAdmEsquerdo;
        this.PunhoDesvioUlnarVR = PunhoDesvioUlnarVR;
        this.PunhoDesvioUlnarAdmDireito = PunhoDesvioUlnarAdmDireito;
        this.PunhoDesvioUlnarAdmEsquerdo = PunhoDesvioUlnarAdmEsquerdo;
        this.PunhoDesvioRadialVR = PunhoDesvioRadialVR;
        this.PunhoDesvioRadialAdmDireito = PunhoDesvioRadialAdmDireito;
        this.PunhoDesvioRadialAdmEsquerdo = PunhoDesvioRadialAdmEsquerdo;
        this.QuadrilFlexaoVR = QuadrilFlexaoVR;
        this.QuadrilFlexaoAdmDireito = QuadrilFlexaoAdmDireito;
        this.QuadrilFlexaoAdmEsquerdo = QuadrilFlexaoAdmEsquerdo;
        this.QuadrilExtensaoVR = QuadrilExtensaoVR;
        this.QuadrilExtensaoAdmDireito = QuadrilExtensaoAdmDireito;
        this.QuadrilExtensaoAdmEsquerdo = QuadrilExtensaoAdmEsquerdo;
        this.QuadrilAducaoVR = QuadrilAducaoVR;
        this.QuadrilAducaoAdmDireito = QuadrilAducaoAdmDireito;
        this.QuadrilAducaoAdmEsquerdo = QuadrilAducaoAdmEsquerdo;
        this.QuadrilAbducaoVR = QuadrilAbducaoVR;
        this.QuadrilAbducaoAdmDireito = QuadrilAbducaoAdmDireito;
        this.QuadrilAbducaoAdmEsquerdo = QuadrilAbducaoAdmEsquerdo;
        this.QuadrilRotInternaVR = QuadrilRotInternaVR;
        this.QuadrilRotInternaAdmDireito = QuadrilRotInternaAdmDireito;
        this.QuadrilRotInternaAdmEsquerdo = QuadrilRotInternaAdmEsquerdo;
        this.QuadrilRotExternaVR = QuadrilRotExternaVR;
        this.QuadrilRotExternaAdmDireito = QuadrilRotExternaAdmDireito;
        this.QuadrilRotExternaAdmEsquerdo = QuadrilRotExternaAdmEsquerdo;
        this.JoelhoFlexaoVR = JoelhoFlexaoVR;
        this.JoelhoFlexaoAdmDireito = JoelhoFlexaoAdmDireito;
        this.JoelhoFlexaoAdmEsquerdo = JoelhoFlexaoAdmEsquerdo;
        this.JoelhoExtensaoVR = JoelhoExtensaoVR;
        this.JoelhoExtensaoAdmDireito = JoelhoExtensaoAdmDireito;
        this.JoelhoExtensaoAdmEsquerdo = JoelhoExtensaoAdmEsquerdo;
        this.TornozeloEversaoVR = TornozeloEversaoVR;
        this.TornozeloEversaoAdmDireito = TornozeloEversaoAdmDireito;
        this.TornozeloEversaoAdmEsquerdo = TornozeloEversaoAdmEsquerdo;
        this.TornozeloDorsiflexaoVR = TornozeloDorsiflexaoVR;
        this.TornozeloDorsiflexaoAdmDireito = TornozeloDorsiflexaoAdmDireito;
        this.TornozeloDorsiflexaoAdmEsquerdo = TornozeloDorsiflexaoAdmEsquerdo;
        this.TornozeloFlexaoPlantarVR = TornozeloFlexaoPlantarVR;
        this.TornozeloFlexaoPlantarAdmDireito = TornozeloFlexaoPlantarAdmDireito;
        this.TornozeloFlexaoPlantarAdmEsquerdo = TornozeloFlexaoPlantarAdmEsquerdo;
        this.TornozeloInversaoVR = TornozeloInversaoVR;
        this.TornozeloInversaoAdmDireito = TornozeloInversaoAdmDireito;
        this.TornozeloInversaoAdmEsquerdo = TornozeloInversaoAdmEsquerdo;
        this.TempoQuedas = TempoQuedas;
        this.FrequenciaQuedas = FrequenciaQuedas;
        this.LocalQuedas = LocalQuedas;
        this.Reflexo = Reflexo;
        this.EquilibrioSentado = EquilibrioSentado;
        this.EquilibrioEmPe = EquilibrioEmPe;
        this.EquilibrioSinalRosemberg = EquilibrioSinalRosemberg;
        this.AtividadeVidaDiaria = AtividadeVidaDiaria;
        this.EscalaDor = EscalaDor;
        this.RegiaoDor = RegiaoDor;
        this.PeSagital = PeSagital;
        this.PeFrontal = PeFrontal;
        this.JoelhoSagital = JoelhoSagital;
        this.JoelhoFrontal = JoelhoFrontal;
        this.CinturaPelvicaSagital = CinturaPelvicaSagital;
        this.CinturaPelvicaFrontal = CinturaPelvicaFrontal;
        this.ColunaSagital = ColunaSagital;
        this.ColunaFrontal = ColunaFrontal;
        this.CinturaEscapularSagital = CinturaEscapularSagital;
        this.CinturaEscapularFrontal = CinturaEscapularFrontal;
        this.CabecaSagital = CabecaSagital;
        this.CabecaFrontal = CabecaFrontal;
        this.AvaliacaoMarcha = AvaliacaoMarcha;
        this.Observacoes = Observacoes;
        this.DiagnosticoFuncional = DiagnosticoFuncional;
        this.ObjetivosFisioterapicos = ObjetivosFisioterapicos;
    }

    [Key]
    public Guid ID { get; set; }//---

    [Required(ErrorMessage = "O campo Data de Avaliação é obrigatório")]
    public string DataAvaliacao { get; set; }//---

    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MaxLength(100)]
    public string Nome { get; set; }//---

    [Required(ErrorMessage = "O campo Sexo é obrigatório")]
    public string Sexo { get; set; }//---

    [Required(ErrorMessage = "O campo Idade é obrigatório")]
    public string Idade { get; set; }//---

    [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
    public string DataNascimento { get; set; }//---

    [Required(ErrorMessage = "O campo Estado Civil é obrigatório")]
    public string EstadoCivil { get; set; }//---

    [Required(ErrorMessage = "O campo Telefone é obrigatório")]
    [MaxLength(15)]
    public string Telefone { get; set; }//---

    [Required(ErrorMessage = "O campo Endereço é obrigatório")]
    [MaxLength(200)]
    public string Endereco { get; set; }//---

    [Required(ErrorMessage = "O campo Exames Complementares é obrigatório")]
    [MaxLength(500)]
    public string ExamesComplementares { get; set; }//---

    [Required(ErrorMessage = "O campo Medicamentos é obrigatório")]
    [MaxLength(500)]
    public string Medicamentos { get; set; }//---

    [Required(ErrorMessage = "O campo Diagnóstico Clínico Patológico é obrigatório")]
    [MaxLength(500)]
    public string DiagnosticoClinicoPatologico { get; set; }//---

    [Required(ErrorMessage = "O campo Queixa Principal é obrigatório")]
    [MaxLength(500)]
    public string QueixaPrincipal { get; set; }//---

    [Required(ErrorMessage = "O campo HMA é obrigatório")]
    [MaxLength(500)]
    public string HMA { get; set; }//---

    [Required(ErrorMessage = "O campo AVD é obrigatório")]
    [MaxLength(500)]
    public string AVD { get; set; }//---

    [Required(ErrorMessage = "O campo Aparelho Locomotor é obrigatório")]
    [MaxLength(500)]
    public string AparelhoLocomotor { get; set; }//---

    [Required(ErrorMessage = "O campo Aparelho Cardio Respiratório é obrigatório")]
    [MaxLength(500)]
    public string AparelhoCardioRespiratorio { get; set; }//---

    [Required(ErrorMessage = "O campo Aparelho Cardio Vascular é obrigatório")]
    [MaxLength(500)]
    public string AparelhoCardioVascular { get; set; }//---

    [Required(ErrorMessage = "O campo Ginecológico é obrigatório")]
    [MaxLength(500)]
    public string Ginecologico { get; set; }//---

    [Required(ErrorMessage = "O campo Outros é obrigatório")]
    [MaxLength(500)]
    public string Outros { get; set; }//---

    [Required(ErrorMessage = "O campo Dificuldade de Comunicação é obrigatório")]
    public string DificuldadeComunicacao { get; set; }//---

    [Required(ErrorMessage = "O campo Tipo de Medicamento é obrigatório")]
    [MaxLength(100)]
    public string TipoMedicamento { get; set; }//---

    [Required(ErrorMessage = "O campo Dosagem é obrigatório")]
    [MaxLength(100)]
    public string Dosagem { get; set; }//---

    [Required(ErrorMessage = "O campo Frequência é obrigatório")]
    [MaxLength(100)]
    public string Frequencia { get; set; }//---

    [Required(ErrorMessage = "O campo Remédio Sem Prescrição é obrigatório")]
    [MaxLength(500)]
    public string RemedioSemPrescricao { get; set; }//---

    [Required(ErrorMessage = "O campo Habilidade de Manuseio é obrigatório")]
    [MaxLength(100)]
    public string HabilidadeManusear { get; set; }//---

    [Required(ErrorMessage = "O campo Frequência das Refeições é obrigatório")]
    [MaxLength(100)]
    public string FrequenciaRefeicoes { get; set; }//---

    [Required(ErrorMessage = "O campo Dieta Especial é obrigatório")]
    [MaxLength(100)]
    public string DietaEspecial { get; set; }//---

    [Required(ErrorMessage = "O campo Ingestão de Álcool é obrigatório")]
    [MaxLength(100)]
    public string IngestaoAlcool { get; set; }//---

    [Required(ErrorMessage = "O campo Ingestão Hídrica é obrigatório")]
    [MaxLength(100)]
    public string IngestaoHidrica { get; set; }//---

    [Required(ErrorMessage = "O campo Usa Prótese é obrigatório")]
    public string UsaProtese { get; set; }//---

    [Required(ErrorMessage = "O campo Apetite é obrigatório")]
    public string Apetite { get; set; }//---

    [Required(ErrorMessage = "O campo Porque Apetite é obrigatório")]
    [MaxLength(500)]
    public string PorqueApetite { get; set; }//---

    [Required(ErrorMessage = "O campo Demência é obrigatório")]
    [MaxLength(500)]
    public string Demencia { get; set; }//---

    [Required(ErrorMessage = "O campo Escala de Depressão é obrigatório")]
    [MaxLength(100)]
    public string EscalaDepressao { get; set; }//---

    [Required(ErrorMessage = "O campo Estado Emocional é obrigatório")]
    [MaxLength(100)]
    public string EstadoEmocional { get; set; }//---

    [Required(ErrorMessage = "O campo Peso é obrigatório")]
    [MaxLength(10)]
    public string Peso { get; set; }//---

    [Required(ErrorMessage = "O campo Altura é obrigatório")]
    [MaxLength(10)]
    public string Altura { get; set; }//---

    [Required(ErrorMessage = "O campo PA é obrigatório")]
    [MaxLength(10)]
    public string PA { get; set; }//---

    [Required(ErrorMessage = "O campo Ausculta Cardíaca é obrigatório")]
    [MaxLength(500)]
    public string AuscultaCardiaca { get; set; }//---

    [Required(ErrorMessage = "O campo Frequência Cardíaca é obrigatório")]
    [MaxLength(100)]
    public string FrequenciaCardiaca { get; set; }//---

    [Required(ErrorMessage = "O campo Ausculta Pulmonar é obrigatório")]
    [MaxLength(500)]
    public string AuscultaPulmonar { get; set; }//---

    [Required(ErrorMessage = "O campo Frequência Respiratória é obrigatório")]
    [MaxLength(100)]
    public string FrequenciaRespiratoria { get; set; }//---

    [Required(ErrorMessage = "O campo Padrão Respiratório é obrigatório")]
    [MaxLength(100)]
    public string PadraoRespiratorio { get; set; }//---

    // Ombro - Flexão
    [Required(ErrorMessage = "O campo Ombro - Flexão VR é obrigatório")]
    [MaxLength(100)]
    public string OmbroFlexaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Flexão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string OmbroFlexaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Flexão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string OmbroFlexaoAdmEsquerdo { get; set; }//---

    // Ombro - Extensão
    [Required(ErrorMessage = "O campo Ombro - Extensão VR é obrigatório")]
    [MaxLength(100)]
    public string OmbroExtensaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Extensão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string OmbroExtensaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Extensão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string OmbroExtensaoAdmEsquerdo { get; set; }//---

    // Ombro - Adução
    [Required(ErrorMessage = "O campo Ombro - Adução VR é obrigatório")]
    [MaxLength(100)]
    public string OmbroAducaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Adução Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string OmbroAducaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Adução Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string OmbroAducaoAdmEsquerdo { get; set; }//---

    // Ombro - Abdução
    [Required(ErrorMessage = "O campo Ombro - Abdução VR é obrigatório")]
    [MaxLength(100)]
    public string OmbroAbducaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Abdução Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string OmbroAbducaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Abdução Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string OmbroAbducaoAdmEsquerdo { get; set; }//---

    // Ombro - Rotação Interna
    [Required(ErrorMessage = "O campo Ombro - Rotação Interna VR é obrigatório")]
    [MaxLength(100)]
    public string OmbroRotInternaVR{ get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Rotação Interna Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string OmbroRotInternaAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Rotação Interna Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string OmbroRotInternaAdmEsquerdo { get; set; }//---

    // Ombro - Rotação Externa
    [Required(ErrorMessage = "O campo Ombro - Rotação Externa VR é obrigatório")]
    [MaxLength(100)]
    public string OmbroRotExternaVR { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Rotação Externa Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string OmbroRotExternaAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Ombro - Rotação Externa Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string OmbroRotExternaAdmEsquerdo { get; set; }//---

    // Cotovelo - Flexão
    [Required(ErrorMessage = "O campo Cotovelo - Flexão VR é obrigatório")]
    [MaxLength(100)]
    public string CotoveloFlexaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Cotovelo - Flexão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string CotoveloFlexaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Cotovelo - Flexão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string CotoveloFlexaoAdmEsquerdo { get; set; }//---

    // Cotovelo - Extensão
    [Required(ErrorMessage = "O campo Cotovelo - Extensão VR é obrigatório")]
    [MaxLength(100)]
    public string CotoveloExtensaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Cotovelo - Extensão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string CotoveloExtensaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Cotovelo - Extensão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string CotoveloExtensaoAdmEsquerdo { get; set; }//---

    // Punho - Flexão
    [Required(ErrorMessage = "O campo Punho - Flexão VR é obrigatório")]
    [MaxLength(100)]
    public string PunhoFlexaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Punho - Flexão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string PunhoFlexaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Punho - Flexão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string PunhoFlexaoAdmEsquerdo { get; set; }//---

    // Punho - Extensão
    [Required(ErrorMessage = "O campo Punho - Extensão VR é obrigatório")]
    [MaxLength(100)]
    public string PunhoExtensaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Punho - Extensão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string PunhoExtensaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Punho - Extensão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string PunhoExtensaoAdmEsquerdo { get; set; }//---

    // Punho - Desvio Ulnar
    [Required(ErrorMessage = "O campo Punho - Desvio Ulnar VR é obrigatório")]
    [MaxLength(100)]
    public string PunhoDesvioUlnarVR { get; set; }//---

    [Required(ErrorMessage = "O campo Punho - Desvio Ulnar Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string PunhoDesvioUlnarAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Punho - Desvio Ulnar Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string PunhoDesvioUlnarAdmEsquerdo { get; set; }//---

    // Punho - Desvio Radial
    [Required(ErrorMessage = "O campo Punho - Desvio Radial VR é obrigatório")]
    [MaxLength(100)]
    public string PunhoDesvioRadialVR { get; set; }//--

    [Required(ErrorMessage = "O campo Punho - Desvio Radial Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string PunhoDesvioRadialAdmDireito { get; set; }//---
     
    [Required(ErrorMessage = "O campo Punho - Desvio Radial Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string PunhoDesvioRadialAdmEsquerdo { get; set; }//---

    // Quadril - Extensão
    [Required(ErrorMessage = "O campo Quadril - Flexão VR é obrigatório")]
    [MaxLength(100)]
    public string QuadrilFlexaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Flexão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string QuadrilFlexaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Flexão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string QuadrilFlexaoAdmEsquerdo { get; set; }//---

    // Quadril - Extensão
    [Required(ErrorMessage = "O campo Quadril - Extensão VR é obrigatório")]
    [MaxLength(100)]
    public string QuadrilExtensaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Extensão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string QuadrilExtensaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Extensão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string QuadrilExtensaoAdmEsquerdo { get; set; }//---

    // Quadril - Adução
    [Required(ErrorMessage = "O campo Quadril - Adução VR é obrigatório")]
    [MaxLength(100)]
    public string QuadrilAducaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Adução Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string QuadrilAducaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Adução Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string QuadrilAducaoAdmEsquerdo { get; set; }//---

    // Quadril - Abdução
    [Required(ErrorMessage = "O campo Quadril - Abdução VR é obrigatório")]
    [MaxLength(100)]
    public string QuadrilAbducaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Abdução Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string QuadrilAbducaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Abdução Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string QuadrilAbducaoAdmEsquerdo { get; set; }//---


    // Quadril - Rotação Interna
    [Required(ErrorMessage = "O campo Quadril - Rotação Interna VR é obrigatório")]
    [MaxLength(100)]
    public string QuadrilRotInternaVR { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Rotação Interna Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string QuadrilRotInternaAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Rotação Interna Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string QuadrilRotInternaAdmEsquerdo { get; set; }//---

    // Quadril - Rotação Extensão
    [Required(ErrorMessage = "O campo Quadril - Rotação Extensão VR é obrigatório")]
    [MaxLength(100)]
    public string QuadrilRotExternaVR { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Rotação Extensão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string QuadrilRotExternaAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Quadril - Rotação Extensão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string QuadrilRotExternaAdmEsquerdo { get; set; }//---

    // Joelho - Flexão
    [Required(ErrorMessage = "O campo Joelho - Flexão VR é obrigatório")]
    [MaxLength(100)]
    public string JoelhoFlexaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Joelho - Flexão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string JoelhoFlexaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Joelho - Flexão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string JoelhoFlexaoAdmEsquerdo { get; set; }//---

    // Joelho - Extensão
    [Required(ErrorMessage = "O campo Joelho - Extensão VR é obrigatório")]
    [MaxLength(100)]
    public string JoelhoExtensaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Joelho - Extensão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string JoelhoExtensaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Joelho - Extensão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string JoelhoExtensaoAdmEsquerdo { get; set; }//---

    // Tornozelo - Eversão
    [Required(ErrorMessage = "O campo Tornozelo - Eversão VR é obrigatório")]
    [MaxLength(100)]
    public string TornozeloEversaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Eversão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string TornozeloEversaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Eversão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string TornozeloEversaoAdmEsquerdo { get; set; }//---

    // Tornozelo - Dorsiflexão
    [Required(ErrorMessage = "O campo Tornozelo - Dorsiflexão VR é obrigatório")]
    [MaxLength(100)]
    public string TornozeloDorsiflexaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Dorsiflexão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string TornozeloDorsiflexaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Dorsiflexão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string TornozeloDorsiflexaoAdmEsquerdo { get; set; }//---

    // Tornozelo - Flexão Plantar
    [Required(ErrorMessage = "O campo Tornozelo - Flexão Plantar VR é obrigatório")]
    [MaxLength(100)]
    public string TornozeloFlexaoPlantarVR { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Flexão Plantar Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string TornozeloFlexaoPlantarAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Flexão Plantar Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string TornozeloFlexaoPlantarAdmEsquerdo { get; set; }//---

    // Tornozelo - Inversão
    [Required(ErrorMessage = "O campo Tornozelo - Inversão VR é obrigatório")]
    [MaxLength(100)]
    public string TornozeloInversaoVR { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Inversão Adm Direito é obrigatório")]
    [MaxLength(100)]
    public string TornozeloInversaoAdmDireito { get; set; }//---

    [Required(ErrorMessage = "O campo Tornozelo - Inversão Adm Esquerdo é obrigatório")]
    [MaxLength(100)]
    public string TornozeloInversaoAdmEsquerdo { get; set; }//---

    // Quedas - Tempo
    [Required(ErrorMessage = "O campo Quedas - Tempo é obrigatório")]
    [MaxLength(100)]
    public string TempoQuedas { get; set; }//---

    // Quedas - Frequência
    [Required(ErrorMessage = "O campo Quedas - Frequência é obrigatório")]
    [MaxLength(100)]
    public string FrequenciaQuedas { get; set; }//---

    // Quedas - Local
    [Required(ErrorMessage = "O campo Quedas - Local é obrigatório")]
    [MaxLength(100)]
    public string LocalQuedas { get; set; }//---

    // Reflexo 
    [Required(ErrorMessage = "O campo Reflexo é obrigatório")]
    [MaxLength(100)]
    public string Reflexo { get; set; }//---

    // Equílibrio Corporal - Sentado 
    [Required(ErrorMessage = "O campo Equílibrio Corporal - Sentado é obrigatório")]
    [MaxLength(100)]
    public string EquilibrioSentado { get; set; }//---

    // Equílibrio Corporal - Em pé 
    [Required(ErrorMessage = "O campo Equílibrio Corporal - Em pé é obrigatório")]
    [MaxLength(100)]
    public string EquilibrioEmPe { get; set; }//---

    // Equílibrio Corporal - Sinal de Rosemberg 
    [Required(ErrorMessage = "O campo Equílibrio Corporal - Sinal de Rosemberg é obrigatório")]
    [MaxLength(100)]
    public string EquilibrioSinalRosemberg { get; set; }//---

    // Atividade de Vida Diária 
    [Required(ErrorMessage = "O campo Atividade de Vida Diária é obrigatório")]
    [MaxLength(100)]
    public string AtividadeVidaDiaria { get; set; }//---

    // Escala Visual de Dor
    [Required(ErrorMessage = "O campo Escala Visual de Dor é obrigatório")]
    public int EscalaDor { get; set; }//---
    /// </summary>

    // Região da Dor
    [Required(ErrorMessage = "O campo Região da Dor é obrigatório")]
    [MaxLength(100)]
    public string RegiaoDor { get; set; }//---

    // Pé - Sagital
    [Required(ErrorMessage = "O campo Pé - Sagital é obrigatório")]
    [MaxLength(100)]
    public string PeSagital { get; set; }//---

    // Pé - Frontal
    [Required(ErrorMessage = "O campo Pé - Frontal é obrigatório")]
    [MaxLength(100)]
    public string PeFrontal { get; set; }//---

    // Joelho - Sagital
    [Required(ErrorMessage = "O campo Joelho - Sagital é obrigatório")]
    [MaxLength(100)]
    public string JoelhoSagital { get; set; }//---

    // Joelho - Frontal
    [Required(ErrorMessage = "O campo Joelho - Frontal é obrigatório")]
    [MaxLength(100)]
    public string JoelhoFrontal { get; set; }//---

    // Cintura Pélvica - Sagital
    [Required(ErrorMessage = "O campo Cintura Pélvica - Sagital é obrigatório")]
    [MaxLength(100)]
    public string CinturaPelvicaSagital { get; set; }//---

    // Cintura Pélvica - Frontal
    [Required(ErrorMessage = "O campo Cintura Pélvica - Frontal é obrigatório")]
    [MaxLength(100)]
    public string CinturaPelvicaFrontal { get; set; }//---

    // Coluna - Sagital
    [Required(ErrorMessage = "O campo  Coluna  - Sagital é obrigatório")]
    [MaxLength(100)]
    public string ColunaSagital { get; set; }//---

    // Coluna - Frontal
    [Required(ErrorMessage = "O campo  Coluna  - Frontal é obrigatório")]
    [MaxLength(100)]
    public string ColunaFrontal { get; set; }//---

    // Cintura escapular - Sagital
    [Required(ErrorMessage = "O campo Cintura escapular - Sagital é obrigatório")]
    [MaxLength(100)]
    public string CinturaEscapularSagital { get; set; }//---

    // Cintura escapular - Frontal
    [Required(ErrorMessage = "O campo Cintura escapular - Frontal é obrigatório")]
    [MaxLength(100)]
    public string CinturaEscapularFrontal { get; set; }//---

    // Cabeça - Sagital
    [Required(ErrorMessage = "O campo Cabeça - Sagital é obrigatório")]
    [MaxLength(100)]
    public string CabecaSagital { get; set; }//---

    // Cabeça - Frontal
    [Required(ErrorMessage = "O campo Cabeça - Frontal é obrigatório")]
    [MaxLength(100)]
    public string CabecaFrontal { get; set; }//---

    // Avaliação da Marcha
    [Required(ErrorMessage = "O campo Avaliação da Marcha é obrigatório")]
    [MaxLength(100)]
    public string AvaliacaoMarcha { get; set; }//---

    // Observações
    [Required(ErrorMessage = "O campo Observações é obrigatório")]
    [MaxLength(100)]
    public string Observacoes { get; set; }//---

    // Diagnóstico Funcional
    [Required(ErrorMessage = "O campo Diagnóstico Funcional é obrigatório")]
    [MaxLength(100)]
    public string DiagnosticoFuncional { get; set; }//---

    // Objetivos Fisioterápicos
    [Required(ErrorMessage = "O campo Objetivos Fisioterápicos é obrigatório")]
    [MaxLength(100)]
    public string ObjetivosFisioterapicos { get; set; }
}
