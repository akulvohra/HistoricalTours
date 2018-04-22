using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker_Collider : MonoBehaviour {
    public Material green;
    public MeshRenderer mine;
    // Use this for initialization
    void Start () {
        mine = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mine.material = green;
        }
    }
}
