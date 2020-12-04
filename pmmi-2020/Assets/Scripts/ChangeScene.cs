using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string scene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.transform.eulerAngles.y >= 50)
        {
            Debug.Log("50 Grad überschritten");
            SceneManager.LoadScene(1);
        }
    }
}
