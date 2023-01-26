using UnityEngine;

namespace Collectibles
{
    public class CollectCoin : MonoBehaviour
    {
        public AudioSource coinFX;
        private void OnTriggerEnter(Collider other)
        {
            coinFX.Play();
            CollectibleContrrol.coinCount += 1;
            gameObject.SetActive(false);
        }
    }
}
