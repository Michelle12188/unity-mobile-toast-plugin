using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ToastPlugin;

public class ToastExample : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        //Show a short toast message
        ToastHelper.ShowToast("This is a Toast", false);
	}
}
