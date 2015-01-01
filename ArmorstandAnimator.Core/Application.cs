using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorstandAnimator.Core
{
	public class Application
	{
		public static event EventHandler<IExporter> OnAddExporter;

		public void AddExporter(IExporter exporter)
		{
			OnAddExporter(this, exporter);
		}
	}
}