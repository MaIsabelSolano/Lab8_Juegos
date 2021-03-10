using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Identifificador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Text tag_objeto = GameObject.FindObjectOfType<LvL_Manager>().tag_objeto;

        tag_objeto.enabled = true;

        tag_objeto.text = gameObject.name;
    }

    private void OnMouseExit()
    {
        Text tag_objeto = GameObject.FindObjectOfType<LvL_Manager>().tag_objeto;

        tag_objeto.enabled = false;

    }
}
