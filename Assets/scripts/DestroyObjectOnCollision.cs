using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObjectOnCollision : MonoBehaviour
{
     void CheckForEnemiesLeft()
    {
        if (GameObject.FindWithTag("Destroy") == null)
        {
            SceneManager.LoadScene("Scene2");
        }
    }
    public static int money = 0;
    [SerializeField]
    string strTag;
    [SerializeField]
    bool bDestroySelf = false;
    [SerializeField]
    bool bDestroyOther = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            if (bDestroySelf) {
                Destroy(this.gameObject);
                money++;
                    }
            if (bDestroyOther)
            {
                Destroy(collision.gameObject);
                money++;
            }
               
        }
    }
}
