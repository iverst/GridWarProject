using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameObject
{
    GameObject gameObject;

    public TestGameObject (GameObject gameObject)
    {
        this.gameObject = gameObject;
    }

    public void addScript()
    {
        gameObject.AddComponent<ScriptForTest>();
    }
}
