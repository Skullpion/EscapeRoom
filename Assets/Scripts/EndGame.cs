using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    public GameObject counter;
    public Animator ImageAnimator;
    public GameObject dialogue;
    public GameObject coming;

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
        coming.SetActive(false);
        counter.SetActive(false);
        dialogue.SetActive(true);
        StartCoroutine(endGame());
    }
    IEnumerator endGame()
    {
        yield return new WaitForSeconds(7);
        ImageAnimator.Play("Fadeout");
        StartCoroutine(SwitchScene());
    }
    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
