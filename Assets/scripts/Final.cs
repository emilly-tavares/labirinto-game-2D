using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    /*
    void Update()
    {
        if(this.isTrigger == true)
        {

        }
    }
    */


    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log("Ganhou");
            SceneManager.LoadScene("Ganhou");
        }
    } 
}
