using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Start : MonoBehaviour
{
    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(MenuSahnesineGec());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MenuSahnesineGec()
    {
        


        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Scene_Menu");
    }
}
