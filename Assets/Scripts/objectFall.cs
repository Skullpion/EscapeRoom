using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom {

    public class objectFall : MonoBehaviour
    {
        public Animator toAnimateObject;
        public string Animation;
        public AudioSource soundEff;

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
                toAnimateObject.Play(Animation);
                soundEff.Play();
                Destroy(gameObject);
            }
        }
    }
}