using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cabnetPortal : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {

    }
    public string sceneToLoad;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GCabnet"))
        {
            LoadNewScene();
        }
    }
    private void LoadNewScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    void Update()
    {

    }

}
