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
    public partial class SubForm:Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
               HtmlUIControl d = new HtmlUIControl();
            }
        }

    }
}
