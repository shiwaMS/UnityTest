using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TextMesh textMesh = GetComponent<TextMesh> ();
		var plugin = new AndroidJavaClass ("microsoft.prototype.unityplugin.UnityPluginClass");
		textMesh.text = plugin.CallStatic<string> ("getText", 8);
	}
	
	// Update is called once per frame
	void Update () {
        // rotate at 90 degrees per second
        transform.Rotate(Vector3.up * Time.deltaTime*90);
	}
}
