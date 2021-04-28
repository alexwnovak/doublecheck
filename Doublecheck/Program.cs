namespace Doublecheck
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var appController = new AppController(new FileSystem());
            return appController.Run(args);
        }
    }
}
