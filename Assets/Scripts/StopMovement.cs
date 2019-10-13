using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovement : MonoBehaviour
{

    private void Start()
    {
        Physics.IgnoreLayerCollision(0, 8,true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            UIController.Instance.goSol = false;
            UIController.Instance.goSag = false;
        }
    }
}
