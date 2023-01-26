using UnityEngine;

namespace Collectibles
{
    public class RotateObject : MonoBehaviour
    {
        public int rotateSpeed = 1;

        // Update is called once per frame
        void Update()
        {
        transform.Rotate(0,rotateSpeed,0,Space.World);
        }
    }
}
