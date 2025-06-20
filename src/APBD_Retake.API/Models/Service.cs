using System.ComponentModel.DataAnnotations;

namespace APBD_Retake.API.Models;

public class Service
{
    [Key]
    public int Service_id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public Decimal Base_fee { get; set; }
}