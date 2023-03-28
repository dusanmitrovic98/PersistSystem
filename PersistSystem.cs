using System.IO;

/// <summary>
/// Persist system class used to save and load JSON objects to files. 
/// </summary>
public class PersistSystem
{
    private string directoryPath;

    public string DirectoryPath
    {
        get { return directoryPath; }
        set { directoryPath = value; }
    }

    public PersistSystem(string directoryPath)
    {
        this.directoryPath = directoryPath;

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
    }

    /// <summary>
    /// Save a JSON object to a file.
    /// </summary>
    /// <param name="fileName">File name.</param>
    /// <param name="json">JSON object that will be saved.</param>
    public void SaveJSON(string fileName, string json)
    {
        string filePath = Path.Combine(directoryPath, fileName);

        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// Load a JSON object from a file.
    /// </summary>
    /// <param name="fileName">File name.</param>
    /// <returns>JSON object.</returns>
    public string LoadJSON(string fileName)
    {
        string filePath = Path.Combine(directoryPath, fileName);

        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath);
        }

        throw new Exception("File not found: " + filePath);
    }
}
