/* Player.cs
 * Author: Justin Miller
 */ 

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestPlayer
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
        public Texture2D _playerTexture;

        /// <summary>
        /// Stores player position.
        /// </summary>
        public Vector2 _position;

        /// <summary>
        /// Stores whether the player is active or not.
        /// </summary>
        public bool _active;

        /// <summary>
        /// Stores the players health value.
        /// </summary>
        public int _health;

        /// <summary>
        /// gets the players width.
        /// </summary>
        public int Width
        {
            get
            {
                return _playerTexture.Width;
            }
        }

        /// <summary>
        /// gets the players height.
        /// </summary>
        public int Height
        {
            get
            {
                return _playerTexture.Height;
            }
        }

        /// <summary>
        /// Used to initialize the player.
        /// </summary>
        /// <param name="texture">The texture being used for the player.</param>
        /// <param name="position">The starting position of the character.</param>
        public void Initialize(Texture2D texture, Vector2 position)
        {
            _playerTexture = texture;

            _position = position;

            _active = true;

            _health = 100;
        }

        /// <summary>
        /// Method that updates the sprite.
        /// </summary>
        public void Update()
        {
            
        }
         /// <summary>
         /// Draws (Adds until further knowledge) the information in the player class to a sprite batch.
         /// </summary>
         /// <param name="spriteBatch">The spriteBatch being added to.</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_playerTexture, _position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
