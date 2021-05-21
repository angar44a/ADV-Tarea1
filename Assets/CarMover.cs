using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    public float speed = 1f;
    //private Animator _anim;
    //public Rigidbody2D _rb2d;
    public GameObject _player;
    public GameObject splat;
    private Vector3 direction;
    public float hitrange;
    void Start()
    {
        //direction = Vector3.zero;
        //_anim = GetComponent<Animator>();
        //_rb2d = GetComponent<Rigidbody2D>();

        Invoke("DestroyThis", 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //_anim.SetFloat("speed", Mathf.Abs(direction.magnitude));
        //transform.position = transform.forward * Time.deltaTime * speed;
        transform.Translate(Vector3.forward * 1 * Time.deltaTime * speed);
    }

    void DestroyThis() { Destroy(this.gameObject); }

    private void OnTriggerEnter(Collider other)
    {
        GameObject instance;
        instance = Instantiate(splat, new Vector3(this.transform.position.x, this.transform.position.y + 1.0f, this.transform.position.z), Quaternion.Euler(Vector3.left * 90));
        instance.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.0f, this.transform.position.z);
        Destroy(other.gameObject);
        
    }
}
