using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ArmorstandAnimator.Core
{
	public class ArmorstandState
	{
		public ArmorstandState()
		{
			BodyPose = Vector3f.Zero;
			LArmPose = Vector3f.Zero;
			RArmPose = Vector3f.Zero;
			LLegPose = Vector3f.Zero;
			RLegPose = Vector3f.Zero;
			HeadPose = Vector3f.Zero;
		}

		public int ID { get; set; }

		public bool Enabled { get; set; }

		public bool Invisible { get; set; }

		public bool NoBasePlate { get; set; }

		public bool NoGravity { get; set; }

		public Vector3f BodyPose { get; set; }

		public Vector3f LArmPose { get; set; }

		public Vector3f RArmPose { get; set; }

		public Vector3f LLegPose { get; set; }

		public Vector3f RLegPose { get; set; }

		public Vector3f HeadPose { get; set; }

		public bool ShowArms { get; set; }

		public bool Small { get; set; }

		public ArmorstandState Lerp(ArmorstandState b, float t)
		{
			ArmorstandState c = new ArmorstandState();
			c.ID = ID;
			c.Enabled = b.Enabled;
			c.Invisible = b.Invisible;
			c.NoBasePlate = b.NoBasePlate;
			c.NoGravity = b.NoGravity;
			c.BodyPose = BodyPose.Lerp(b.BodyPose, t);
			c.LArmPose = LArmPose.Lerp(b.LArmPose, t);
			c.RArmPose = RArmPose.Lerp(b.RArmPose, t);
			c.LLegPose = LLegPose.Lerp(b.LLegPose, t);
			c.RLegPose = RLegPose.Lerp(b.RLegPose, t);
			c.HeadPose = HeadPose.Lerp(b.HeadPose, t);
			c.ShowArms = b.ShowArms;
			c.Small = b.Small;
			return c;
		}

		public ArmorstandState Copy()
		{
			ArmorstandState c = new ArmorstandState();
			c.ID = ID;
			c.Enabled = Enabled;
			c.Invisible = Invisible;
			c.NoBasePlate = NoBasePlate;
			c.NoGravity = NoGravity;
			c.BodyPose = BodyPose.Copy();
			c.LArmPose = LArmPose.Copy();
			c.RArmPose = RArmPose.Copy();
			c.LLegPose = LLegPose.Copy();
			c.RLegPose = RLegPose.Copy();
			c.HeadPose = HeadPose.Copy();
			c.ShowArms = ShowArms;
			c.Small = Small;
			return c;
		}
	}
}