using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactScript : MonoBehaviour {
    AudioSource m_MyAudioSource;
    public Text fact;
    public Text UIFact;
	void Start () {
		m_MyAudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnCollisionEnter(Collision collision)
    {
        m_MyAudioSource.Play();
 
    }
    private void OnCollisionExit(Collision collision)
    {
        UIFact.text = "";
    }
}
