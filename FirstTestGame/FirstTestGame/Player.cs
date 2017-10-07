/* Player.cs
 * Author: Justin Miller
 */ 

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FirstTestGame
{
    /// <summary>
    /// Basic test class used as an example of what a 
    /// potential player character could be.
    /// </summary>
    class Player
    {
        /// <summary>
        /// Stores player texture.
        /// </summary>
        public Texture2D PlayerTexture;

        /// <summary>
        /// Stores player position.
        /// </summary>
        public Vector2 Position;

        /// <summary>
        /// Stores whether the player is active or not.
        /// </summary>
        public bool Active;

        /// <summary>
        /// Stores the players health value.
        /// </summary>
        public int Health;

        /// <summary>
        /// gets the players width.
        /// </summary>
        public int Width
        {
            get
            {
                return PlayerTexture.Width;
            }
        }

        /// <summary>
        /// gets the players height.
        /// </summary>
        public int Height
        {
            get
            {
                return PlayerTexture.Height;
            }
        }

        /// <summary>
        /// Used to initialize the player.
        /// </summary>
        /// <param name="texture">The texture being used for the player.</param>
        /// <param name="position">The starting position of the character.</param>
        public void Initialize(Texture2D texture, Vector2 position)
        {
            PlayerTexture = texture;

            Position = position;

            Active = true;

            Health = 100;
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
