using Collectibles;
using Player;
using UnityEngine;

namespace Environment
{
    public class ObstacleCollision : MonoBehaviour
    {
        public GameObject thePlayer;
        public GameObject charModel;
        public AudioSource crash;
        public GameObject mainCam;
        public GameObject levelControl;
        private void OnTriggerEnter(Collider other)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            charModel.GetComponent<Animator>().Play("Stumble Backwards");
            levelControl.GetComponent<LevelDistance>().enabled = false;
            crash.Play();
            mainCam.GetComponent<Animator>().enabled = true;
            levelControl.GetComponent<EndRunSequence>().enabled = true;
        }
    }
}
