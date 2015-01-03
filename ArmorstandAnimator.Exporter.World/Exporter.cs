using ArmorstandAnimator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorstandAnimator.Exporter.World
{
	public class Exporter : IExporter
	{
		public string Name { get { return "1.8 World Exporter"; } }

		public bool IsDirectory { get { return true; } }

		public string FileExtension { get { return ""; } }

		public void Export(string path, AnimationManager manager)
		{
		}
	}
}