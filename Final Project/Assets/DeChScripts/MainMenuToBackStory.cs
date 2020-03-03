using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class MainMenuToBackStory : MonoBehaviour
{
    public float LTimer;
    // Start is called before the first frame update
    void Start()
    {
        LTimer = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LTimer -= Time.deltaTime;

        if (LTimer <= -20)
        {
            SceneManager.LoadScene("Backstory", LoadSceneMode.Single);
            Time.timeScale = 1;
        }

    }
}
