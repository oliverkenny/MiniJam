using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniJam.Engine
{
	public class Animation
	{
		const float ANIMATIONSPEED = 4f;
		private Texture2D[] Frames { get; set; }
		private int CurrentFrame { get; set; }
		public float AnimationSpeed { get; set; }

		public Animation(GameTime gameTime, Texture2D[] frames, float? animationSpeed = null)
		{
			this.Frames = frames;
			this.AnimationSpeed = animationSpeed ?? ANIMATIONSPEED * (float)gameTime.ElapsedGameTime.TotalSeconds;
		}

		public void Update()
		{

		}

		public void Draw()
		{

		}
	}
}
