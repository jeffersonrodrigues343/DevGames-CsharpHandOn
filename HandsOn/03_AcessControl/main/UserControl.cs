using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserControl.Security 
{    
        public class UserControl : MonoBehaviour
        {
            
            [SerializeField]private int acessControl = 0;
            
            
            [Header("UserControl")]
            [SerializeField]private KeyCode keyUpgrade = KeyCode.U;
            [SerializeField]private KeyCode keyAcess = KeyCode.E;
            
            
            
            
            // Update is called once per frame
            void Update()
            {
                if (Input.GetKeyDown(keyUpgrade))
                {
                    UserUpgrade();
                }

                if (Input.GetKeyDown(keyAcess))
                {
                    CheckAcess();
                }
            }

            public void UserUpgrade()
            {
                acessControl = (acessControl + 1) % 4; 
                /*
                if (acessControl > 3 )
                {   
                    acessControl = 0;
                }
                */
            }

            public void CheckAcess()
            {
                switch (acessControl)
                {
                    case 0:

                        Debug.Log("Access Denied - Guest only.");
                        break;
                    case 1:

                        Debug.Log("Welcome, Staff! Access to Kitchen granted.");
                        break;
                    case 2:

                        Debug.Log("Welcome, Member! Access to Lounge granted.");
                        break;
                    case 3:

                        Debug.Log("Welcome, Admin! Full Access granted.");
                        break;
                        
                }
            }
            // -- Rabisco -- //
            
           /* public void UserUpgrade()
            {
                if (Input.GetKeyDown(keyUpgrade))
                {
                    if (acessControl < 1)  // --> -1 = 1  
                    {
                        acessControl += 1;
                        

                    }
                    
                    else if (acessControl == 3)
                    {
                        acessControl = 0;
                    }
                }
            }

           
            }

            public void UserAcess()
            {
                if (Input.GetKeyDown(keyAcess))
                {
                    if (acessControl != 1)
                    {
                        Debug.Log("Welcome, Member! Access to Kitchen granted.");
                    }
                }
            }
            */
        }
}