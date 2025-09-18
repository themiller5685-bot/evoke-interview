namespace TasksManagement.Domain.Models;

//TODO: Implement enums

public enum ManagedTaskStatus
{
    Pending,
    InProgress,
    Completed,
    Cancelled
}

public enum ErrorCode
{
    Success,
    NotFound = 1
}