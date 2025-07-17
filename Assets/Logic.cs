using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Logic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame()
    {
        Score.scoreValue = 0;
        SceneManager.LoadScene("snakegame");

    }
    public void backtomainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
