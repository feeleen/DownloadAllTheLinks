using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloaderAllTheLinks
{
	public static class Util
	{
		public static void InvokeIfRequired(this Control c, Action<Control> action)
		{
			if (c.InvokeRequired)
			{
				c.Invoke(new Action(() => action(c)));
			}
			else
			{
				action(c);
			}
		}
	}
}
