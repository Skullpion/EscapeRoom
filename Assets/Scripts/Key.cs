using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom
{
    public class Key : MonoBehaviour
    {
        public static int keyCount;
        public GameObject text;
        public AudioSource PickupSound;

        private void OnTriggerStay(Collider collider)
        {
            text.SetActive(true);
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (collider.gameObject.name == "Player")
                    {
                        PickupSound.Play();
                        keyCount += 1;
                        Debug.Log(keyCount);
                        Destroy(gameObject);
                        
                    }
                }
            }
        }
    }
}