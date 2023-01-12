using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public AudioSource chase;
    public GameObject dialogue;
    public GameObject Timer;

    // Start is called before the first frame update
    void Start()
    {
        Timer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        chase.Play();
        dialogue.SetActive(true);
        Timer.SetActive(true);
        Destroy(gameObject);
    }
}
