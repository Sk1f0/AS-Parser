using Parser.Core;
using Parser.Core.MmoNews;
using System;
using System.Windows.Forms;

namespace Parser
{
	public partial class FormMain : Form
	{
		ParserWorker<string[]> parser;

		public FormMain()
		{
			InitializeComponent();
			parser = new ParserWorker<string[]>(new MmoParser());

			parser.OnCompleted += Parser_OnCompleted;
			parser.OnNewData += Parser_OnNewData;
		}

		private void Parser_OnNewData(object arg1, string[] arg2)
		{
			ListTitles.Items.AddRange(arg2);
		}

		private void Parser_OnCompleted(object obj)
		{
			MessageBox.Show("All works done!");
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			parser.ParserSettings = new MmoSettings((int)NumericStartPoint.Value, (int)NumericEndPoint.Value);
			parser.Start();
		}

		private void ButtonAbort_Click(object sender, EventArgs e)
		{
			parser.Abort();
		}
	}
}
