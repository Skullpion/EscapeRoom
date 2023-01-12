using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace escapeRoom
{

    public class DialogueScript : MonoBehaviour
    {
        public TextMeshProUGUI textComp;
        public string[] lines;
        public float textSpeed;

        private int index;

        // Start is called before the first frame update
        void Start()
        {
            textComp.text = string.Empty;
            StartDi();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                if (textComp.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComp.text = lines[index];
                }
            }
        }

        void StartDi()
        {
            index = 0;
            StartCoroutine(Type());
        }

        IEnumerator Type()
        {
            foreach (char c in lines[index].ToCharArray())
            {
                textComp.text += c;
                yield return new WaitForSeconds(textSpeed);
            }
        }

        void NextLine()
        {
            if (index < lines.Length - 1)
            {
                index++;
                textComp.text = string.Empty;
                StartCoroutine(Type());
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}