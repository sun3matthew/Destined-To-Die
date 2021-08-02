using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatDeathExit : MonoBehaviour
{
    // Start is called before the first frame update
    private float counter;
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter > 5)
            SceneManager.LoadScene("BudgetTerminal");
    }
}
