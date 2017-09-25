using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NanUI2;
using Chromium;

namespace NanUIFirst
{
    public partial class MainForm : HtmlUIForm
    {
        public MainForm() : base("embedded://www/index3.html")
        {
            InitializeComponent();
            //在js中注册一个方法来打开About窗口
            GlobalObject.AddFunction("showAboutForm").Execute += (sender, args) =>
            {
                ShowAboutNanUI();
                //ShowAboutWindow();
            };

            GlobalObject.AddFunction("showDevTools").Execute += (sender, args) =>
            {
                ShowDevTools();
            };

            LifeSpanHandler.OnBeforePopup += (sender, args) =>
            {

            };

            LifeSpanHandler.OnAfterCreated += (sender, args) =>
            {

            };


        //网页加载完成时触发事件
        LoadHandler.OnLoadEnd += (sender, args) =>
        {
            //判断下触发的事件是不是主框架的
            if(args.Frame.IsMain)
            {
                //执行JS，将当前的CEF运行版本等信息通过JS加载到网页上
                //var js = string.Format("$client.setRuntimeInfo({{ api: ['{CfxRuntime.ApiHash(0)}', '{CfxRuntime.ApiHash(1)}'], cef:'{CfxRuntime.GetCefVersion()}', chrome:'{CfxRuntime.GetChromeVersion()}',os:'{CfxRuntime.PlatformOS}', arch:'{CfxRuntime.PlatformArch}'}});");

                var js = string.Format("alert('{0}')", CfxRuntime.ApiHash(1));
                object a = CfxRuntime.GetCefVersion();
                //ExecuteJavascript(js);

                
                

                this.UpdateUI(() =>
                {
                    //显示字窗体的过程，不解释
                    SubForm su = new SubForm();
                    //su.Show();

                });

            }
                

        };
        }


        private void ShowAboutWindow()
        {
            //因为当前环境中的JS代码跑在另外的线程上，所以在Control上扩展个UpdateUI方法，简化InvokeRequired流程
            this.UpdateUI(() =>
            {
                //显示字窗体的过程，不解释
                MessageBox.Show("asd");

            });
        }
    }

}
