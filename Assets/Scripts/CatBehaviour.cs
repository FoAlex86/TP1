using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    AudioSource collisionSound;
    public GameObject fx;
    public GameObject worldObject;

    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter
        if (other.tag == "Player")
        {
            worldObject.SendMessage("AddHit");
            worldObject.SendMessage("reduceEnemies");
            Instantiate(fx, transform.position, Quaternion.identity);
            if (collisionSound)
            {
                collisionSound.Play();
            }
            Destroy(gameObject);
        }
    }
}
