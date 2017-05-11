using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetDimension.NanUI;
using Chromium;

namespace NanUIFirst
{
    public partial class SubControl : HtmlUIControl 
    {
        public SubControl()
            : base("embedded://www1/index.html")
        {
            InitializeComponent();
        }
    }
}
