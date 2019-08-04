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
		public float SecondCounter { get; set; }

		public Animation(GameTime gameTime, Texture2D[] frames, float? animationSpeed = null, int? currentFrame = null)
		{
			this.Frames = frames;
			this.AnimationSpeed = animationSpeed ?? ANIMATIONSPEED * (float)gameTime.ElapsedGameTime.TotalSeconds;
			this.CurrentFrame = currentFrame ?? 0;
		}

		public void Update(GameTime gameTime)
		{
			SecondCounter += gameTime.ElapsedGameTime.Seconds;

			// If frame needs iterating
			if (SecondCounter > 60 / ANIMATIONSPEED)
			{
				// Iterate frame
				CurrentFrame++;

				// If at last frame
				if (CurrentFrame > Frames.Length) {
					CurrentFrame = 0;
				}

				// Reset frame counter
				SecondCounter -= 60 / ANIMATIONSPEED;
			}
		}

		public Texture2D GetFrame()
		{
			return Frames[CurrentFrame];
		}
	}
}
