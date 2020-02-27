using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Logger
{
    public interface ILog
    {
        Task WriteToLog(string message);

    }
}
