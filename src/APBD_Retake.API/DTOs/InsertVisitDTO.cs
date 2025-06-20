using System.ComponentModel.DataAnnotations;

namespace APBD_Retake.API.DTOs;

public class InsertVisitDTO
{
    [Required]
    [Range(1, int.MaxValue)]
    public int ClientId { get; set; }
    [Required]
    [MaxLength(14)]
    [RegularExpression("^MECH-\\d+$")]
    public string MechanicLicenceNumber { get; set; }
    [Required]
    public List<ServiceDTO> Services { get; set; }
}