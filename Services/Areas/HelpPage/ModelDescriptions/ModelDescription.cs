namespace Services.Areas.HelpPage.ModelDescriptions
{
    /// <summary>Describes a type model.</summary>
    public abstract class ModelDescription
    {
        public string Documentation { get; set; }
        public System.Type ModelType { get; set; }
        public string Name { get; set; }
    }
}