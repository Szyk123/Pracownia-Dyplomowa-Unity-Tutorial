using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strSceneName;
    public void CheckForEnemiesLeft()
    {
        if (GameObject.FindWithTag("Destroy") == null)
        {
            //Do any finishing up
            SceneManager.LoadScene(strSceneName);
        }
    }
    [SerializeField]
    string strTag;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == strTag && GameObject.FindWithTag("Destroy") == null)
        {
            DestroyObjectOnCollision.money = 0;
            SceneManager.LoadScene(strSceneName);
        }
    }
}
