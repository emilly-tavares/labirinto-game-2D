using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentacaoPlayer : MonoBehaviour
{
    [SerializeField]
    private float speed = 30f;
    private  Animator animator;
    



    private void Update()
    {

        animator = GetComponent<Animator>();

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.position = transform.position + new Vector3(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);

        








        






    }



}
