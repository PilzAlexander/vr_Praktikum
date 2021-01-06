using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    Scene Scene;
    string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        Scene = SceneManager.GetActiveScene();
        sceneName = Scene.name;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (this.transform.eulerAngles.y >= 50 && sceneName.Equals("inspektion"))
        {
            Debug.Log("50 Grad überschritten");
            SceneManager.LoadScene(1);
                
        }
    }
}
