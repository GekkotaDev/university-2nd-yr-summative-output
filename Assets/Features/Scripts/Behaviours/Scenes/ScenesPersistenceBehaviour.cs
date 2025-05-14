using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(int.MinValue)] // Quick hack to guarantee execution order.
public class ScenesPersistenceBehaviourScript : MonoBehaviour
{
    public string tagName; // Which game object to persist in-memory?

    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    // void Update()
    // {

    // }

    void Awake()
    {
        Debug.Log($"{tagName}.ScenesPersistenceBehaviour.Awake()");

        if (GameObject.FindGameObjectsWithTag(tagName).Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        Debug.Log($"{tagName}.ScenesPersistenceBehaviour: DontDestroyOnLoad(gameObject)");
        DontDestroyOnLoad(gameObject);
    }
}
