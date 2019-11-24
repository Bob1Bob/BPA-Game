using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace BPA_Game
{
    enum terrainType { air, ground, lava, water };
    class Level
    {
        private Bitmap _levelImage; //image of the level
        private int _imageWidth;
        private int _imageHeight;
        private string _levelPath; //path to accesses file
        private Color[,] _levelColors; //the colors of the image stored as an array
        private terrainType[,] _levelTerrain;


        //constructor
        public Level(string levelPath) 
        {
            _levelPath = levelPath;
            _levelImage = (Bitmap)Image.FromFile(_levelPath); //creates the image
            _imageWidth = _levelImage.Width;
            _imageHeight = _levelImage.Height;
            _levelColors = new Color[_imageWidth, _imageHeight]; //sets size of array to the size of the image
            for (int i = 0; i < _levelImage.Width; i++)
            {
                for (int j = 0; j < _levelImage.Height; j++)
                {
                    _levelColors[i,j] = _levelImage.GetPixel(i, j); //sets each of the pixel colors in the _levelColor array
                }
            }
        }

        public void initializeTerrain()
        {
            ///sets the width to the width of the image divided by ten
            ///sets the heigh to the height of the image divided by ten
            ///it is divided by ten because every ten pixels is singe block of terrain
            _levelTerrain = new terrainType[_imageWidth / 10, _imageHeight / 10];
            for (int i = 0; i < _levelTerrain.GetLength(0); i++)
            {
                for (int j = 0; j < _levelTerrain.GetLength(1); j++)
                {
                    int r = _levelColors[i*10, j*10].R;
                    int g = _levelColors[i*10, j*10].G;
                    int b = _levelColors[i*10, j*10].B;
                    int input = r * 256 * 256 + g * 256 + b; //makes it become an integer that is unique based off of its RGB value

                    switch (input)
                    {
                        //RGB 255 0 0
                        case 16711680:
                            break;
                        
                        //RGB 0 0 255
                        case 255:
                            break;

                        //RGB 0 0 0
                        case 0:
                            break;

                        //RGB 255 255 255
                        case 16777215:
                            break;

                        //RGB is undefined
                        default:
                            break;
                    }

                }
            }

        }

        public void drawTerrain()
        {
            //TODO:
            //draw the terrain based the the terrin array
        }
    }
}
