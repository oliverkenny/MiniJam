using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniJam.DungeonGeneration
{
    public class Dungeon
    {
        public DungeonTile[,] TileMap;
        private int width, height;

        public Dungeon(int _width, int _height, TextureLoader texLoad) {
            width = _width;
            height = _height;

            TileMap = new DungeonTile[width, height];



            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        TileMap[x, y] = new DungeonTile(TileType.WALL, texLoad.TileTextures[TileType.WALL]);
                    }
                    else {
                        TileMap[x, y] = new DungeonTile(TileType.GROUND, texLoad.TileTextures[TileType.GROUND]);
                    }
                }
            }
        }
    }

    public class TextureLoader {
        public Dictionary<TileType, Texture2D> TileTextures = new Dictionary<TileType, Texture2D>();

        public TextureLoader(ContentManager cont) {
            TileTextures.Add(TileType.GROUND, cont.Load<Texture2D>("GroundTexture"));
            TileTextures.Add(TileType.WALL, cont.Load<Texture2D>("WallTexture"));
        }
    }

    public class DungeonTile {
        public TileType Type { get; set; }
        
        public bool PassableTerrain { get; set; }

        private Texture2D Texture { get; set; }

        public DungeonTile(TileType _type, Texture2D tex) {
            Type = _type;

            switch (Type) {
                case TileType.GROUND:
                    PassableTerrain = true;
                    break;
                case TileType.WALL:
                    PassableTerrain = false;
                    break;
            }
        }

        public void Render(SpriteBatch sb) {
            sb.Draw()
        }
    }

    public enum TileType {
        GROUND,
        WALL
    }
}
