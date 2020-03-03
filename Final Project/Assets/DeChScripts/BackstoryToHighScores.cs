using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class BackstoryToHighScores : MonoBehaviour
{
    public float PTimer;
    // Start is called before the first frame update
    void Start()
    {
        PTimer = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PTimer -= Time.deltaTime;

        if (PTimer <= -15)
        {
            SceneManager.LoadScene("High Scores", LoadSceneMode.Single);
            Time.timeScale = 1;
        }

    }
}