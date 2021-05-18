using System.Collections.Generic;
using System;

namespace Monke
{
    public class SceneWrapper
    {
        public static Scene[] scenes;
        public static Dictionary<string, int> sceneMap;

        public static void Init()
        {
            sceneMap = new Dictionary<string, int>();

            int i = 0;

            foreach (Scene scene in scenes)
            {
                sceneMap.Add(scene.name, i);

                i++;
            }
        }


        public static int currentScene = 0;
        public static void DrawScene()
        {
            scenes[currentScene].Draw();
            scenes[currentScene].dialogue[0].Draw();

        }

        //return an int from the SceneWrapper sceneMap pls :dorime:
        public static int ChangeScene(string nextScene)
        {
            int n = 0;

            return n;
        }

    }
}
