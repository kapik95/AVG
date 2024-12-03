namespace AVG.Contracts
{
    public record ProjectsResponse
    (
        int Id,
        string Title,
        string BriefDescription,
        string ImagePath,
        string Slug
    ); 
}
