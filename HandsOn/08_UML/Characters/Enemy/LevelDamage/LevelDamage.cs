using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Exerc08.Characters.Enemy
{
    public enum TypesDifficulty
    {
        Easy,
        Normal,
        Hard,
        Dragon
    }
    
    public class LevelDamage: MonoBehaviour
    {
        [Header("Table of Difficulty")]
        [SerializeField] private float easyDamage = 10f;
        [SerializeField] private float normalDamage = 25f;
        [SerializeField] private float hardDamage = 50f;
        [SerializeField] private float dragonDamage = 100f;

        public float DamageCalculator(TypesDifficulty level)
        {
            if (level == TypesDifficulty.Easy) return easyDamage;
            if (level == TypesDifficulty.Normal) return normalDamage;
            if (level == TypesDifficulty.Hard) return hardDamage;
            if (level == TypesDifficulty.Dragon) return dragonDamage;
            
            return 0f;
        }
        
    }   
}