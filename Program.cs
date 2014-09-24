using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace VMMK
{
	static class Program
	{

		private static Mutex singleInstance;
	
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Program.singleInstance = new Mutex(true, "VirtualMultiMediaKeys");

			if (Program.singleInstance.WaitOne(0, false))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new frmVirtualKeyBoard());
			}
			else
			{

			}
		}
	}
}
