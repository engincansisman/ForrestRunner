using System.Collections;
using UnityEngine;

namespace Environment
{
    public class EndRunSequence : MonoBehaviour
    {
        public GameObject liveCoins;

        public GameObject liveDis;

        public GameObject endScreen;

        public GameObject fadeOut;
        
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(EndSequence());
        }

        private IEnumerator EndSequence()
        {
            yield return new WaitForSeconds(2);
            liveCoins.SetActive(false);
            liveDis.SetActive(false);
            endScreen.SetActive(true);
            yield return new WaitForSeconds(3.5f);
            fadeOut.SetActive(true);
        }

    }
}
