using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el 
//precio de 3 productos y un monto de dinero disponible. Comunicar 
//si la suma de los mismos supera o no el monto de dinero 
//disponible. Luego indicar cuánto dinero sobra o falta.
public class EJ2 : MonoBehaviour
{

    public float precio1;
    public float precio2;
    public float precio3;
    public float montodisponible;
    float sumaprecios;
    float platasobrante;
    float platafaltante;

    // Start is called before the first frame update
    void Start()
    {
        sumaprecios = precio1 + precio2 + precio3;
        
        if(sumaprecios <= montodisponible)
        {
            platasobrante = montodisponible - sumaprecios;
            Debug.Log("Tenés el monto de dinero requerido disponible. Te sobraron " + platasobrante + " pesos");
        }
        else if (sumaprecios > montodisponible)
        {
            platafaltante = sumaprecios - montodisponible;
            Debug.Log("No tenés el monto de dinero requerido disponible. Te faltan " + platafaltante + " pesos");
        }
        else
        {
            Debug.Log("Ingresá de nuevo los valores");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
