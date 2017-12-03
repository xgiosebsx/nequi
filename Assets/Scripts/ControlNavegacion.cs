using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNavegacion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void principal()
    {
        SceneManager.LoadScene("Principal", LoadSceneMode.Single);
    }

    public void tuCuenta()
    {
        SceneManager.LoadScene("TuCuenta", LoadSceneMode.Single);
    }

    public void logros()
    {
        SceneManager.LoadScene("Logros", LoadSceneMode.Single);
    }

    public void resumen()
    {
        SceneManager.LoadScene("Resumen", LoadSceneMode.Single);
    }

}
