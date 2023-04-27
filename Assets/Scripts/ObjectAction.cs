using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    public GameObject tool;
    
    void OnMouseDown()
    {
        if(tool.activeInHierarchy)
        {
            Destroy(gameObject);
        }
    }
}
