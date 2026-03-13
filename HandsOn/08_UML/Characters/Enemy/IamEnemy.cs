using System;
using System.Collections.Generic;
using System.Collections;
using Exec08.CharacterBase.CharacterBase;
using UnityEngine;

namespace Exerc08.Characters.Enemy
{
    public class IamEnemy : CharacterBase
    {
        [Header("Enemy Options")]
        
        [SerializeField] private LevelDamage levelManager;

        [SerializeField] private TypesDifficulty enemyLevel; 

        private void Start()
        {
            Debug.Log("O Inimigo nasceu! Seu Nível é: " + enemyLevel);
        }

        private void RoarEnemy()
        {
            // Lógica do rugido aqui
        }
    }
}