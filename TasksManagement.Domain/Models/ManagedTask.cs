﻿namespace TasksManagement.Domain.Models;

public class ManagedTask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public ManagedTaskStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
}
