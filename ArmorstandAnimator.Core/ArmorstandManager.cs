using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorstandAnimator.Core
{
	public class ArmorstandManager
	{
		private static List<ArmorstandState> armorstands = new List<ArmorstandState>();

		public static ArmorstandState CreateArmorstand()
		{
			ArmorstandState state = new ArmorstandState();
			if (armorstands.Count == 0)
				state.ID = 0;
			else
				state.ID = armorstands.Last().ID + 1;

			armorstands.Add(state);
			return state;
		}
	}
}