using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarObjeto : MonoBehaviour
{
    public GameObject axe, pickaxe, shovel;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            axe.SetActive(false);
            pickaxe.SetActive(false);
            shovel.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            axe.SetActive(true);
            pickaxe.SetActive(false);
            shovel.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            axe.SetActive(false);
            pickaxe.SetActive(true);
            shovel.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            axe.SetActive(false);
            pickaxe.SetActive(false);
            shovel.SetActive(true);
        }
    }
}
