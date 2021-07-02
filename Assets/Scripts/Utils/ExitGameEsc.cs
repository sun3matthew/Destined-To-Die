using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitGameEsc : MonoBehaviour
{
    private float exitGame;
    private Image exitFade;
    void Start()
    {
        exitFade = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            exitGame += Time.deltaTime * 0.9f;
        }
        else
        {
            if (exitGame > 0)
                exitGame -= Time.deltaTime * 1.3f;
            if (exitGame < 0)
                exitGame = 0;
        }
        if (exitGame > 1.2f)
        {
            DontDestroyOnLoadManager.becomeMortal();
            SceneManager.LoadScene("BudgetTerminal");
        }
        exitFade.color = new Color(0.75f, 0, 0, exitGame);
    }
}
