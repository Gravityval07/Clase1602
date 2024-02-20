using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

[System.Serializable]
public class DataJSON : System.Object
{

    [SerializeField]
    public string nombre_juego;
    [SerializeField]
    public string nombre_jugador1;
    [SerializeField]
    public int nivel1;
    [SerializeField]
    public int salud;
    [SerializeField]
    public string correo;
    public Vector3 PlayerLocation;

    public DataJSON()
    {
    }

}