namespace MedPret.Api.Models;

public class Equipement
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;          // ex. « Fauteuil roulant »
    public string Localisation { get; set; } = string.Empty;  // ex. « CAB Longueuil »
    public StatutEquipement Statut { get; set; } = StatutEquipement.Disponible;
}