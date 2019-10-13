using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("stop");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddTorque(-speed, 0, -speed);
        
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(1);
        speed = 0;
    }
}
