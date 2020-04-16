using System;
using System.Windows.Forms;

namespace pooremma
{
	internal class Program
	{
		public Program()
		{
		}

		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Randomizer());
		}
	}
}