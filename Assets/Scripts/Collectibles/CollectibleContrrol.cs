using TMPro;
using UnityEngine;

namespace Collectibles
{
    public class CollectibleContrrol : MonoBehaviour
    {
        // Start is called before the first frame update
        public static int coinCount;
        public GameObject coinCountDisplay;
        private TextMeshProUGUI _text;
        public GameObject coinEndDisplay;
        private TextMeshProUGUI coinEndText;
        

        // Update is called once per frame
        private void Start()
        {
            _text = coinCountDisplay.GetComponent<TextMeshProUGUI>();
            coinEndText = coinEndDisplay.GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            _text.text = "" + coinCount;
            coinEndText.text = "" + coinCount;
        }
    }
}
