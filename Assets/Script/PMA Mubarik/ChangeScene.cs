using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
 public void ChangeScene1(string sceneName)
    {
        LevelManagerPMAMubarik.instance.loadScene(sceneName);
    }
}
