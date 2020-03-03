using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;



public class DeChPlayerController : MonoBehaviour

{

    private Rigidbody2D rb2d;

    public static int timeLeft;

    public float Score;

    public Text timeText;

    private int wholeTime;

    public float speed;

    



    void Start()

    {

        StartCoroutine(ByeAfterDelay(2));

        rb2d = GetComponent<Rigidbody2D>();

        Score =0.0f;

    }





    void OnTriggerEnter2D(Collider2D other)

    {

        if (other.gameObject.tag == "Enemy")

        { 


            SceneManager.LoadScene("Game Over", LoadSceneMode.Single);

        }

        

        if (other.gameObject.tag == "DEATH")

        {

            SceneManager.LoadScene("Game Over", LoadSceneMode.Single);

        }

    }



    void FixedUpdate()

    {
 transform.Translate(speed * Time.deltaTime, 0, 0);
    }





        void Update()

    {

        Score += Time.deltaTime; 

        wholeTime = (int) Score;

        timeText.text = "Score: "+ wholeTime;

    }



    IEnumerator ByeAfterDelay(float time)

    {

        yield return new WaitForSeconds(time);

    }

}
