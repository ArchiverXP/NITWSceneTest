using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections;
using NITWBizarreWorlds.Scenes2;
using NITWBizarreWorlds.MWorld;
using HarmonyLib;

namespace NITWBizarreWorlds
{
    [BepInPlugin("com.archiverxp.bizarreworlds", "Night in the Woods 2: Bizarre Worlds", "0.1")]
    public class Plugin : BaseUnityPlugin
    {

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {"com.archiverxp.bizarreworlds"} is loaded!");
            //AssetBundle bundle = AssetBundle.LoadFromFile(Path.Combine(Paths.PluginPath, "BizarreWorlds/Assets/Scenes/blank"));
            SceneManager.LoadScene("TransitionScene", LoadSceneMode.Single);
            var bower = GameObject.Find("CameraBlack");
            GameObject.DestroyImmediate(bower);
            hastitleRun = false;

        }

        void Start()
        {
            var mariocheck = new Scenes();
            mariocheck.Scene1();
        }

        bool hastitleRun;
        void Update()
        {     
            if (hastitleRun == false)
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    Global.screenTransitioner.FadeOut(1f);
                    hastitleRun = true;
                    var sceneload2 = new Mysterious();
                    sceneload2.MysteriousWorld();
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    
                }
            }
        }
    }
}
