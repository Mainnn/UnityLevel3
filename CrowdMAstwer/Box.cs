using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
    public event UnityAction Tach;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Objeckt")
        {
            Tach?.Invoke();
        }
    }

}
