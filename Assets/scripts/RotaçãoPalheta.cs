using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaçãoPalheta : MonoBehaviour {
    public float rotaçãoP = -40f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0f,0f,rotaçãoP)*Time.deltaTime);
	}
}
