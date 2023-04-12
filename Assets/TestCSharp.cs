using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tipo
{
    ACTIVO, INACTIVO
}

public class TestCSharp : MonoBehaviour
{
    private string nombre;
    public int Edad { get; private set; } // propiedad

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }


    protected void MetodoProtected()
    {
        
    }

    public void MetodoPublico()
    {

    }

    private void Start()
    {
        int num = 10;
        float peso = 40.5f;
        bool verdad = true;
        string nombre = "Pepe";

        /*
        string numero = num.ToString(); //NullReferenceException
        string numero = (string)num; // InvalidaCastException
        string numero = num as string; // numero = null
        */

        Debug.Log($"Hola {nombre}");
    }
}
