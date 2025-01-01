using Emmetienne.Engines.Logging;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Components
{
    public interface ILoggingComponent
    {
        void WriteLog(LogModel log);
        void ClearLogs();
    }
}
