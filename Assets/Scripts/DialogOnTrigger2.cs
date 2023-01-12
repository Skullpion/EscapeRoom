using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOnTrigger2 : MonoBehaviour
{

    public GameObject dialogue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        dialogue.SetActive(true);
        StartCoroutine(dialogEnd());
    }
    IEnumerator dialogEnd()
    {
        yield return new WaitForSeconds(10);
        Destroy(dialogue);
    }
}
