using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class planeChanger : MonoBehaviour
{
    [SerializeField] private Button leftButton;
    [SerializeField] private Button righttButton;
   private int currentPlane;
    

    private void Awake() 
    {
    SelectPlane(0);
    }
   private void SelectPlane(int _index )
   {
        
    leftButton.interactable = (_index != 0);
    righttButton.interactable = (_index != transform.childCount - 1);
    for(int i = 0; i < transform.childCount; i++)
    {
        transform.GetChild(i).gameObject.SetActive(i == _index);
    }
   }

   public void ChangePlane(int _change)
   {
    currentPlane += _change;
    SelectPlane(currentPlane);
   }
}
