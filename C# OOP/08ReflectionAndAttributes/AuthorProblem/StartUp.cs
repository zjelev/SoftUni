using System;

namespace AuthorProblem
{
    [Author("Ventsi")]
    class StartUp
    {
        [Author("Gosho")]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // [Flags]
        // public enum FileAccess
        // {
        //     Read = 1,
        //     Write = 2,
        //     ReadWrite = Read | Write
        // }

        // [DllImport("user32.dll", EntryPoint="MessageBox")]
        // public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);
    }
}
