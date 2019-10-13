using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodObject : MonoBehaviour
{
    // Start is called before the first frame update
    bool check = false;
    void Start()
    {
        if (!check)
        {
            check = true;
            gameObject.AddComponent<MeshCollider>();
            GetComponent<MeshCollider>().convex = true;
            /*gameObject.AddComponent<CapsuleCollider>();
            GetComponent<CapsuleCollider>().radius = 0;
            GetComponent<CapsuleCollider>().height = 0;*/
        }
        
    }

}
