using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marmalade.Editor
{
	public partial class GameDocumentWindow : Form
	{
		public GameDocumentWindow()
		{
			InitializeComponent();
		}

		private void MenuExit(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
