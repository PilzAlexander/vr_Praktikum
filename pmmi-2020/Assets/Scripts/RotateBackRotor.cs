using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateBackRotor : MonoBehaviour
{

    public float speed = 50.0f;
    Scene Scene;
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        Scene = SceneManager.GetActiveScene();
        sceneName = Scene.name;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);

        if (sceneName.Equals("cockpit"))
        {
            speed = 1500.0f;
        }



    }
}
