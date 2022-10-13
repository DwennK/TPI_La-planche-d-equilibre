using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices; //Permet d'accéder à la DLL

namespace TPI
{
    public class K8055
    {
        [DllImport("K8055D.dll")]
        public static extern int OpenDevice(int CardAddress);

        [DllImport("K8055D.dll")]
        public static extern void CloseDevice();

        [DllImport("K8055D.dll")]
        public static extern int ReadAnalogChannel(int Channel);

        [DllImport("K8055D.dll")]
        public static extern void ReadAllAnalog(int Data1, int Data2);

        [DllImport("K8055D.dll")]
        public static extern void OutputAnalogChannel(int Channel, int Data);

        [DllImport("K8055D.dll")]
        public static extern void OutputAllAnalog(int Data1, int Data2);

        [DllImport("K8055D.dll")]
        public static extern void ClearAnalogChannel(int Channel);

        [DllImport("K8055D.dll")]
        public static extern void SetAllAnalog();

        [DllImport("K8055D.dll")]
        public static extern void ClearAllAnalog();

        [DllImport("K8055D.dll")]
        public static extern void SetAnalogChannel(int Channel);

        [DllImport("K8055D.dll")]
        public static extern void WriteAllDigital(int Data);

        [DllImport("K8055D.dll")]
        public static extern void ClearDigitalChannel(int Channel);

        [DllImport("K8055D.dll")]
        public static extern void ClearAllDigital();

        [DllImport("K8055D.dll")]
        public static extern void SetDigitalChannel(int Channel);

        [DllImport("K8055D.dll")]
        public static extern void SetAllDigital();

        [DllImport("K8055D.dll")]
        public static extern bool ReadDigitalChannel(int Channel);

        [DllImport("K8055D.dll")]
        public static extern int ReadAllDigital();

        [DllImport("K8055D.dll")]
        public static extern int ReadCounter(int CounterNr);

        [DllImport("K8055D.dll")]
        public static extern void ResetCounter(int CounterNr);

        [DllImport("K8055D.dll")]
        public static extern int SetCounterDebounceTime(int CounterNr, int DebounceTime);
    }
}
