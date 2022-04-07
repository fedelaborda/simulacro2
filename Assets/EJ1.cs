using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1.Crea un programa que permita ingresar por Inspector 
//dos valores enteros y responda si son iguales o no lo 
//son.

public class EJ1 : MonoBehaviour
{
    public int numero1;
    public int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 == numero2)
        {
            Debug.Log("Estos numeros son iguales");
        }

        else
        {
            Debug.Log("Estos números no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
