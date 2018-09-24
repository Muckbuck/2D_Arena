using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Manager
{
    public class MapManager : MonoBehaviour
    {

        GameObject wallBlock;
        GameObject groundBlock;
        public static string mapFilePath;

        int wallBlockPosX;
        int wallBlockPosY;

        string[] lines;

        void Awake()
        {
            mapFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Assets/Resources/map1.txt");
            wallBlock = Resources.Load("wallBlock", typeof(GameObject)) as GameObject;
            groundBlock = Resources.Load("groundBlock", typeof(GameObject)) as GameObject;
            lines = System.IO.File.ReadAllLines(mapFilePath);

            RenderMap();

        }

        void RenderMap()
        {

            int screenHeight = Screen.height;
            int screenWidth = Screen.width;
            int mapHeight = lines.Length;
            int mapWidth = lines[0].Length;


            for (int x = 0; x < mapWidth; x++)
            {
                wallBlockPosX = x;
                for (int y = 0; y < mapHeight; y++)
                {
                  
                    Vector3 position = new Vector3(x, y, 1);
                    char wallBlockType = lines[y][x];

                    switch (wallBlockType)
                    {
                        case '*':
                            Instantiate(wallBlock, position, this.transform.rotation);
                            break;
                        case 'o':
                            Instantiate(groundBlock, position, this.transform.rotation);
                            break;
                        case 'x':
                            Instantiate(groundBlock, position, this.transform.rotation);
                            //Play = new HeroBehavior();
                            //hero.SpawnHero(new Vector3(x, y,1));
                            break;
                        
                    }

                }
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}