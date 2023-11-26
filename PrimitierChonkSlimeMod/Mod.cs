using MelonLoader;
using HarmonyLib;
using Il2Cpp;

namespace PrimitierChonkSlimeMod
{
    public class Mod : MelonMod
    {

    }

    [HarmonyPatch(typeof(SlimeBase), nameof(SlimeBase.EatFood))]
    public static class SlimeBaseEatFoodPatch
    {
        private static void Prefix(ref float efficiency)
        {
            efficiency = 100f;
        }
    }
}