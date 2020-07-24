using System;

namespace EtwForceGC
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    Console.Error.WriteLine("Usage: {0} PID [TIMEOUT]",
                        typeof(Program).Assembly.GetName().Name);
                    return 1;
                }

                int processId = int.Parse(args[0]);
                int timeout = -1;
                if (args.Length > 1)
                {
                    timeout = int.Parse(args[1]) * 1000;
                }

                GCHelper.ForceGC("forcegc", processId, Console.Out);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return ex.HResult;
            }

            return 0;
        }
    }
}
