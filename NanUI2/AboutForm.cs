using System.Diagnostics;
using System.Windows.Forms;

namespace NanUI2
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Process.Start("https://github.com/woddle/NanUI2");

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Process.Start("https://github.com/woddle/NanUI2");
		}
	}
}
