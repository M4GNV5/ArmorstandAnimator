using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArmorstandAnimator.Core
{
	public class AnimationManager
	{
		private Dictionary<int, Dictionary<float, ArmorstandState>> keyframes = new Dictionary<int, Dictionary<float, ArmorstandState>>();

		public void AddKeyframes(Dictionary<float, ArmorstandState> keyframes)
		{
			if (keyframes.Count > 0)
				this.keyframes.Add(keyframes.First().Value.ID, keyframes);
		}

		public List<ArmorstandState> GetState(float time)
		{
			List<ArmorstandState> states = new List<ArmorstandState>();
			Dictionary<float, ArmorstandState> k;

			foreach (var keyframe in keyframes)
			{
				k = keyframe.Value;

				if (k.ContainsKey(time))
					states.Add(k[time]);
				else if (k.Count > 1)
				{
					k = k.OrderBy(i => i.Key).ToDictionary(x => x.Key, x => x.Value);

					if (k.First().Key >= time)
						states.Add(k.First().Value);
					else
					{
						var frames = k.ToList();
						for (int i = 1; i < frames.Count; i++)
						{
							if (frames[i].Key >= time)
							{
								float begin = frames[i - 1].Key;
								float diff = frames[i].Key - frames[i - 1].Key;
								float t = (time - begin) / diff;

								states.Add(frames[i - 1].Value.Lerp(frames[i].Value, t));
								break;
							}
						}
					}
				}
				else if (k.Count == 1)
				{
					states.Add(k.First().Value);
				}
			}

			return states;
		}
	}
}