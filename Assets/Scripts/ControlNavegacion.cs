using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ControlNavegacion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void principal()
    {
        EditorSceneManager.LoadScene("Principal");
    }

    public void tuCuenta()
    {
        EditorSceneManager.LoadScene("TuCuenta");
    }

    public void logros()
    {
        EditorSceneManager.LoadScene("Logros");
    }

    public void resumen()
    {
        EditorSceneManager.LoadScene("Resumen");
    }

}
