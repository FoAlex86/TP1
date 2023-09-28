using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    TMP_Text timerText;
    int nbCats = 0;
    int currentTime = GameVariables.currentTime;

    void Start()
    {
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());

        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddHit()
    {
        nbCats++;
        headText.text = "BobHeads: " + nbCats;
    }

    IEnumerator TimerTick()
    {
        while (currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            currentTime--;
            timerText.text = "Time :" + currentTime.ToString();
        }
        // game over
        SceneManager.LoadScene("sceneCatBots"); // le nom de votre scene
    }
}