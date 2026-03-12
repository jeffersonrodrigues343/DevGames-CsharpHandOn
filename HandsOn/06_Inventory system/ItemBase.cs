using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvetorySystem.ItemBase
{
    public class ItemBase : MonoBehaviour
    {
        public string itemName;
        public float peso;
        public bool canHold;

        public virtual void Uses()
        {
            Debug.Log("You taked a some generic item.");
        }
        
       
    }   
}