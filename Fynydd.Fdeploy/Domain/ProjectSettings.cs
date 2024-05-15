namespace Fynydd.Fdeploy.Domain;

public sealed class ProjectSettings
{
    public string ProjectFilePath { get; set; } = string.Empty;
    public string EnvironmentName { get; set; } = "Production";
    public string BuildConfiguration { get; set; } = "Release";

    public decimal TargetFramework { get; set; } = 8.0M;
    public List<string> CopyFilesToPublishFolder { get; set; } = [];
    public List<string> CopyFoldersToPublishFolder { get; set; } = [];

    public string ProjectFileName => ProjectFilePath.IndexOf(Path.DirectorySeparatorChar) > -1 ? ProjectFilePath[ProjectFilePath.LastIndexOf(Path.DirectorySeparatorChar)..].Trim(Path.DirectorySeparatorChar) : ProjectFilePath;
}