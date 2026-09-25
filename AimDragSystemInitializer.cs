using UnityEngine;

namespace AimDragCache
{
    public class AimDragTestHarness : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("[+] Initializing AimDragCache Test Harness...");
            
            GameObject systemObj = new GameObject("AimDragSystem");
            systemObj.AddComponent<AimDragSystemInitializer>();
            
            Debug.Log("[+] AimDragCache system integrated and running successfully.");
        }
    }
}
