using System.Runtime.InteropServices;
using System.Text;

namespace LunarS
{
    public class Program
    {
        public static string GetActiveWindowTitle()
        {
            [DllImport("user32.dll")]
            static extern IntPtr GetForegroundWindow();

            [DllImport("user32.dll")]
            static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            else
            {
                return "";
            }
        }
        public static int Main()
        {
            Console.WriteLine("smartlistener thread started");
            while (true)
            {
                string tit = GetActiveWindowTitle();
                if (tit != "" && tit.ToLower().Contains("anmelden")
                    || tit.ToLower().Contains("login")
                    || tit.ToLower().Contains("register")
                    || tit.ToLower().Contains("registrieren"))
                {
                    Console.WriteLine("In login screen!");
                }
                else
                {
                    continue;
                }
            }
        }

    }
}