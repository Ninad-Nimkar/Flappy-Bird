using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 3;
    private float timer = 0;
    public float hightoffset = 10;

    // Start is called before the first frame update
    void Start()
    {
          spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()

    {
        float hightestpoint = transform.position.y - hightoffset;
        float lowestpoint = transform.position.y + hightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, hightestpoint), 0), transform.rotation);
    }

}
