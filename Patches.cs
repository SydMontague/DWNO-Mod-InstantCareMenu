using HarmonyLib;

namespace InstantCareMenu
{
  class Patches
  {
    [HarmonyPatch(typeof(PartnerCtrl), "_UpdateIsReadyCare")]
    [HarmonyPrefix]
    static bool _UpdateIsReadyCare_Prefix(PartnerCtrl __instance)
    {
      if (__instance._StartReadyCareMove())
      {
        __instance.IsReadyCare = true;
        __instance.m_IsReadyCareMove = false;
      }
      return false;
    }

    [HarmonyPatch(typeof(MainGameCare), "_Start")]
    [HarmonyPrefix]
    static bool _Start_Prefix(MainGameCare __instance)
    {
      switch (__instance.m_Step.subStep)
      {
        case 3:
        case 5:
          if (__instance.m_Step.subFrame < 30f)
            __instance.m_Step.UpdateFrame(30f);
          break;
      }

      return true;
    }
  }
}
