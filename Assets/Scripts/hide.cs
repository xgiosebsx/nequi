﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void hidePopup()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
