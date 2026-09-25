using UnityEngine;

namespace AimDragCache
{
    public class AimDragCacheOverlay : MonoBehaviour
    {
        public AimDragCacheManager cacheManager;
        public Color overlayColor = Color.green;
        public float markerRadius = 5.0f;

        void OnGUI()
        {
            if (cacheManager == null) return;

            Vector3 targetPos = cacheManager.GetCachedPosition(101);
            if (targetPos != Vector3.zero)
            {
                Vector3 screenPos = Camera.main.WorldToScreenPoint(targetPos);
                if (screenPos.z > 0)
                {
                    GUI.color = overlayColor;
                    GUI.DrawTexture(new Rect(screenPos.x - markerRadius, Screen.height - screenPos.y - markerRadius, markerRadius * 2, markerRadius * 2), Texture2D.whiteTexture);
                }
            }
        }
    }
}
