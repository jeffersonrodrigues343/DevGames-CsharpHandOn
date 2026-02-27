using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  DonationTracker: MonoBehaviour
{
    [Header("Acumulo")]
    [SerializeField] private float totalDonations; 
    [SerializeField] private float donationGoal = 500.0f; 
    /*
    [Header("Controle")]
    [SerializeField] KeyCode teenAdd =  KeyCode.A;
    [SerializeField] KeyCode fiftyAdd =  KeyCode.B;
    [SerializeField] KeyCode hundredAdd =  KeyCode.C;
    */

  
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            addValues(10f);
            
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            addValues(50f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {   
            addValues(100f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Course();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Report();
        }
        
    }

    // Método de acumulo
    private void addValues(float amount)
    {
        totalDonations += amount;
       
        Debug.Log($"Obrigado, você está doando: {amount} total: R$ {totalDonations}");
    }

    private float Course()
    {
        return ( totalDonations / donationGoal) * 100f;

    }

    private void  Report()
    {
        float percentage = Course();
        Debug.Log($"Parabéns, estamos a {percentage}% da doação do total de {donationGoal}R$");
    }
    
}
