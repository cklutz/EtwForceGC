# ETW Force GC

A simple command line tool that shows how to call the .NET garbage collector for an external process. All relevant code is in [GCHelper.cs](EtwForceGC\GCHelper.cs) and could be trivially moved to other libraries or tools (it depends on the [Microsoft.Diagnostics.Tracing.TraceEvent](https://www.nuget.org/packages/Microsoft.Diagnostics.Tracing.TraceEvent/) package only).

Usage:

    EtwForceGC.exe <PID>

This tool was "inspired" by some sources:

- [HeapDump](https://github.com/microsoft/perfview/tree/master/src/HeapDump), which is part of PerfView.
- A StackOverflow [answer](https://stackoverflow.com/a/28844258/21567) given by Vance Morrison, author of PerfView.
- My own previous experiments with this that always failed.

