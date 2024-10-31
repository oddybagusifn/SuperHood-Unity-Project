using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;
    public Animator transition;

    public bool useIntegerToLoadLevel =false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "Player")
        {
            LoadScene();

            if(iLevelToLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", iLevelToLoad);
            }
        }

        void LoadScene()
        {
            
            if(useIntegerToLoadLevel)
            {
                SceneManager.LoadScene(iLevelToLoad);
            }
            else
            {
                SceneManager.LoadScene(sLevelToLoad);
            }
            
        }
    }
}
