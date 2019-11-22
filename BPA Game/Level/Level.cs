using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace BPA_Game
{
    enum terrainType { air, ground, lava };
    class Level
    {
        private Bitmap _levelImage; //image of the level
        private string _levelPath; //path to accesses file
        private Color[][] _levelColors; //the colors of the image stored as an array
        private terrainType[][] _levelTerrain;


        //constructor
        public Level(string levelPath) 
        {
            _levelPath = levelPath;
            _levelImage = new Bitmap(_levelPath); //creates the image
            for (int i = 0; i < _levelImage.Width; i++)
            {
                for (int j = 0; j < _levelImage.Height; j++)
                {
                    _levelColors[i][j] = _levelImage.GetPixel(i, j); //sets each of the pixel colors in the _levelColor array
                }
            }
        }

        public void initializeTerrain()
        {
            //TODO:
            //set each of the terrain types based on colors
        }

        public void drawTerrain()
        {
            //TODO:
            //draw the terrain based the the terrin array
        }
    }
}
