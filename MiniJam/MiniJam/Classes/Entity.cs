using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniJam.Classes
{
	public abstract class Entity
	{
		public string Name { get; set; }
		public Vector2 Position { get; set; }

		public abstract void Update();
		public abstract void Draw();
	}
}
