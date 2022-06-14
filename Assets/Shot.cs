using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    private float shotInterval = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shotInterval += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && shotInterval >= 0.1f)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            shotInterval = 0;
        }
    }
}
