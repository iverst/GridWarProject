using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTest : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start !");
        TestGameObject testGameObject = new TestGameObject(go);
        testGameObject.addScript();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
