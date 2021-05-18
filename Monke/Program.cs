using System.Runtime.InteropServices;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System;
using Raylib_cs;
using Newtonsoft.Json;
using System.IO;

namespace Monke
{
    class Program
    {
        private static int height = 960;
        private static int width = 1280;

        public static int GetHeight()
        {
            return height;
        }
        public static int GetWidth()
        {
            return width;
        }


        static void Main(string[] args)
        {
            Raylib.InitWindow(width, height, "Monke");

            string fileName = @"Data.json";
            System.Console.WriteLine(File.Exists(fileName));


            string contents = File.ReadAllText(fileName);
            SceneWrapper sw = JsonConvert.DeserializeObject<SceneWrapper>(contents);
            sw.Init();


            int x = 0;
            sw.scenes[x].Draw();


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                sw.scenes[0].Draw();
                sw.scenes[0].dialogue[0].Draw();

                Raylib.EndDrawing();

            }
        }
    }
}
