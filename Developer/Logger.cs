using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer {
    public static class Logger {
        public class LogEventArgs : EventArgs {
            public string File;
            public string Message;
            public string Extension;
            public LogStatus Status;
        }

        public enum LogStatus {
            OK,
            Message,
            Warning,
            Error,
            Silent
        }

        public static event EventHandler<LogEventArgs> OnLog;

        public static void Log (string file, string msg, string ext, LogStatus status) {
            OnLog?.Invoke (null, new LogEventArgs () {
                Extension = ext,
                    File = file,
                    Message = msg,
                    Status = status
            });
        }
    }
}