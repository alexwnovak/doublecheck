namespace Doublecheck
{
    public interface IFileSystem
    {
        string[] GetFiles(string path, string searchPattern);
    }
}
