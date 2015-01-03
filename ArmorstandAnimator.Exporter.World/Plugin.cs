using ArmorstandAnimator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Plugin
{
	public static string Main = "ArmorstandAnimator.Exporter.World.Exporter";
}

namespace ArmorstandAnimator.Exporter.World
{
	public class Exporter : IPlugin
	{
		public string Name { get { return "Minecraft 1.8 World Exporter"; } }

		public void Load()
		{
			Application.AddExporter(new Exporter());
		}
	}
}