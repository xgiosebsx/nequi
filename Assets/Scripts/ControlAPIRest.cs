using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using System;
using System.Text;
using System.Xml;
using System.IO;

public class ControlAPIRest : MonoBehaviour {

    #region Variables para la conexión con API REST
    public string apiRest = "http://www.mocky.io/v2/59f107fa3100009e2e0ea0e4";
    #endregion

    #region Variables Generales
    public string nombreDato;   //Persistencia
    private String dato;
    #endregion

    #region Inicializando logica
    void Start()
    {

    }
    #endregion

    #region Llamando constantemente a los datos
    void Update()
    {
        StartCoroutine(GetPosts());
    }
    #endregion

    #region Logica para XML y Guardar datos
    public void SaveDataXML(String mensaje)
    {
        String xmlMensaje = mensaje;
        //Aplicar el descriptor de XML
        XmlTextReader leer = new XmlTextReader(new StringReader(xmlMensaje));
        while (leer.Read())
        {
            if (leer.IsStartElement("value"))
                dato = leer.ReadString();
        }
        //msgq.Enqueue(s);
        PlayerPrefs.SetFloat(nombreDato, float.Parse(dato)); //dato
    }
    #endregion

    #region LOGICA PARA API REST
    public IEnumerator GetPosts()
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(apiRest);
        yield return webRequest.Send();

        if (!webRequest.isError)
        {
            //Debug.Log("DATO API REST");
            //Debug.Log(webRequest.downloadHandler.text);
            //datorest = webRequest.downloadHandler.text;
            SaveDataXML(webRequest.downloadHandler.text);
        }
        else
        {
            Debug.Log(webRequest.error);
        }
    }
    #endregion
}
