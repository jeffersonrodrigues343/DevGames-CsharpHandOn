using System;
using System.Collections.Generic;
using UnityEngine;

namespace Exec08.CharacterBase.CharacterBase
{   
   public class CharacterBase : MonoBehaviour
   {
      [Header("AvatarOptions")]
      [SerializeField]private string characterName;
      [SerializeField]private int characterLife;
      
      
      public void ReceiveDamage(int damage) => characterLife -= damage;
   }
}