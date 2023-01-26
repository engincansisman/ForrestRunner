using System.Collections;
using UnityEngine;

namespace Environment
{
    public class LevelGenerator : MonoBehaviour
    {
        public GameObject[] sections;
        public int zPos = 40;
        public bool creatingSection = false;
        public int secNumb;

        // Update is called once per frame
        void Update()
        {
            if (creatingSection==false)
            {
                creatingSection = true;
                StartCoroutine(GenerateSection());
            }
        }

        IEnumerator GenerateSection()
        {
            secNumb = Random.Range(0, sections.Length);
            Instantiate(sections[secNumb], new Vector3(0, 0, zPos), Quaternion.identity);
            zPos += 40;
            yield return new WaitForSeconds(2);
            creatingSection = false;
        }

       
    }
}
