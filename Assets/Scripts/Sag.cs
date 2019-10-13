using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Sag : MonoBehaviour ,IPointerDownHandler, IPointerUpHandler
{
    public float speed = 3f;
    //private bool isDown;
    //private float downTime;


    void Update()
    {
        /*if (!this.isDown) return;
        if (Time.realtimeSinceStartup - this.downTime > 0.5f)
        {
            print("Handle Long Tap");
            Debug.Log("ok");
            
            this.isDown = false;
        }*/
        if (UIController.Instance.Movement)
        {
            if (UIController.Instance.goSag)
            {
                UIController.Instance.Cutter.transform.Translate(-Vector3.left * Time.deltaTime * speed);
            }
        }
        

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //this.isDown = true;
        //this.downTime = Time.realtimeSinceStartup;
        UIController.Instance.goSag = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //this.isDown = false;
        UIController.Instance.goSag = false;
    }

   
}