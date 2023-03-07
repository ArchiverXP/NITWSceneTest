using System.IO;
using BepInEx;
using NightUtils;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;


namespace NITWBizarreWorlds.MWorld
{
    public class Mysterious : MonoBehaviour
    {
        GameObject floor;
        GameObject CameraCon;
        Sprite spite23;
        Texture2D eddy;
        GameObject Axel;
        GameObject MamaLuigi;

        public void MysteriousWorld()
        {
            //Global.screenTransitioner.FadeOut(1f);
            Scene MysteryWorld = SceneManager.CreateScene("Mysterious");
            var TitleScene = SceneManager.GetActiveScene();
            SceneManager.UnloadSceneAsync(TitleScene);
            SceneManager.SetActiveScene(MysteryWorld);
            Global.screenTransitioner.WipeLeftIn(1f);
            MamaLuigi = new GameObject("Mysterious");
            MamaLuigi.AddComponent<SceneRoot>();
            floor = new GameObject("Floor");
            Axel = new GameObject("Box");
            floor.transform.parent = MamaLuigi.transform;
            var eddward = floor.AddComponent<BoxCollider>();
            //var superEdd = MamaLuigi.AddComponent<SceneRoot>();
            var tom = floor.AddComponent<RectTransform>();
            var edd = floor.AddComponent<SpriteRenderer>();
            var tord = floor.AddComponent<Entity>();
            eddy = SpriteLoader.LoadSprite(Path.Combine(Paths.PluginPath, "SceneTest/Assets/Sprites/ground.png"));
            spite23 = Sprite.Create(eddy, new Rect(0.0f, 0.0f, eddy.width, eddy.height), new Vector2(0.0f, 0.0f), 100.0f);
            tom.localScale = new Vector3(770.7019f, 88.862f, 1f);
            tom.localPosition = new Vector2(-11.1418f, -6.3709f);
            eddward.size = new Vector3(770.7019f, 88.862f, 1f);
            eddward.center = new Vector3(0.025f, 0.025f, 0f);
            eddward.extents = new Vector3(0.025f, 0.025f, 0.1f);
            eddward.size = new Vector3(0.05f, 0.05f, 0.2f);
            tord.CollideAll(Entity.Type.Player, new Vector3(770.7019f, 88.862f, 1f));
            var matt = new BoundingBox();
            matt.width = 770.7019f;
            matt.height = 88.862f;
            tord.CollideBox(matt);
            tord.surfaceDustType = SurfaceDustType.Normal;
            tord.type = Entity.Type.Obstruction;
            tord.surfaceSoundType = SurfaceSoundType.Normal;
            tord.sfxJump = "";
            tord.sfxBounceLarge = "";
            tord.sfxBounceSmall = "";
            tord.sfxFallThrough = "";
            tord.sfxLand = "";
            tord.sfxStep = "";
            tord.surfaceLayerName = "";
            tord.isPowerline = false;
            //Instantiate(Global.prefabs.cameraControl);
            Global.prefabs.player.transform.parent = MamaLuigi.transform;
            RenderSettings.ambientLight = Color.white;
            floor.layer = 9;


            edd.sprite = spite23;
            
        }
    }
}
