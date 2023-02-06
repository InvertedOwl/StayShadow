using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace StayShadow
{
    public static class BuildInfo
    {
        public const string Name = "StayShadow"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "The choice between shadow or not persists"; // Description for the Mod.  (Set as null if none)
        public const string Author = "InvertedOwl"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.0.1"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class StayShadow : MelonMod
    {

        public override void OnSceneWasLoaded(int buildindex, string sceneName) 
        {
            GameObject shadowToggle = GameObject.Find("Toggle Shadows");

            MelonLogger.Msg(PlayerPrefs.GetString("shadow"));

            if (PlayerPrefs.HasKey("shadow"))
            {
                if (PlayerPrefs.GetString("shadow") == "False")
                {
                    shadowToggle.GetComponent<Toggle>().isOn = !shadowToggle.GetComponent<Toggle>().isOn;
                    GameObject.Find("Directional Light").GetComponent<Light>().shadows = LightShadows.None;
                }
            }
            shadowToggle.GetComponent<Toggle>().onValueChanged.AddListener(delegate
            {
                OnShadowToggle(shadowToggle.GetComponent<Toggle>());
            });
        }

        public void OnShadowToggle(Toggle t)
        {
            PlayerPrefs.SetString("shadow", (t.isOn) + "");
        }
    }
}