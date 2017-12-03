using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareFacebook : MonoBehaviour {

    public void share()
    {
        Application.OpenURL("https://www.facebook.com");
    }

}
