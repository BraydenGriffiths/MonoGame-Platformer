using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;
using Microsoft.Xna.Framework;


namespace NewProject
{
    class Asteroid
    {
        Sprite sprite = new Sprite();
        float asteroidRotation = 0;


        public Asteroid()
        {
            sprite.position.X += 300;
            sprite.position.Y += 300;
        }
        public void Load(ContentManager content)
        {



            sprite.Load(content, "rock_large");
        }
        public void ConstRotate()
        {

        }
        public void Update(float deltaTime)
        {
            asteroidRotation += deltaTime * 4;
            sprite.Update(deltaTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
            
        }
    }
}
