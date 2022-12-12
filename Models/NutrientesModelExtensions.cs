namespace Informacao.Nutricional.Models;

public static class NutrientesModelExtensions
{
    public static NutrientesModel MultiplyBy(this NutrientesModel nutriente, double value)
    {
        double percentage = value / 100;
        nutriente.umidade_percentual *= percentage;
        nutriente.sodio_mg *= percentage;
        nutriente.cinzas_g *= percentage;
        nutriente.energia_kj *= percentage;
        nutriente.energia_kcal *= percentage;
        nutriente.carboidrato_g *= percentage;
        nutriente.acucar_total_g *= percentage;
        nutriente.acucar_adicionado_g *= percentage;
        nutriente.proteina_g *= percentage;
        nutriente.gordura_total_g *= percentage;
        nutriente.gordura_saturada_g *= percentage;
        nutriente.gordura_trans_g *= percentage;
        nutriente.gordura_monostaturada_g *= percentage;
        nutriente.gordura_polisaturada_g *= percentage;
        nutriente.omega_6_mg *= percentage;
        nutriente.omega_3_mg *= percentage;
        nutriente.colesterol_mg *= percentage;
        nutriente.fibra_g *= percentage;
        nutriente.vitamina_a_mg *= percentage;
        nutriente.vitamina_d_mg *= percentage;
        nutriente.vitamina_e_mg *= percentage;
        nutriente.vitamina_k_mg *= percentage;
        nutriente.vitamina_c_mg *= percentage;
        nutriente.vitamina_b1_mg *= percentage;
        nutriente.vitamina_b2_mg *= percentage;
        nutriente.vitamina_b3_mg *= percentage;
        nutriente.vitamina_b5_mg *= percentage;
        nutriente.vitamina_b6_mg *= percentage;
        nutriente.vitamina_b7_mg *= percentage;
        nutriente.vitamina_b9_mg *= percentage;
        nutriente.vitamina_b12_mg *= percentage;
        nutriente.calcio_mg *= percentage;
        nutriente.cloreto_mg *= percentage;
        nutriente.cobre_mg *= percentage;
        nutriente.cromo_mg *= percentage;
        nutriente.ferro_mg *= percentage;
        nutriente.fluor_mg *= percentage;
        nutriente.fosforo_mg *= percentage;
        nutriente.iodo_mg *= percentage;
        nutriente.magnesio_mg *= percentage;
        nutriente.manganes_mg *= percentage;
        nutriente.molibdenio_mg *= percentage;
        nutriente.postassio_mg *= percentage;
        nutriente.selenio_mg *= percentage;
        nutriente.zinco_mg *= percentage;
        nutriente.colina_mg *= percentage;
        nutriente.triptofano_mg *= percentage;
        nutriente.treonina_g *= percentage;
        nutriente.isoleucina_g *= percentage;
        nutriente.leucina_g *= percentage;
        nutriente.lisina_g *= percentage;
        nutriente.metionina_g *= percentage;
        nutriente.cistina_g *= percentage;
        nutriente.fenilalanina_g *= percentage;
        nutriente.tirosina_g *= percentage;
        nutriente.valina_g *= percentage;
        nutriente.arginina_g *= percentage;
        nutriente.histidina_g *= percentage;
        nutriente.alanina_g *= percentage;
        nutriente.acido_aspartico_g *= percentage;
        nutriente.acido_glutaminco_g *= percentage;
        nutriente.glicina_g *= percentage;
        nutriente.prolina_g *= percentage;
        nutriente.serina_g *= percentage;

        return nutriente;
    }

    public static NutrientesModel SumAndUnify(this NutrientesModel nutriente, List<NutrientesModel> ingredientes)
    {
        for (int i = 0; i < ingredientes.Count(); i++)
        {
            nutriente.umidade_percentual  += ingredientes[i].umidade_percentual;
            nutriente.sodio_mg  += ingredientes[i].sodio_mg;
            nutriente.cinzas_g  += ingredientes[i].cinzas_g;
            nutriente.energia_kj  += ingredientes[i].energia_kj;
            nutriente.energia_kcal  += ingredientes[i].energia_kcal;
            nutriente.carboidrato_g  += ingredientes[i].carboidrato_g;
            nutriente.acucar_total_g  += ingredientes[i].acucar_total_g;
            nutriente.acucar_adicionado_g  += ingredientes[i].acucar_adicionado_g;
            nutriente.proteina_g  += ingredientes[i].proteina_g;
            nutriente.gordura_total_g  += ingredientes[i].gordura_total_g;
            nutriente.gordura_saturada_g  += ingredientes[i].gordura_saturada_g;
            nutriente.gordura_trans_g  += ingredientes[i].gordura_trans_g;
            nutriente.gordura_monostaturada_g  += ingredientes[i].gordura_monostaturada_g;
            nutriente.gordura_polisaturada_g  += ingredientes[i].gordura_polisaturada_g;
            nutriente.omega_6_mg  += ingredientes[i].omega_6_mg;
            nutriente.omega_3_mg  += ingredientes[i].omega_3_mg;
            nutriente.colesterol_mg  += ingredientes[i].colesterol_mg;
            nutriente.fibra_g  += ingredientes[i].fibra_g;
            nutriente.vitamina_a_mg  += ingredientes[i].vitamina_a_mg;
            nutriente.vitamina_d_mg  += ingredientes[i].vitamina_d_mg;
            nutriente.vitamina_e_mg  += ingredientes[i].vitamina_e_mg;
            nutriente.vitamina_k_mg  += ingredientes[i].vitamina_k_mg;
            nutriente.vitamina_c_mg  += ingredientes[i].vitamina_c_mg;
            nutriente.vitamina_b1_mg  += ingredientes[i].vitamina_b1_mg;
            nutriente.vitamina_b2_mg  += ingredientes[i].vitamina_b2_mg;
            nutriente.vitamina_b3_mg  += ingredientes[i].vitamina_b3_mg;
            nutriente.vitamina_b5_mg  += ingredientes[i].vitamina_b5_mg;
            nutriente.vitamina_b6_mg  += ingredientes[i].vitamina_b6_mg;
            nutriente.vitamina_b7_mg  += ingredientes[i].vitamina_b7_mg;
            nutriente.vitamina_b9_mg  += ingredientes[i].vitamina_b9_mg;
            nutriente.vitamina_b12_mg  += ingredientes[i].vitamina_b12_mg;
            nutriente.calcio_mg  += ingredientes[i].calcio_mg;
            nutriente.cloreto_mg  += ingredientes[i].cloreto_mg;
            nutriente.cobre_mg  += ingredientes[i].cobre_mg;
            nutriente.cromo_mg  += ingredientes[i].cromo_mg;
            nutriente.ferro_mg  += ingredientes[i].ferro_mg;
            nutriente.fluor_mg  += ingredientes[i].fluor_mg;
            nutriente.fosforo_mg  += ingredientes[i].fosforo_mg;
            nutriente.iodo_mg  += ingredientes[i].iodo_mg;
            nutriente.magnesio_mg  += ingredientes[i].magnesio_mg;
            nutriente.manganes_mg  += ingredientes[i].manganes_mg;
            nutriente.molibdenio_mg  += ingredientes[i].molibdenio_mg;
            nutriente.postassio_mg  += ingredientes[i].postassio_mg;
            nutriente.selenio_mg  += ingredientes[i].selenio_mg;
            nutriente.zinco_mg  += ingredientes[i].zinco_mg;
            nutriente.colina_mg  += ingredientes[i].colina_mg;
            nutriente.triptofano_mg  += ingredientes[i].triptofano_mg;
            nutriente.treonina_g  += ingredientes[i].treonina_g;
            nutriente.isoleucina_g  += ingredientes[i].isoleucina_g;
            nutriente.leucina_g  += ingredientes[i].leucina_g;
            nutriente.lisina_g  += ingredientes[i].lisina_g;
            nutriente.metionina_g  += ingredientes[i].metionina_g;
            nutriente.cistina_g  += ingredientes[i].cistina_g;
            nutriente.fenilalanina_g  += ingredientes[i].fenilalanina_g;
            nutriente.tirosina_g  += ingredientes[i].tirosina_g;
            nutriente.valina_g  += ingredientes[i].valina_g;
            nutriente.arginina_g  += ingredientes[i].arginina_g;
            nutriente.histidina_g  += ingredientes[i].histidina_g;
            nutriente.alanina_g  += ingredientes[i].alanina_g;
            nutriente.acido_aspartico_g  += ingredientes[i].acido_aspartico_g;
            nutriente.acido_glutaminco_g  += ingredientes[i].acido_glutaminco_g;
            nutriente.glicina_g  += ingredientes[i].glicina_g;
            nutriente.prolina_g  += ingredientes[i].prolina_g;
            nutriente.serina_g  += ingredientes[i].serina_g;
        }
        return nutriente;
    }
}
