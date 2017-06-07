using System;
using System.Windows.Forms;
using NanUI2;


namespace NanUIFirst
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HtmlUILauncher.EnableFlashSupport = false;          // 需要引用PepperFlash文件夹
            

            if (HtmlUILauncher.InitializeChromium((args => {
                args.Settings.LogSeverity = Chromium.CfxLogSeverity.Disable;
            })))
            {
                //初始化成功，加载程序集内嵌的资源到运行时中
                HtmlUILauncher.RegisterEmbeddedScheme(System.Reflection.Assembly.GetExecutingAssembly());
                var l = System.Reflection.Assembly.GetExecutingAssembly();

                //启动主窗体
                Application.Run(new MainForm());
            }
        }
    }
}
