using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    public GameObject PlayerCam;
    public GameObject BedCam;
    public Animator ImageAnimator;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCam.SetActive(false);
        StartCoroutine(AnimEnd());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator AnimEnd()
    {
        yield return new WaitForSeconds(4);
        ImageAnimator.Play("Fadeout");
        yield return new WaitForSeconds(3);
        BedCam.SetActive(false);
        PlayerCam.SetActive(true);
        ImageAnimator.Play("Fadein");
    }
}
