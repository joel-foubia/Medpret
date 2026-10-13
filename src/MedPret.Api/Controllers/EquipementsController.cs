using MedPret.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedPret.Api.Controllers;

[ApiController]
[Route("api/[controller]")]   // → /api/equipements
public class EquipementsController : ControllerBase
{
    // Inventaire temporaire en mémoire (remplacé par PostgreSQL à l'étape 3)
    private static readonly List<Equipement> _equipements =
    [
        new() { Id = 1, Nom = "Fauteuil roulant standard", Type = "Fauteuil roulant",
                Localisation = "CAB Longueuil", Statut = StatutEquipement.Disponible },
        new() { Id = 2, Nom = "Marchette à roulettes", Type = "Marchette",
                Localisation = "CAB Longueuil", Statut = StatutEquipement.Prete },
        new() { Id = 3, Nom = "Lit médicalisé électrique", Type = "Lit",
                Localisation = "CAB Brossard", Statut = StatutEquipement.EnMaintenance }
    ];

    // GET /api/equipements
    [HttpGet]
    public ActionResult<IEnumerable<Equipement>> GetTous()
    {
        return Ok(_equipements);
    }
}