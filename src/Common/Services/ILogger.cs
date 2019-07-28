namespace Common.Services
{
    public interface ILogger
    {
        void LogInformation(string message, params object[] args);
        void LogError(string message, params object[] args);
    }
}
