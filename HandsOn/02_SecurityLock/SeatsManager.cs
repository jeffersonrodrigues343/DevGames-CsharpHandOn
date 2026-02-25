using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace  ValidaçãoDeLiceças { 
    public class SeatsManager : MonoBehaviour
    {
        // Initial
        [SerializeField()]
        private bool LicenceActive; // LogicVar

        public KeyCode keyTrue = KeyCode.L; // ControlVar
        public KeyCode keyAcess = KeyCode.C; // ControlVar
        
        void Update()
        {
          ValidateLicence();
        }

        
        // Methods 
        public void ValidateLicence()
        {
            if (Input.GetKeyDown(keyTrue))
            {
                LicenceActive = true;

                Debug.Log("Licença Liberada");
            }
            if (Input.GetKeyDown(keyAcess))
            {
                ValidateWithLicence();
            }


        }

        public void ValidateWithLicence()
        {
            if (LicenceActive)
            {
                Debug.Log("Welcome");
            }
            else
            {
                Debug.Log("You need licence to greated");
            }


        }
            
        
    }
}