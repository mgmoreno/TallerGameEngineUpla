using UnityEngine;

namespace upla.gameengine
{
    public static class LayerMaskHelper
    {
        public static bool IsInLayerMask(LayerMask layerMask, GameObject obj)
        {
            return ((layerMask.value & (1 << obj.layer)) > 0);
        }
    }
}
