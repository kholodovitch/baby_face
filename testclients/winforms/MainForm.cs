using System;
using System.Windows.Forms;

namespace winforms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			var core = new Core();
			core.SetCallbackFrame(Callback);
			core.StartStream();
		}

		private void Callback(IntPtr data, int width, int height, int step)
		{
		}
	}
}
