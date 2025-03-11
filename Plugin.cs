using BepInEx;
using GorillaNetworking;
using System;
using UnityEngine;
using Utilla;

namespace FarClipPlane
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool init;
        void Start()
        {
            GorillaTagger.OnPlayerSpawned(delegate { CosmeticsV2Spawner_Dirty.OnPostInstantiateAllPrefabs2 += delegate { init = true; }; });
        }
        public void FixedUpdate()
        {
            if (init)
            {
                foreach (Camera camera in Camera.allCameras)
                {
                    camera.farClipPlane = float.MaxValue -1;
                    camera.nearClipPlane = 0.001f;
                    camera.clearFlags = CameraClearFlags.Skybox;
                }
            }
        }
    }
}
