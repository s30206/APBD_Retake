using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace APBD_Retake.API.Models;

[PrimaryKey(nameof(Visit_id))]
public class Visit
{
    public int Visit_id { get; set; }
    
    public int ClientId { get; set; }
    public Client Client { get; set; }
    
    public int MechanicId { get; set; }
    public Mechanic Mechanic { get; set; }
    
    public DateTime Date { get; set; }
}