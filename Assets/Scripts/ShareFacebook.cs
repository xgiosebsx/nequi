using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareFacebook : MonoBehaviour {

    public void facebook()
    {
        Application.OpenURL("https://www.facebook.com");
    }

    public void twitter()
    {
        Application.OpenURL("https://www.twitter.com");
    }

}
