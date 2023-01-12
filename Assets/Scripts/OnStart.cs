using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace escapeRoom
{
    public class OnStart : MonoBehaviour
    {
        public GameObject dialog;
        // Start is called before the first frame update
        void Start()
        {
            dialog.SetActive(false);
            StartCoroutine(StartDialoug());
        }

        // Update is called once per frame

        IEnumerator StartDialoug()
        {
            yield return new WaitForSeconds(7);
            dialog.SetActive(true);

            }
        }

    }