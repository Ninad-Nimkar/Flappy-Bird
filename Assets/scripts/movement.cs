using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float jumpforce;
    public logicscript logic;
    public bool birdisalive = true;

    // Start is called before the first frame update
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdisalive)
        {
            myrigidbody.linearVelocity = Vector2.up * jumpforce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.Gameover();
        birdisalive = false;
    }

}
