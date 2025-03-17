using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
    public float pipedelete = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(transform.position.x < pipedelete)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
        transform.position = transform.position + Vector3.left * movespeed * Time.deltaTime;
    }
}
