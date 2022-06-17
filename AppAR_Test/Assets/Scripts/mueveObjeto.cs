using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueveObjeto : MonoBehaviour
{
    public Animator controlAnimacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            controlAnimacion.SetBool("mueve", true);
        }
        //if(controlAnimacion.GetCurrentAnimatorClipInfo(0)[0].clip.name=="giraO")
        //{
        //    controlAnimacion.SetBool("mueve", false);
        //}
    }
}
