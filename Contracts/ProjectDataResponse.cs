namespace AVG.Contracts
{
    public record ProjectDataResponse
    (
        int Id,
        string Title,
        string Description,
        string ImagePath,
        string ExampleScript
    );
}

