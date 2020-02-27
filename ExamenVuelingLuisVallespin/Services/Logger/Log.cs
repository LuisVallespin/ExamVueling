using System;
using System.IO;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Logger
{
    public class Log : ILog
    {
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + DateTime.Today +".txt";
        public async Task WriteToLog(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    await writer.WriteLineAsync(message);
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
            
        }
    }
}