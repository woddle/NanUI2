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


            if (HtmlUILauncher.InitializeChromium((args =>
            {
                args.Settings.LogSeverity = Chromium.CfxLogSeverity.Disable;
            }), cmd =>
            {
                cmd.CommandLine.AppendSwitch("disable-web-security");               // 取消掉安全设置，可以跨域请求数据
                //cmd.CommandLine.AppendArgument("--single-process");               // 没有效果
                cmd.CommandLine.AppendSwitch("disable-direct-write");
                cmd.CommandLine.AppendSwitch("--disable-directwrite-for-ui");
                cmd.CommandLine.AppendSwitch("--single-process");
            }))
            {
                //初始化成功，加载程序集内嵌的资源到运行时中
                HtmlUILauncher.RegisterEmbeddedScheme(System.Reflection.Assembly.GetExecutingAssembly());
                var l = System.Reflection.Assembly.GetExecutingAssembly();

                //启动主窗体
                Application.Run(new SubForm());
            }
        }
    }
}
