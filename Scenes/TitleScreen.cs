using UnityEngine;
using UnityEngine.SceneManagement;
using NightUtils;
using System.IO;
using BepInEx;
using System.Collections;

namespace NITWBizarreWorlds.Scenes2
{

    public class Scenes : MonoBehaviour
    {
        public Sprite spite;
        public Texture2D irios23;

        Global global;
        public void Scene1()
        {
            Scene TitleScene = SceneManager.CreateScene("TitleScreen");
            SceneManager.SetActiveScene(TitleScene);
            var luggie234 = new GameObject("SpriteHandler23");
            var luigi3 = luggie234.AddComponent<SpriteRenderer>();
            irios23 = SpriteLoader.LoadSprite(Path.Combine(Paths.PluginPath, "SceneTest/Assets/Sprites/logo.png"));
            spite = Sprite.Create(irios23,new Rect(0.0f, 0.0f,irios23.width,irios23.height), new Vector2(0.0f,0.0f), 100.0f);
            luigi3.sprite = spite;
            luigi3.transform.SetPositionX(-3.9836f);
            luigi3.transform.SetPositionY(-2.6036f);
            var luggie = GameObject.Find("_CameraControl");
            GameObject.DestroyImmediate(luggie);
            SceneManager.MoveGameObjectToScene(luggie234, TitleScene);
            Global.screenTransitioner.FadeIn(1f);
        }
    }
}
