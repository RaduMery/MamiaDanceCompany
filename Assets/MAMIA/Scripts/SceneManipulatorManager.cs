using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class SceneManipulatorManager : MonoBehaviour
{

    [Header("Projector")]
    public GameObject projector;
    // placement adjustments for projector
    // ortographick or perspective bool
    // position X, Y, Z
    // rotation X
    // environment -> background color
    
    public GameObject postProsessing;
    // what parameters i want to manually manipulate
    // can i substitute the "GameObject" with someting more specific?

    [Header("Planes")]
    public GameObject frontPlane;
    // color, shader, opacity, mask
    public GameObject animationPlane;
    // ON / OFF
    // color
    public GameObject backPlane;
    //color, sheder, PNGvideoClip,

    [Header("Objects")]
    //animation on and off
    // ON / OFF
    // what value adjustments to object?

    [Header("Shaders")]
    public GameObject something;
    // list of different shaders
    // what is the best way to access and manipulate them

    [Header("MoCapClips")]
    public GameObject videoClips;
    //List of clips or clip_01, clip_02?

    [Header("Sounds")]
    public GameObject sound;
    // clips
    // volume
    // bind voice to effects
    // bind music to effects

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
