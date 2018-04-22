using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeckFactScript : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        m_MyAudioSource.Play();

    }
    private void OnCollisionExit(Collision collision)
    {

    }
}
