using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvetorySystem.ItemBase.ItemConsumivel

{
    
    public class ItemConsumivel: ItemBase
    {
        public int valueHP = 10;
        public bool CanUses( float hpAtual, float hpMax )
        {
            if (hpAtual < hpMax)
            {
                return true;
            }
            
            return false;
            
        }

        public override void Uses()
        {
            Debug.Log("Healed " + valueHP + "of player life." );
        }
    }
}