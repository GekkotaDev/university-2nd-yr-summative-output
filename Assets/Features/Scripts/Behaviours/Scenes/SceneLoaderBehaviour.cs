using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderBehaviourScript : MonoBehaviour
{
    // public string scene;

    // Start is called before the first frame update
    // void Start() { }

    // Update is called once per frame
    // void Update() { }

    public void StartGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
