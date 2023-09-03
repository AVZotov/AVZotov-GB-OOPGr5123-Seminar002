namespace MarketSimulation.Services
{
    public class Logger
    {
        private readonly string _filePath;
        private readonly string _fileName;
        private readonly string _currentDirectory;

        public Logger()
        {
            this._currentDirectory = Directory.GetCurrentDirectory();
            this._fileName = "log.txt";
            this._filePath = this._currentDirectory + "/" + this._fileName;
        }

        public void Log(string message)
        {
            using (StreamWriter streamWriter = File.AppendText(this._filePath))
            {
                streamWriter.Write("\r\nLog Entry : ");
                streamWriter.WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
                streamWriter.WriteLine(message);
            }
        }
    }
}
