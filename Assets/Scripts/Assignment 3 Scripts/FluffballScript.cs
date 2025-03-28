using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FluffballScript : MonoBehaviour
{
   
    public void PickUp()
    {
        Debug.Log("Success!");
        Vector2 size = transform.localScale;
        size.x = +100;
        size.y += 100;
        transform.localScale = size;
        
    }

}
