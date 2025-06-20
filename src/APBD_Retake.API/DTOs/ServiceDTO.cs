using System.ComponentModel.DataAnnotations;

namespace APBD_Retake.API.DTOs;

public class ServiceDTO
{
    [Required]
    public string ServiceName { get; set; }
    [Required]
    [Range(1, int.MaxValue)]
    public Decimal ServiceFee { get; set; }
}