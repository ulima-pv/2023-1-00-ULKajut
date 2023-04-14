using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pregunta
{
    public string Texto;
    public List<string> Opciones;
    public int IndexCorrecta;

    public Pregunta()
    {
        Opciones = new List<string>();
    }
}

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TextoPregunta;
    public TextMeshProUGUI TextoTimer;
    public Button ButOpcion1;
    public Button ButOpcion2;
    public Button ButOpcion3;
    public Button ButOpcion4;

    private List<Pregunta> listaPreguntas;
    private int index = 0;

    private void Start()
    {
        // 1. Crear las preguntas
        CrearPreguntas();
        // 2. Cargar pregunta inicial
        CargarPregunta(0);
    }

    private void CrearPreguntas()
    {
        Pregunta p1 = new Pregunta();
        p1.Texto = "Esta es la pregunta 1?";
        p1.Opciones.Add("OPCION 1");
        p1.Opciones.Add("OPCION 2");
        p1.Opciones.Add("OPCION 3");
        p1.Opciones.Add("OPCION 4");
        p1.IndexCorrecta = 1;

        Pregunta p2 = new Pregunta();
        p2.Texto = "Esta es la pregunta 1?";
        p2.Opciones.Add("OPCION 1");
        p2.Opciones.Add("OPCION 2");
        p2.Opciones.Add("OPCION 3");
        p2.Opciones.Add("OPCION 4");
        p2.IndexCorrecta = 2;

        listaPreguntas = new List<Pregunta>();

        listaPreguntas.Add(p1);
        listaPreguntas.Add(p2);
    }

    private void CargarPregunta(int index)
    {
        Pregunta pregunta = listaPreguntas[index];
        TextoPregunta.text = pregunta.Texto;
    }
}
