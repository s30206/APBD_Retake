using APBD_Retake.API.DTOs;
using APBD_Retake.API.Models;

namespace APBD_Retake.API.Interfaces;

public interface IVisitService
{
    public Task<GetVisitDTO?> GetVisitAsync(int id);
    public Task<Visit> AddVisitAsync(InsertVisitDTO request);
}