using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderCallback : MonoBehaviour {

    protected bool isFirstUpdate = true;
    protected void FixedUpdate() {
        if (isFirstUpdate) 
        {
            isFirstUpdate = false;
            Loader.LoaderCallback();
        }
    }

}
