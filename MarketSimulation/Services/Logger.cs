namespace MarketSimulation.Services
{
    /// <summary>
    /// Simple file writer
    /// </summary>
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

        /// <summary>
        /// Method to save string based message to file
        /// <para>
        /// If file exists: 
        /// Each message appends to current file
        /// </para>
        /// <para>
        /// If file does not exists: 
        /// New file will be created
        /// </para>
        /// 
        /// </summary>
        /// <param name="message">string based message to be saved to file</param>
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
