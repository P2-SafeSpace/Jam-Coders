using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Clicknext1 : MonoBehaviour
{
public int one = 1 ;
    // Update is calledonce per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("GetActiveScene"+1);
        }
    }
}
