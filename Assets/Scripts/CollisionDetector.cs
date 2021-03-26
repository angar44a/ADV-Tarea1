using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    private void OnTriggerEnter(Collider collision)
    {
        anim = collision.gameObject.GetComponent<Animator>();
        anim.SetBool("abierto", !(anim.GetBool("abierto")  )  );
    }
}
