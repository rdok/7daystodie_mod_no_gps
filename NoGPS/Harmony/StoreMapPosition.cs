using HarmonyLib;

namespace NoMap.Harmony
{
    [HarmonyPatch(typeof(XUiC_MapArea), nameof(XUiC_MapArea.OnClose))]
    public class StoreMapPosition
    {
        private static readonly ILogger Logger = new Logger();

        public static void Postfix(XUiC_MapArea __instance)
        {
            Store.LastKnownMapPosition = __instance.mapMiddlePosPixel;

            Logger.Info($"Stored current map position: {Store.LastKnownMapPosition.Value}");
        }
    }
}