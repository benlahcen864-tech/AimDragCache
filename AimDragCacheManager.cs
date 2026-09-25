using System.Collections.Generic;
using UnityEngine;

namespace AimDragCache
{
    public class AimDragCacheManager : MonoBehaviour
    {
        private Dictionary<int, Vector3> entityPositionCache = new Dictionary<int, Vector3>();

        public void UpdateCache(int entityId, Vector3 position)
        {
            if (entityPositionCache.ContainsKey(entityId))
            {
                entityPositionCache[entityId] = position;
            }
            else
            {
                entityPositionCache.Add(entityId, position);
            }
        }

        public Vector3 GetCachedPosition(int entityId)
        {
            if (entityPositionCache.TryGetValue(entityId, out Vector3 cachedPos))
            {
                return cachedPos;
            }
            return Vector3.zero;
        }

        public void ClearCache()
        {
            entityPositionCache.Clear();
        }
    }
}
