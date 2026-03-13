using System;
using System.Collections.Generic;
using System.Collections;
using Exec08.CharacterBase;
using Exec08.CharacterBase.CharacterBase;
using UnityEngine;

namespace Exerc08.Hero.IamHero
{
    public class IamHero : CharacterBase
    {
       [SerializeField] private int aura = 10;
       [SerializeField] private SwordHero.SwordHero.SwordHero SwordHero;
        
        
        public void castSpells( int squall )
        {
            if (aura >= 15)
            {
                squall += 30;
                aura -= 15;
                Debug.Log("Magia de Fogo:" + squall + "de Dano");
            }
            else if (squall == 15)
            {
                Debug.Log("Você não tem aura, cara:" + squall);
            }
        }

        private void SwordAttack(){}
    }
}