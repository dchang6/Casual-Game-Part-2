using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class MenuToStartVV : MonoBehaviour
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Time.timeScale = 0;
        }

    }
}
