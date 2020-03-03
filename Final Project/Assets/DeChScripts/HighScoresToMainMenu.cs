using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class HighScoresToMainMenu : MonoBehaviour
{
    public float HTimer;
    // Start is called before the first frame update
    void Start()
    {
        HTimer = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HTimer -= Time.deltaTime;

        if (HTimer <= -15)
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
            Time.timeScale = 1;
        }

    }
}