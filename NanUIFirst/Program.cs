using System;
using System.Windows.Forms;
using NetDimension.NanUI;


namespace NanUIFirst
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HtmlUILauncher.EnableFlashSupport = true;

            if (HtmlUILauncher.InitializeChromium((args => {
                args.Settings.LogSeverity = Chromium.CfxLogSeverity.Default;
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
