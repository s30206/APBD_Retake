﻿using APBD_Retake.API.DAL.Context;
using APBD_Retake.API.DTOs;
using APBD_Retake.API.Interfaces;
using APBD_Retake.API.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Retake.API.Services;

public class VisitService : IVisitService
{
    private readonly WorkshopContext _context;

    public VisitService(WorkshopContext context)
    {
        _context = context;
    }
    
    public async Task<Visit> AddVisitAsync(InsertVisitDTO request)
    {
        var client = await _context.Clients.FindAsync(request.ClientId);
        if (client == null)
            throw new KeyNotFoundException($"Client with id {request.ClientId} not found.");

        var mechanic =
            await _context.Mechanics.FirstOrDefaultAsync(m => m.Licence_number == request.MechanicLicenceNumber);
        
        if (mechanic == null)
            throw new KeyNotFoundException($"Mechanic with id {request.MechanicLicenceNumber} not found.");

        var visit = new Visit()
        {
            ClientId = client.Client_id,
            MechanicId = mechanic.Mechanic_id,
            Date = DateTime.Now
        };
        _context.Visits.Add(visit);
        await _context.SaveChangesAsync();

        foreach (var service in request.Services)
        {
            var foundService = await _context.Services.FirstOrDefaultAsync(s => s.Name == service.ServiceName);
            if (foundService == null)
                throw new KeyNotFoundException($"Service with name {service.ServiceName} not found.");
            var visitService = new Visit_Service()
            {
                VisitId = visit.Visit_id,
                ServiceId = foundService.Service_id,
                Service_fee = service.ServiceFee
            };
            _context.Visit_Services.Add(visitService);
            await _context.SaveChangesAsync();
        }

        return visit;
    }
}