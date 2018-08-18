namespace Interfases2
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "Error");


        }

        public void Loginfo(string message)
        {
            Log(message,"Info");
        }

        private void Log(string message,string messageType)
        {
            using (var streamWriter = new System.IO.StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType+ " " + message);
                streamWriter.Dispose();
            }
        }
    }
}
