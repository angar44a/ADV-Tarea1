using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fellow : MonoBehaviour
{
    [Range(0.02f,0.04f)]
    public float accel = 0.02f;
    public float downAccel = 1f;
    public Animator animator;
    public CharacterController charController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        charController.Move(Vector3.down * downAccel * Time.deltaTime);
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("FreezeAnim")) {
            if (animator.GetFloat("Horizontal") < 0) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + accel*2); }
            if (animator.GetFloat("Horizontal") > 0) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - accel*2); }
            if (animator.GetFloat("Vertical") < 0) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") + accel*2); }
            if (animator.GetFloat("Vertical") > 0) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") - accel*2); }
        }
        else {
            if (Input.GetKey(KeyCode.Space)) { animator.SetTrigger("Dance"); }
            if (Input.GetKey(KeyCode.I))
            {
                if (animator.GetFloat("Vertical") < 1) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") + accel); }
            }
            else if (Input.GetKey(KeyCode.M))
            {
                if (animator.GetFloat("Vertical") > -1) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") - accel); }
            }
            else {
                if (animator.GetFloat("Vertical") < 0) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") + accel); }
                if (animator.GetFloat("Vertical") > 0) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") - accel); }
            }
            if (Input.GetKey(KeyCode.J))
            {
                if (animator.GetFloat("Horizontal") < 1) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - accel); }
            }
            else if (Input.GetKey(KeyCode.K))
            {
                if (animator.GetFloat("Horizontal") < 1) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + accel); }
            }
            else
            {
                if (animator.GetFloat("Horizontal") < 0) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + accel); }
                if (animator.GetFloat("Horizontal") > 0) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - accel); }
            }
        }
    }
}
