/// <summary>
/// A class that provides methods for saving and loading JSON objects to/from files.
/// </summary>
public class PersistSystem
{
    /// <summary>
    /// Save a JSON object to a file.
    /// </summary>
    /// <param name="filePath">The path to the file where the JSON object will be saved.</param>
    /// <param name="json">The JSON object to be saved.</param>
    public static void SaveJSON(string filePath, string json) // string <- void
    {
        ValidateFilePath(filePath);

        using (StreamWriter streamWriter = new StreamWriter(filePath))
        {
            streamWriter.Write(json);
        }
    }

    /// <summary>
    /// Load a JSON object from a file.
    /// </summary>
    /// <param name="filePath">The path to the file from which the JSON object will be loaded.</param>
    /// <returns>The JSON object read from the file.</returns>
    public static string LoadJSON(string filePath)
    {
        ValidateFilePath(filePath);
        return File.ReadAllText(filePath);
    }

    /// <summary>
    /// Determines if a file exists at the given file path.
    /// </summary>
    /// <param name="filePath">The path to the file to check for existence.</param>
    /// <returns>True if the file exists, false otherwise.</returns>
    public static bool FileExist(string filePath)
    {
        return File.Exists(filePath);
    }

    /// <summary>
    /// Determines if a directory exists at the given directory path.
    /// </summary>
    /// <param name="directoryPath">The path to the directory to check for existence.</param>
    /// <returns>True if directory exists, otherwise false.</returns>
    public static bool DirectoryExists(string directoryPath)
    {
        return Directory.Exists(directoryPath);
    }

    /// <summary>
    /// Validates given file path. Throws FileNotFoundException if file does not exist.
    /// </summary>
    /// <param name="filePath">The path to the file to validate.</param>
    public static void ValidateFilePath(string filePath)
    {
        if (!FileExist(filePath))
        {
            throw new FileNotFoundException("File not found: " + filePath);
        }
    }

    /// <summary>
    /// Validates given directory path. Throws DirectoryNotFoundException if file does not exist.
    /// </summary>
    /// <param name="directoryPath">The path to the directory to validate.</param>
    public static void ValidateDirectoryPath(string directoryPath)
    {
        if (!DirectoryExists(directoryPath))
        {
            throw new DirectoryNotFoundException("Directory not found: " + directoryPath);
        }
    }
}
