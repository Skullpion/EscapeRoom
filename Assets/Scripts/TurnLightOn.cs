using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom
{
    public class TurnLightOn : MonoBehaviour
    {
        public GameObject[] lights;
        public GameObject dialogue;
        public GameObject Blocker;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
                if (Blocker.activeInHierarchy == true)
                {
                    foreach (GameObject light in lights)
                    {
                        light.SetActive(true);
                    }
                    dialogue.SetActive(true);
                    StartCoroutine(DestroyBlock());
            }
        }
        IEnumerator DestroyBlock()
        {
            yield return new WaitForSeconds(3);
            Blocker.SetActive(false);
        }
    }
}