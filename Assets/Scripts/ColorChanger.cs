using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    planeChanger _planeChanger;
    public Renderer rend;


    private void Start()
    {
        
        rend = GetComponent<Renderer>();

    }

    public void Red()
    {
        if (isActiveAndEnabled)
        {
            rend.material.color = Color.red;
        }
      
    }

    public void Blue()
    {
        if (isActiveAndEnabled)
        {
            rend.material.color = Color.blue;
        }
          
    }

    public void Yellow()
    {
        if (isActiveAndEnabled)
        {
            rend.material.color = Color.yellow;
        }

    }

    public void Green()
    {
        if (isActiveAndEnabled)
        {
            rend.material.color = Color.green;
        }

    }
}

