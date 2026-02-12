# HandsOn C# - Developer Games

---

### Exercises

Objetivo:

Organização;
Manipulação de variáveis;
Otimização;

Phase 2: The "Security Lock" Challenge (Business Logic)

This is where you start thinking like a Software Architect. Let's simulate the Seat (1/1) error you had on the website.

The Task: Add a boolean variable `hasActiveLicense` (starts as false).

The Action: 1. Pressing the L key activates the license (true).

2. Pressing the C key (for Customize) should only print "Accessing Character Creator" if the license is true.

3. If it is false, it should print "Error: Seat Unavailable".

The Objective: To practice conditional statements (if/else) applied to a real business rule from your daily work.


### Flowchart


![alt text](image.png)


### Resolução

O objetivo é validar uma licença para que se tenha permissão de acesso, se não, não há acesso.



Resposta:

```csharp

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

```


