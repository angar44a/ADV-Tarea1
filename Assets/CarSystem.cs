using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSystem : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject splat;
    public GameObject _player;
    public GameObject death_screen;
    private GameObject cartype;
    private int RNG;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CarSpawning", 3.0f, 2.0f);
        cartype = car1;
    }

    // Update is called once per frame
    void Update()
    {
        if (_player == null) { death_screen.SetActive(true); }
    }

    void CarSpawning()
    {
        GameObject instance;
        RNG = Random.Range(0, 4);
        if(RNG == 0)
        {
            RNG = Random.Range(0, 3);
            if (RNG == 0) cartype = car1;
            if (RNG == 1) cartype = car2;
            if (RNG == 2) cartype = car3;
            instance = Instantiate(cartype, new Vector3(70.0f, 10.6f, -15.5f), Quaternion.Euler(Vector3.up * 270));
            instance.transform.position = new Vector3(70.0f, 10.6f, -15.5f);
            RNG = Random.Range(0, 3);
            if (RNG == 0) {
                RNG = Random.Range(0, 3);
                if (RNG == 0) cartype = car1;
                if (RNG == 1) cartype = car2;
                if (RNG == 2) cartype = car3;
                instance = Instantiate(cartype, new Vector3(76.0f, 10.6f, -20.0f), Quaternion.Euler(Vector3.up * 270));
                instance.transform.position = new Vector3(76.0f, 10.6f, -20.0f);
            }
        }
        else if (RNG == 1)
        {
            RNG = Random.Range(0, 3);
            if (RNG == 0) cartype = car1;
            if (RNG == 1) cartype = car2;
            if (RNG == 2) cartype = car3;
            instance = Instantiate(cartype, new Vector3(-55.0f, 10.6f, -25.6f), Quaternion.Euler(Vector3.up * 90));
            instance.transform.position = new Vector3(-55.0f, 10.6f, -25.6f);
            RNG = Random.Range(0, 3);
            if (RNG == 0)
            {
                RNG = Random.Range(0, 3);
                if (RNG == 0) cartype = car1;
                if (RNG == 1) cartype = car2;
                if (RNG == 2) cartype = car3;
                instance = Instantiate(cartype, new Vector3(-50.0f, 10.6f, -30.5f), Quaternion.Euler(Vector3.up * 90));
                instance.transform.position = new Vector3(-50.0f, 10.6f, -30.5f);
            }
        }
        else if (RNG == 2)
        {
            RNG = Random.Range(0, 3);
            if (RNG == 0) cartype = car1;
            if (RNG == 1) cartype = car2;
            if (RNG == 2) cartype = car3;
            RNG = Random.Range(0, 3);
            instance = Instantiate(cartype, new Vector3(3.0f, 10.6f, 5.0f), Quaternion.Euler(Vector3.up * 180));
            instance.transform.position = new Vector3(3.0f, 10.6f, 5.0f);
            RNG = Random.Range(0, 3);
            if (RNG == 0)
            {
                RNG = Random.Range(0, 3);
                if (RNG == 0) cartype = car1;
                if (RNG == 1) cartype = car2;
                if (RNG == 2) cartype = car3;
                instance = Instantiate(cartype, new Vector3(7.3f, 10.6f, 10.0f), Quaternion.Euler(Vector3.up * 180));
                instance.transform.position = new Vector3(7.3f, 10.6f, 10.0f);
            }
        }
        else if (RNG == 3)
        {
            RNG = Random.Range(0, 3);
            if (RNG == 0) cartype = car1;
            if (RNG == 1) cartype = car2;
            if (RNG == 2) cartype = car3;
            instance = Instantiate(cartype, new Vector3(17.4f, 10.6f, -45.5f), Quaternion.Euler(Vector3.up));
            instance.transform.position = new Vector3(17.4f, 10.6f, -45.5f);
            RNG = Random.Range(0, 3);
            if (RNG == 0)
            {
                RNG = Random.Range(0, 3);
                if (RNG == 0) cartype = car1;
                if (RNG == 1) cartype = car2;
                if (RNG == 2) cartype = car3;
                instance = Instantiate(cartype, new Vector3(13.0f, 10.6f, -45.5f), Quaternion.Euler(Vector3.up));
                instance.transform.position = new Vector3(13.0f, 10.6f, -50.5f);
            }
        }
    }

}
