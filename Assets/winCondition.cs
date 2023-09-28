using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winCondition : MonoBehaviour
{
    public int nbEnemies = 5;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nbEnemies == 0)
        {
            SceneManager.LoadScene("Terrain"); // le nom de votre scene
        }
    }

    public void reduceEnemies()
    {
        nbEnemies--;
    }
}
