﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;

namespace BPA_Game
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
       
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic related content.  
        /// Calling base.Initialize will enumerate through any components and initialize them as well.
        protected override void Initialize()
        {
            // TODO: 
            //Add initialization logic here
            Level testLevel = new Level( Path.GetFullPath(Directory.GetCurrentDirectory() + "\\Assets\\testLevel.bmp"));

            base.Initialize();
        }

        // LoadContent will be called once per game and is the place to load  all of your content.
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: 
            //use this.Content to load your game content here
        }

        // UnloadContent will be called once per game and is the place to unload game-specific content.
        protected override void UnloadContent()
        {
            // TODO: 
            //Unload any non ContentManager content here
        }

        // Allows the game to run logic such as updating the world, checking for collisions, gathering input, and playing audio.
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: 
            //Add  update logic here

            base.Update(gameTime);
        }

        // This is called when the game should draw itself.
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
