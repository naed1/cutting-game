using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    

    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;

    void Start()
    {
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        InvokeRepeating("Spawned", 2.0f, 2.0f);

    }

    void Spawned()
    {
            int prefabIndex = Random.Range(0, 3);
            Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);

            float rRange = Random.Range(-3f, 0f);
            //Debug.Log(rRange);

            Vector3 temp = new Vector3(rRange, 24.31f, -2.34f);
            if(transform.position.x < -1)
            {
                transform.position = new Vector3(0, 24.31f, -2.34f);
            }
            transform.position = temp;

    }
}
