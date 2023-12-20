﻿using Domain.DTOs.Events;

namespace Domain.Entities;

public class Event
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Address { get; set; }
    
    public string ShortDescription { get; set; }
    
    public string Description { get; set; }
    
    public DateTime Date { get; set; }
    
    public Guid CreatorId { get; set; }
    
    public User Creator { get; set; }
    
    public List<User> Users { get; set; }

    public Event()
    {
        
    }

    public Event(EventDto eventDto)
    {
        Id = Guid.NewGuid();
        Name = eventDto.Name;
        Description = eventDto.Description;
        ShortDescription = eventDto.ShortDescription;
        Date = eventDto.Date ?? DateTime.UtcNow;
        Address = eventDto.Address;
        Users = new List<User>();
        CreatorId = eventDto.CreatorId;
    }
}