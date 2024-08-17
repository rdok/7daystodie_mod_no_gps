using HarmonyLib;

namespace NoMap.Harmony
{
    [HarmonyPatch(typeof(XUiC_MapArea), nameof(XUiC_MapArea.PositionMapAt))]
    public class RestoreMapPosition
    {
        private static readonly ILogger Logger = new Logger();

        public static bool Prefix(XUiC_MapArea __instance)
        {
            if (!Store.LastKnownMapPosition.HasValue) return true;

            Logger.Info($"Restoring last known map position: {Store.LastKnownMapPosition.Value}");
            __instance.mapMiddlePosChunks = Store.LastKnownMapPosition.Value;
            __instance.mapMiddlePosPixel = Store.LastKnownMapPosition.Value;
            __instance.updateFullMap();

            return false;
        }
    }
}