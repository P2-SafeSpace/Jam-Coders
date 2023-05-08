using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Threading;

public class ButtonForNextPage : MonoBehaviour
{
    [SerializeField] int WaitTime = 200;

        public void TaskOnClick()
            {
                int nextSceneIndex =SceneManager.GetActiveScene().buildIndex +1;
                SceneManager.LoadScene(nextSceneIndex);
                Thread.Sleep(WaitTime);
        }
}