using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSingletons : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] singletons;

    [SerializeField]
    GameObject classmatePrefab;

    //[SerializeField]
    //GameObject[] classmates;
    void Awake()
    {
        if(GameObject.FindWithTag("Cutscene") == null)
        {
            newClassmate(typeof(Human1));
            newClassmate(typeof(Human2));
            newClassmate(typeof(Human3));
            newClassmate(typeof(Human4));
            newClassmate(typeof(Human5));
            newClassmate(typeof(Human6));
            newClassmate(typeof(Human7));
            newClassmate(typeof(Human8));
            newClassmate(typeof(Human9));
            newClassmate(typeof(Human10));
            newClassmate(typeof(Human11));
            newClassmate(typeof(Human12));
            newClassmate(typeof(Human13));
            newClassmate(typeof(Human14));
            newClassmate(typeof(Human15));

            for (int i = 0; i < singletons.Length; i++)
                DontDestroyOnLoadManager.DontDestroyOnLoad(Instantiate(singletons[i], new Vector2(0, 0), Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Destroy(gameObject);
    }
    void newClassmate(System.Type component) => DontDestroyOnLoadManager.DontDestroyOnLoad(Instantiate(classmatePrefab, new Vector2(0, 0), Quaternion.identity).AddComponent(component).gameObject);
}
