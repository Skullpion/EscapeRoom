using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI txtdisp;
    public int secondLeft = 60;
    public bool takingAway = false;
    public Animator PlayerAnim;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        txtdisp.text = "Escape: " + "00:" + secondLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondLeft > 0)
        {
            StartCoroutine(Take());
        }
        if(secondLeft == 0)
        {
            PlayerAnim.enabled = true;
            Player = GameObject.FindGameObjectWithTag("Player");
            Player.GetComponent<Rigidbody>().isKinematic = true;
            PlayerAnim.Play("DeathAnim");
            StartCoroutine(Restart());
        }

    }
    IEnumerator Take()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondLeft -= 1;
        if(secondLeft < 10)
        {
            txtdisp.text = "Escape: " +"00:0" + secondLeft;
        }
        else
        {
            txtdisp.text = "Escape: " +"00:" + secondLeft;

        }
        takingAway = false;
    }
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3.5F);
        SceneManager.LoadScene(1);
    }
}
