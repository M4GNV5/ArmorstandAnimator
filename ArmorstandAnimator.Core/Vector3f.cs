using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorstandAnimator.Core
{
	public class Vector3f
	{
		public float X { get; set; }

		public float Y { get; set; }

		public float Z { get; set; }

		public Vector3f()
			: this(0)
		{
		}

		public Vector3f(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Vector3f(float scalar)
			: this(scalar, scalar, scalar)
		{
		}

		public Vector3f Lerp(Vector3f b, float t)
		{
			return new Vector3f(X * (1 - t) + b.X * t, Y * (1 - t) + b.Y * t, Z * (1 - t) + b.Z * t);
		}

		public Vector3f Copy()
		{
			return new Vector3f(X, Y, Z);
		}

		public static readonly Vector3f One = new Vector3f(1, 1, 1);
		public static readonly Vector3f Zero = new Vector3f(0, 0, 0);
	}
}