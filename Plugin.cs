﻿using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace InstantCareMenu;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
  public override void Load()
  {

    // Plugin startup logic
    Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    Harmony.CreateAndPatchAll(typeof(Patches));
  }
}
