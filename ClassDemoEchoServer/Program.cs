using System;

namespace ClassDemoEchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Start();
        }
    }
}
