using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCounter : MonoBehaviour
{

    Animator anim;
    bool control = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
        InvokeRepeating("EveryTenSecDoor", 1.0f, 10.0f);
    }
    


    private void EveryTenSecDoor()
    {
      
            anim.SetBool("open" , true);
            StartCoroutine("closeDoorAfterTime");
            foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
            {
                if (gameObj.name == "PartsPhysics(Clone)")
                {
                    if (!control)
                    {
                        gameObj.GetComponent<MeshCollider>().enabled = false;
                    }
                    
                }
            } 
    }

    IEnumerator closeDoorAfterTime()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("open", false);
        foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
        {
            if (gameObj.name == "PartsPhysics(Clone)")
            {        
                    control = false;
                    Destroy(gameObj);   
            }
        }
    }

    IEnumerator controlColliders()
    {
        yield return new WaitForSeconds(0.5f);
        control = true;
    }

}
