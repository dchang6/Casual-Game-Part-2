using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeChEnemyController : MonoBehaviour {

    public float speed;

    void Start()
    {
    }
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        { 
            Destroy(gameObject, 0.01f);
        }
    }

    void FixedUpdate ()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
