using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InvetorySystem.ItemBase.ItemConsumivel.ItemPocao
{
    public class ItemPocao : ItemConsumivel
    {
        public float Velocidade;


        public override void Uses()
        {
            Debug.Log("Beba a poção");
        }

    }
}