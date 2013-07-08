using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
namespace bw_learning_1
{
	[Serializable()]
	public class EntityBase //base class should derive this ISerializable //TODO derive from something here
	{

		public SpatialPosition Position {get; set;}
		LinkedList<EntityBase> Children { get; private set; }

		void initialize_properties()
		{
			Children = new LinkedList<EntityBase>();
			Position = Vector3.Zero;
		}

		public EntityBase ()
		{
			initialize_properties ();
		}



		//Serialization
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			//TODO
			// Use the AddValue method to specify serialized values.
			//info.AddValue("props", myProperty_value, typeof(string));

		}

		// The special constructor is used to deserialize values. 
		public EntityBase(SerializationInfo info, StreamingContext context)
		{
			//TODO
			// Reset the property value using the GetValue method.
			//myProperty_value = (string) info.GetValue("props", typeof(string));
		}
	}
}

