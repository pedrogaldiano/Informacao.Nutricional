using Models;

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
}
