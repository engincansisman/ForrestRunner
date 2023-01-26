using System.Collections;
using Player;
using UnityEngine;

namespace Environment
{
    public class LevelStarter : MonoBehaviour
    {

        public GameObject countDown3;

        public GameObject countDown2;

        public GameObject countDown1;

        public GameObject countDownGo;

        public GameObject fadeIn;

        public AudioSource readyFX;

        public AudioSource goFX;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(CountSequence());
        }

        IEnumerator CountSequence()
        {
            yield return new WaitForSeconds(1.5f);
            countDown3.SetActive(true);
            readyFX.Play();
            yield return new WaitForSeconds(1.2f);
            countDown2.SetActive(true);
            readyFX.Play();
            yield return new WaitForSeconds(1f);
            countDown1.SetActive(true);
            readyFX.Play();
            yield return new WaitForSeconds(0.7f);
            countDownGo.SetActive(true);
            goFX.Play();
            yield return new WaitForSeconds(0.3f);

            PlayerMove.canMove = true;

        }
    }
}
