using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService  //ILoggerService alternatifisin sen.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
