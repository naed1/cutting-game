using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Sol : MonoBehaviour ,IPointerDownHandler, IPointerUpHandler
{
    public float speed = 3f;
    private bool isDown;
    private float downTime;
    bool goSol = false;

    void Update()
    {

        /*if (!this.isDown) return;
        if (Time.realtimeSinceStartup - this.downTime > 0.5f)
        {
            print("Handle Long Tap");
            this.isDown = false;
        }*/
        if (goSol)
        {
            UIController.Instance.Cutter.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
        this.downTime = Time.realtimeSinceStartup;
        goSol = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
        goSol = false;
    }

   
}