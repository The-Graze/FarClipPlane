using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace FarClipPlane
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void FixedUpdate()
        {
            Camera.main.farClipPlane = 25000;
        }
    }
}
