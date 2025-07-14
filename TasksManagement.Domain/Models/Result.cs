namespace TasksManagement.Domain.Models;
public class Result<TData> : Result
{
    public TData? Data { get; init; }
}

public class Result
{
    public ErrorCode ErrorCode { get; init; } = ErrorCode.Success;

    public string ErrorDescription { get; set; } = "";
}