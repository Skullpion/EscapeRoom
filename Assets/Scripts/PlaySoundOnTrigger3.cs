using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom
{

    public class PlaySoundOnTrigger3 : MonoBehaviour
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

                soundEffect.Play();
                Destroy(gameObject);
            
        }
    }
}