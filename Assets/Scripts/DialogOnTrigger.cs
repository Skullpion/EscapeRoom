using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom
{

    public class DialogOnTrigger : MonoBehaviour
    {
        public GameObject dialogue;

        // Start is called before the first frame update
        void Start()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (Key.keyCount > 0)
            {
                dialogue.SetActive(true);
            }
        }
    }
}