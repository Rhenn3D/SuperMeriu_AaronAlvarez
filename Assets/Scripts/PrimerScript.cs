using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    // Variables
    public int numeroEntero = 5; // Variable para numeros enteros

    private float numeroDecimal = 7.5f; // Variable para numeros con decimales

    bool boleana = true; // Variable verdadero o falso
    
    string cadenaTexto = "Hola, Mundo"; // Variable para poder poner texto

    // Start is called before the first frame update

    public int Polla = 5;


    private int[] numeros = {75, 1, 3};
    public int[] numeros2;
    private int[ , ] numeros3 = {{7, 8, 98}, {9,22,45}};    

    List<int> listaDeNumeros = new List<int> {3, 5, 8, 9, 42, 15};

    void Start()
    {
        
        foreach(int numero in listaDeNumeros)
        {
            Debug.Log(numero);
        }


        listaDeNumeros.Add(22);
        listaDeNumeros.RemoveAt(0);
        listaDeNumeros.RemoveAt(Polla);
        listaDeNumeros.RemoveAt(listaDeNumeros.Count - 1);
     foreach(int numero in listaDeNumeros)
    {
        Debug.Log(numero);
    }
    //listaDeNumeros.Clear();

    listaDeNumeros.Sort();
    listaDeNumeros.Reverse();
        
        //Debug.Log(numeros[0]);
        //Debug.Log(numeros3[1,2]);

       Calculos();

      /*foreach(int numero in numeros) //Por cada int en el array... X
       {
            Debug.Log(numero);
       }

       for(int i = 0; i < ; i++)
       {
        Debug.Log(i);
       }*/
   /* int i = 0
       while(i < numeros.Length)
       {
        Debug.Log(numeros[i]);
        i++;
       }*/
    int i = 78;
       do
       {
        Debug.Log("bfwibvikw<b");
       }
       while(i < numeros.Length);


    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void Calculos()
    {
         Debug.Log(numeroEntero); // Enseñar en la consola algún valor
        numeroEntero = 17;
        Debug.Log(numeroEntero);
        numeroEntero = 7 * 3; // Puedo hacer otras divisiones con + - * /
        Debug.Log(numeroEntero);
        numeroEntero ++; // Con ++ sumo 1 y con -- Resto 1
        numeroEntero -= 5; // Puedo sumar o restar el valor que yo quiera

    }

}
