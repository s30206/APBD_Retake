using System.ComponentModel.DataAnnotations;

namespace APBD_Retake.API.Models;

public class Client
{
    [Key]
    public int Client_id { get; set; }
    [MaxLength(100)]
    public string First_name { get; set; }
    [MaxLength(100)]
    public string Last_name { get; set; }
    public DateTime Date_of_birth { get; set; }
}