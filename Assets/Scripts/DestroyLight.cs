using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLight : MonoBehaviour
{
    public GameObject[] lights;
    public GameObject dialogue;
    public GameObject Blocker;
    public AudioSource lightSound;

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
        foreach(GameObject light in lights)
        {
            light.SetActive(false);
        }
        StartCoroutine(SelfDest());
        dialogue.SetActive(true);
        Blocker.SetActive(true);
        lightSound.Play();
    }
    IEnumerator SelfDest()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
