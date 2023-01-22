using Informacao.Nutricional.Models;

namespace Informacao.Nutricional.DTOs;

public class NutrientesResponse
{

    // string s = $"{ $"{value.ToString("0.000000")} --- VD% { percent.ToString("00.00")}";

    public NutrientesResponse(NutrientesModel ingredientes)
    {
        var percent = 30.00;
        // umidade_percentual = $"{ $"{  ingredientes.umidade_percentual.ToString("0.000000")} --- VD% { percent.ToString("00.00")}";
        sodio_mg = $"{ ingredientes.sodio_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        cinzas_g = $"{ ingredientes.cinzas_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        energia_kj = $"{ ingredientes.energia_kj.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        energia_kcal = $"{ ingredientes.energia_kcal.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        carboidrato_g = $"{ ingredientes.carboidrato_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        acucar_total_g = $"{ ingredientes.acucar_total_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        acucar_adicionado_g = $"{ ingredientes.acucar_adicionado_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        proteina_g = $"{ ingredientes.proteina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        gordura_total_g = $"{ ingredientes.gordura_total_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        gordura_saturada_g = $"{ ingredientes.gordura_saturada_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        gordura_trans_g = $"{ ingredientes.gordura_trans_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        gordura_monostaturada_g = $"{ ingredientes.gordura_monostaturada_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        gordura_polisaturada_g = $"{ ingredientes.gordura_polisaturada_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        omega_6_mg = $"{ ingredientes.omega_6_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        omega_3_mg = $"{ ingredientes.omega_3_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        colesterol_mg = $"{ ingredientes.colesterol_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        fibra_g = $"{ ingredientes.fibra_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_a_mg = $"{ ingredientes.vitamina_a_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_d_mg = $"{ ingredientes.vitamina_d_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_e_mg = $"{ ingredientes.vitamina_e_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_k_mg = $"{ ingredientes.vitamina_k_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_c_mg = $"{ ingredientes.vitamina_c_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b1_mg = $"{ ingredientes.vitamina_b1_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b2_mg = $"{ ingredientes.vitamina_b2_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b3_mg = $"{ ingredientes.vitamina_b3_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b5_mg = $"{ ingredientes.vitamina_b5_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b6_mg = $"{ ingredientes.vitamina_b6_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b7_mg = $"{ ingredientes.vitamina_b7_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b9_mg = $"{ ingredientes.vitamina_b9_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        vitamina_b12_mg = $"{ ingredientes.vitamina_b12_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        calcio_mg = $"{ ingredientes.calcio_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        cloreto_mg = $"{ ingredientes.cloreto_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        cobre_mg = $"{ ingredientes.cobre_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        cromo_mg = $"{ ingredientes.cromo_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        ferro_mg = $"{ ingredientes.ferro_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        fluor_mg = $"{ ingredientes.fluor_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        fosforo_mg = $"{ ingredientes.fosforo_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        iodo_mg = $"{ ingredientes.iodo_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        magnesio_mg = $"{ ingredientes.magnesio_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        manganes_mg = $"{ ingredientes.manganes_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        molibdenio_mg = $"{ ingredientes.molibdenio_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        postassio_mg = $"{ ingredientes.postassio_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        selenio_mg = $"{ ingredientes.selenio_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        zinco_mg = $"{ ingredientes.zinco_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        colina_mg = $"{ ingredientes.colina_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        triptofano_mg = $"{ ingredientes.triptofano_mg.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        treonina_g = $"{ ingredientes.treonina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        isoleucina_g = $"{ ingredientes.isoleucina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        leucina_g = $"{ ingredientes.leucina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        lisina_g = $"{ ingredientes.lisina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        metionina_g = $"{ ingredientes.metionina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        cistina_g = $"{ ingredientes.cistina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        fenilalanina_g = $"{ ingredientes.fenilalanina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        tirosina_g = $"{ ingredientes.tirosina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        valina_g = $"{ ingredientes.valina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        arginina_g = $"{ ingredientes.arginina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        histidina_g = $"{ ingredientes.histidina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        alanina_g = $"{ ingredientes.alanina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        acido_aspartico_g = $"{ ingredientes.acido_aspartico_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        acido_glutaminco_g = $"{ ingredientes.acido_glutaminco_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        glicina_g = $"{ ingredientes.glicina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        prolina_g = $"{ ingredientes.prolina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
        serina_g = $"{ ingredientes.serina_g.ToString("0.000000")} --- VD% { percent.ToString("00.00") }";
    }

    // public string umidade_percentual { get; private set; }
    public string sodio_mg { get; private set; }
    public string cinzas_g { get; private set; }
    public string energia_kj { get; private set; }
    public string energia_kcal { get; private set; }
    public string carboidrato_g { get; private set; }
    public string acucar_total_g { get; private set; }
    public string acucar_adicionado_g { get; private set; }
    public string proteina_g { get; private set; }
    public string gordura_total_g { get; private set; }
    public string gordura_saturada_g { get; private set; }
    public string gordura_trans_g { get; private set; }
    public string gordura_monostaturada_g { get; private set; }
    public string gordura_polisaturada_g { get; private set; }
    public string omega_6_mg { get; private set; }
    public string omega_3_mg { get; private set; }
    public string colesterol_mg { get; private set; }
    public string fibra_g { get; private set; }
    public string vitamina_a_mg { get; private set; }
    public string vitamina_d_mg { get; private set; }
    public string vitamina_e_mg { get; private set; }
    public string vitamina_k_mg { get; private set; }
    public string vitamina_c_mg { get; private set; }
    public string vitamina_b1_mg { get; private set; }
    public string vitamina_b2_mg { get; private set; }
    public string vitamina_b3_mg { get; private set; }
    public string vitamina_b5_mg { get; private set; }
    public string vitamina_b6_mg { get; private set; }
    public string vitamina_b7_mg { get; private set; }
    public string vitamina_b9_mg { get; private set; }
    public string vitamina_b12_mg { get; private set; }
    public string calcio_mg { get; private set; }
    public string cloreto_mg { get; private set; }
    public string cobre_mg { get; private set; }
    public string cromo_mg { get; private set; }
    public string ferro_mg { get; private set; }
    public string fluor_mg { get; private set; }
    public string fosforo_mg { get; private set; }
    public string iodo_mg { get; private set; }
    public string magnesio_mg { get; private set; }
    public string manganes_mg { get; private set; }
    public string molibdenio_mg { get; private set; }
    public string postassio_mg { get; private set; }
    public string selenio_mg { get; private set; }
    public string zinco_mg { get; private set; }
    public string colina_mg { get; private set; }
    public string triptofano_mg { get; private set; }
    public string treonina_g { get; private set; }
    public string isoleucina_g { get; private set; }
    public string leucina_g { get; private set; }
    public string lisina_g { get; private set; }
    public string metionina_g { get; private set; }
    public string cistina_g { get; private set; }
    public string fenilalanina_g { get; private set; }
    public string tirosina_g { get; private set; }
    public string valina_g { get; private set; }
    public string arginina_g { get; private set; }
    public string histidina_g { get; private set; }
    public string alanina_g { get; private set; }
    public string acido_aspartico_g { get; private set; }
    public string acido_glutaminco_g { get; private set; }
    public string glicina_g { get; private set; }
    public string prolina_g { get; private set; }
    public string serina_g { get; private set; }
}
