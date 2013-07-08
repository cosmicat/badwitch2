using System;
using Microsoft.Xna.Framework;
namespace bw_learning_1
{
	public class SpatialPosition
	{
		Vector3 position = Vector3.Zero;
		Vector3 scale = new Vector3 (1, 1, 1);
		Quaternion rotation = Quaternion.Identity;

		public SpatialPosition ()
		{

		}


		//flat operators
		Vector2 FlatPosition
		{
			get{
				return new Vector2 (position.X, position.Y);
			}
			set{
				position = new Vector3 (value.x, value.y, position.Z);
			}
		}
		Vector2 FlatScale
		{
			get{
				return new Vector3(scale.X,scale.Y);
			}
			set{
				scale = new Vector3 (value.x, value.y, scale.Z);
			}
		}
		float FlatRotation
		{
			get{
				//TODO
				return 0;
			}
			set{
				Quaternion.CreateFromAxisAngle (Vector3.Forward, value, out rotation);
			}
		}

		//TODO relative operators...
	}
}

