using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom
{
    public class Door : MonoBehaviour
    {
        public Animator Door1;
        public Animator Door2;
        public AudioSource source;
        public string AnimString;
        public string AnimString2;


        private void OnTriggerStay(Collider collider)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(collider.gameObject.name == "Player" && Key.keyCount > 0)
                {
                    Key.keyCount--;
                    Debug.Log(Key.keyCount);
                    Door1.Play(AnimString);
                    Door2.Play(AnimString2);
                    source.Play();

                }
            }
        }
    }
}