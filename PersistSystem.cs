namespace PersistSystemCore;

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
    public static void SaveJSON(string filePath, string json)
    {
        ValidateFilePath(filePath);

        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// Load a JSON object from a file.
    /// </summary>
    /// <param name="filePath">File path.</param>
    /// <returns>JSON object.</returns>
    public string LoadJSON(string filePath)
    {
        ValidateFilePath(filePath);

        return File.ReadAllText(filePath);
    }

    /// <summary>
    /// Determines if file exists or not.
    /// </summary>
    /// <param name="filePath">Given file path.</param>
    /// <returns>True if file exists, otherwise false.</returns>
    public static bool FileExist(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Determines if directory exists or not.
    /// </summary>
    /// <param name="directoryPath">Given directory path.</param>
    /// <returns>True if directory exists, otherwise false.</returns>
    public static bool DirectoryExists(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Validates given file path. Throws FileNotFoundException if file does not exist.
    /// </summary>
    /// <param name="filePath">Given file path.</param>
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
    /// <param name="directoryPath">Given directory path.</param>
    public static void ValidateDirectoryPath(string directoryPath)
    {
        if (!DirectoryExists(directoryPath))
        {
            throw new DirectoryNotFoundException("Directory not found: " + directoryPath);
        }
    }
}
