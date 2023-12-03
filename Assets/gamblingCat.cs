using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamblingCat : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          transform.Translate(0, 0, 0.9f);

          if(Input.GetKeyDown(KeyCode.UpArrow)){
            anim.SetBool("myJump", true);
          }
          if(Input.GetKeyUp(KeyCode.UpArrow)){
            anim.SetBool("myJump", false);
          }
          if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-0.5f, 0, 0);
          }
          if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0.5f, 0, 0);
          }
    }
}
