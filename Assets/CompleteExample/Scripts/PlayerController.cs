using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 0.05f;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) // if released A or D, back to idle state
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.D)) // if pressed D, go right
        {
            anim.SetBool("isWalking", true);
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, 1f);
        }

        if (Input.GetKey(KeyCode.A)) // if pressed A, go left 
        {
            anim.SetBool("isWalking", true);
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, 1f);
        }
    }
}
