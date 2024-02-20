using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public DataJSON misDatos;
    public Text textoTitulo;
    public Text textoPlayer;
    public InputField textoJugador;
    public GameObject panelUI;

    // Start is called before the first frame update
    void Start()
    {
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";

        if (File.Exists(filePat))
        {
            string s = File.ReadAllText(filePat);
            misDatos = JsonUtility.FromJson<DataJSON>(s);
            Debug.Log(s);
            Debug.Log(misDatos);
            Debug.Log(misDatos.nombre_juego);
            Debug.Log(misDatos.nombre_jugador1);
            s = JsonUtility.ToJson(misDatos, true);
            Debug.Log(s);
            File.WriteAllText(filePat, s);
        }
        cargaDatos();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            panelUI.SetActive(true);
        }
    }

    void cargaDatos()
    {
        //GameObject.Find("Titulo").GetComponent<Text>().text=misDatos.nombre_juego;
        //GameObject.Find("Nombre").GetComponent<Text>().text = misDatos.nombre_jugador1;
        textoTitulo.text = misDatos.nombre_juego;
        textoPlayer.text=misDatos.nombre_jugador1;
    }
    public void guardaDatos()
    {
        misDatos.nombre_jugador1 = textoJugador.text;
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";
        string s = JsonUtility.ToJson(misDatos, true);
        File.WriteAllText(filePat, s);
    }
}
