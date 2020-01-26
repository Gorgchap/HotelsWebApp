namespace Services.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(System.Reflection.MemberInfo member);

        string GetDocumentation(System.Type type);
    }
}