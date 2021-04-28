namespace Doublecheck
{
    public interface IFileSystem
    {
        string[] GetFiles(string path, string searchPattern);
        void WriteAllLines(string path, string[] contents);
    }
}
