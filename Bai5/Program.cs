using System;
using System.Windows.Forms;

namespace WinFormBaiTap
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy thử Bài 5:
            Application.Run(new Bai5Form());

            // Muốn chạy Bài 6 thì đổi thành:
            // Application.Run(new Bai6Form());
        }
    }
}