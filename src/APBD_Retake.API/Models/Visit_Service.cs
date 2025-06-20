using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace APBD_Retake.API.Models;

[PrimaryKey(nameof(VisitId), nameof(ServiceId))]
public class Visit_Service
{
    
    public int VisitId { get; set; }
    public Visit Visit { get; set; }
    
    public int ServiceId { get; set; }
    public Service Service { get; set; }
    
    public Decimal Service_fee { get; set; }
}