/* Bullet.cs
 * Author: Max Wiens-Evangelista & Justin Miller
 * 
 */
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestGame
{
    class Bullet
    {
        public Vector2 _position;
        //public Texture2D _texture = Content.load<Texture2D>("bin\\Windows\\Graphics\\objects\\bullet");

        public void Initialize(Vector2 position)
        {
            _position = position;
        }

        public void Update()
        {
            //Keep traveling forward

            //Destroy when hit physical object removes health if 
        }

        public void Draw()
        {

        }
    }
}
