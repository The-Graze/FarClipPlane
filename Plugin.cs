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
        void Start()
        {
            CosmeticsV2Spawner_Dirty.OnPostInstantiateAllPrefabs2 += wawa;
        }

        private void wawa()
        {
            Destroy(this);
        }

        public void FixedUpdate()
        {
            foreach (Camera camera in Camera.allCameras)
            {
                if (camera.name != "CameraC")
                {
                    camera.farClipPlane = 99999;
                    camera.nearClipPlane = 0.01f;
                    camera.clearFlags = CameraClearFlags.Skybox;
                }
            }
        }
    }
}
