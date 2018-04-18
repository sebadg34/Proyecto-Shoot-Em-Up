using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movFondo : MonoBehaviour {

    public float scrollSpeed;
    private Vector2 savedOffset;
    

	// Use this for initialization
	void Start () {
        var renderer = GetComponent<Renderer>();
        savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
        var renderer = GetComponent<Renderer>();
        float y = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(savedOffset.x, y);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

        
	}

     void OnDisable() {
        var renderer = GetComponent<Renderer>();
        renderer.sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
    }
}
