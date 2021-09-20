using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndWinScene : MonoBehaviour
{
    // Start is called before the first frame update
    Image img;
    float counter = 0;
    [SerializeField]
    int type = 0;
    void Start()
    {
        img = GetComponent<Image>();
        DontDestroyOnLoadManager.becomeMortal();
        /*MonoBehaviour[] allGameObj = GameObject.FindObjectsOfType<MonoBehaviour>();
        for (int i = 0; i < allGameObj.Length; i++)
            if (!(allGameObj[i].name.Equals("MC") || allGameObj[i].name.Equals("CanvasEnd")))
                Destroy(allGameObj[i]);*/
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > (type == 1 ? 3 : 1))
            img.color = new Color(type, type, type, 1 - ((counter - (type == 1 ? 3 : 1)) / 3.0f));
        if (counter > (type == 1 ? 10 : 5))
            SceneManager.LoadScene("BudgetTerminal");
    }
}
