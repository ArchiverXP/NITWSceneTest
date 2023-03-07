using System.IO;
using System;
using UnityEngine;
using BepInEx;

namespace NightUtils
{
    public class SpriteLoader
    {
        public static Texture2D LoadSprite(string spritePath)
        {
            string path = Path.Combine(Paths.PluginPath, spritePath);

            if (!File.Exists(path))
            {
                Console.WriteLine("FILE DOES NOT EXIST!!!");
            }
            else
            {
                Console.WriteLine("File check succeeded");
            }
            byte[] spriteData = File.ReadAllBytes(path);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(spriteData);
            return tex;
        }
    }
}
