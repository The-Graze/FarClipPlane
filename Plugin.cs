using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace FarClipPlane
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void FixedUpdate()
        {
            foreach(Camera camera in Camera.allCameras)
            {
                camera.farClipPlane = float.MaxValue;
                camera.clearFlags = CameraClearFlags.Skybox;
            }
        }
    }
}
