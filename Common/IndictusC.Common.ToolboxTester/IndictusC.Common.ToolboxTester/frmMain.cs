using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndictusC.Common;

namespace IndictusC.Common.ToolboxTester
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			//this._runTest("StringUtils.Split");
			this._runTest("StringUtils.IsInList");
		}

		private void _runTest(string sTestName)
		{
			try
			{
				switch (sTestName)
				{
					case ("StringUtils.Split"):
						{
							ArrayList arr = Toolbox.StringUtils.Split("skam;den;som;ger;sig", ";");
							foreach (string s in arr)
							{
								this.txtData.AppendText(s + Environment.NewLine);
							}
							break;
						}

					case ("StringUtils.IsInList"):
						{							
							List<string> list_1 = new List<string>(new string[] { "a", "b", "c" });
							List<string> list_2 = new List<string>(new string[] { "d", "e", "f" });

							bool b = Toolbox.StringUtils.IsInList(list_1, list_2, false);
							this.txtData.AppendText(b.ToString());
							break;
						}

					default: break;
				}
			}
			catch (Exception ex) { throw ex; }
		}
	}
}
