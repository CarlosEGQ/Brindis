using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproyecto
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			GlobalUser = new Users();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
		private static Users _User;
		public static Users GlobalUser
		{
			get { return _User; }
			set { _User = value; }
		}
        public static Clients GlobalClient
        {
            get { return _Client; }
            set { _User = value; }
        }
    }
}
