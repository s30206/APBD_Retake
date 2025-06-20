using System.ComponentModel.DataAnnotations;

namespace APBD_Retake.API.Models;

public class Mechanic
{
    [Key]
    public int Mechanic_id { get; set; }
    [MaxLength(100)]
    public string First_name { get; set; }
    [MaxLength(100)]
    public string Last_name { get; set; }
    [MaxLength(14)]
    public string Licence_number { get; set; }
}