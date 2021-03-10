using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class LvL_Manager : MonoBehaviour
{
    //propiedades
    public Text tag_objeto;
    public Light luz;
    AudioSource linterna;

    // Start is called before the first frame update
    void Start()
    {
        linterna = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            luz.enabled = luz.enabled ? false : true;
            linterna.Play();
        }
    }
}
