﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlResumen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cambiar1Opcion()
    {
        Image img = GameObject.Find("opciones").GetComponent<Image>();
        Sprite sprite = Resources.Load<Sprite>("Media/2D/1resumen");
        img.sprite = sprite;

        Image img2 = GameObject.Find("grafica").GetComponent<Image>();
        Sprite sprite2 = Resources.Load<Sprite>("Media/2D/torta");
        img2.sprite = sprite2;

        Text textopcion1 = GameObject.Find("opciontitulo1").GetComponent<Text>();
        textopcion1.text = "Pagos";

        Text textopcion2 = GameObject.Find("opciontitulo2").GetComponent<Text>();
        textopcion2.text = "Cobros";

        Text textopcion3 = GameObject.Find("opciontitulo3").GetComponent<Text>();
        textopcion3.text = "Envios";

        Text textopcion4 = GameObject.Find("titulo").GetComponent<Text>();
        textopcion4.text = "Servicios Nequi";

        Image img3 = GameObject.Find("opcion1").GetComponent<Image>();
        img3.sprite = null;

        Image img4 = GameObject.Find("opcion2").GetComponent<Image>();
        img4.sprite = null;

        Image img5 = GameObject.Find("opcion3").GetComponent<Image>();
        img5.sprite = null;

        Text textopcion5 = GameObject.Find("opciontitulo5").GetComponent<Text>();
        textopcion5.text = "20.000 COP";

        Text textopcion6 = GameObject.Find("opciontitulo6").GetComponent<Text>();
        textopcion6.text = "40.000 COP";

        Text textopcion7 = GameObject.Find("opciontitulo7").GetComponent<Text>();
        textopcion7.text = "40.000 COP";
    }

    public void cambiar2Opcion()
    {
        Image img = GameObject.Find("opciones").GetComponent<Image>();
        Sprite sprite = Resources.Load<Sprite>("Media/2D/2resumen");
        img.sprite = sprite;

        Image img2 = GameObject.Find("grafica").GetComponent<Image>();
        Sprite sprite2 = Resources.Load<Sprite>("Media/2D/barras");
        img2.sprite = sprite2;

        Text textopcion4 = GameObject.Find("titulo").GetComponent<Text>();
        textopcion4.text = "Compras establecimientos";

        Image img3 = GameObject.Find("opcion1").GetComponent<Image>();
        Sprite sprite3 = Resources.Load<Sprite>("Media/2D/comida");
        img3.sprite = sprite3;

        Image img4 = GameObject.Find("opcion2").GetComponent<Image>();
        Sprite sprite4 = Resources.Load<Sprite>("Media/2D/ropa");
        img4.sprite = sprite4;

        Image img5 = GameObject.Find("opcion3").GetComponent<Image>();
        Sprite sprite5 = Resources.Load<Sprite>("Media/2D/licores");
        img5.sprite = sprite5;

        Text textopcion1 = GameObject.Find("opciontitulo1").GetComponent<Text>();
        textopcion1.text = "Comida";

        Text textopcion2 = GameObject.Find("opciontitulo2").GetComponent<Text>();
        textopcion2.text = "Ropa";

        Text textopcion3 = GameObject.Find("opciontitulo3").GetComponent<Text>();
        textopcion3.text = "Licores";


        Text textopcion5 = GameObject.Find("opciontitulo5").GetComponent<Text>();
        textopcion5.text = "";

        Text textopcion6 = GameObject.Find("opciontitulo6").GetComponent<Text>();
        textopcion6.text = "";

        Text textopcion7 = GameObject.Find("opciontitulo7").GetComponent<Text>();
        textopcion7.text = "";
    }

    public void cambiar3Opcion()
    {
        Image img = GameObject.Find("opciones").GetComponent<Image>();
        Sprite sprite = Resources.Load<Sprite>("Media/2D/3resumen");
        img.sprite = sprite;

        Image img2 = GameObject.Find("grafica").GetComponent<Image>();
        Sprite sprite2 = Resources.Load<Sprite>("Media/2D/dostortas");
        img2.sprite = sprite2;

        Text textopcion1 = GameObject.Find("opciontitulo1").GetComponent<Text>();
        textopcion1.text = "Pagos";

        Text textopcion2 = GameObject.Find("opciontitulo2").GetComponent<Text>();
        textopcion2.text = "Cobros";

        Text textopcion3 = GameObject.Find("opciontitulo3").GetComponent<Text>();
        textopcion3.text = "Envios";

        Text textopcion4 = GameObject.Find("titulo").GetComponent<Text>();
        textopcion4.text = "Comparación meses";

        Image img3 = GameObject.Find("opcion1").GetComponent<Image>();
        img3.sprite = null;

        Image img4 = GameObject.Find("opcion2").GetComponent<Image>();
        img4.sprite = null;

        Image img5 = GameObject.Find("opcion3").GetComponent<Image>();
        img5.sprite = null;

        Text textopcion5 = GameObject.Find("opciontitulo5").GetComponent<Text>();
        textopcion5.text = "";

        Text textopcion6 = GameObject.Find("opciontitulo6").GetComponent<Text>();
        textopcion6.text = "";

        Text textopcion7 = GameObject.Find("opciontitulo7").GetComponent<Text>();
        textopcion7.text = "";
    }

    public void regresarAnterior() {
        SceneManager.LoadScene("TuCuenta", LoadSceneMode.Single);
    }
}
