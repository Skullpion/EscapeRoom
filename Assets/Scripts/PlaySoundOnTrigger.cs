using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom
{

    public class PlaySoundOnTrigger : MonoBehaviour
    {
        public AudioSource soundEffect;

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
                if (Key.keyCount > 0)
                {

                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Runned");
                    soundEffect.Play();
                    Destroy(gameObject);
                }
                }
            }
        }
}