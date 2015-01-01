using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArmorstandAnimator.Core
{
	public interface IExporter
	{
		bool IsDirectory { get; }

		string FileExtension { get; }

		void Export(string path, AnimationManager manager);
	}
}