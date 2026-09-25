using UnityEngine;

namespace AimDragCache
{
    public class AimDragSmoothing : MonoBehaviour
    {
        [SerializeField] private float smoothSpeed = 12.0f;

        public Vector3 CalculateSmoothedPosition(Vector3 currentPosition, Vector3 targetPosition, float deltaTime)
        {
            return Vector3.Lerp(currentPosition, targetPosition, deltaTime * smoothSpeed);
        }
    }
}
