using UnityEngine;

namespace AimDragCache
{
    public class AimDragConfigValidator : MonoBehaviour
    {
        public static bool ValidateColliderData(CapsuleCollider collider)
        {
            if (collider == null)
            {
                Debug.LogError("[!] Validation Error: CapsuleCollider component is missing.");
                return false;
            }
            if (collider.radius <= 0 || collider.height <= 0)
            {
                Debug.LogWarning("[!] Validation Warning: Collider dimensions must be greater than zero.");
                return false;
            }
            return true;
        }
    }
}
