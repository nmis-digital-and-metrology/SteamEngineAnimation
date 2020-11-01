using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EnginePlay : MonoBehaviour
{
    public Animator engineAnimator;
    public Slider sliderSpeed;



    //public Button playButton;
    //public Button stopButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        engineAnimator.SetFloat("animationSpeed", sliderSpeed.value);
        //engineAnimator.speed = sliderSpeed.value;


        if (Input.GetKeyDown("x") && engineAnimator.GetBool("IsPlay") == false)
        {

            engineAnimator.SetBool("IsPlay", true);
        }
        else if (Input.GetKeyDown("x") && engineAnimator.GetBool("IsPlay") == true)
        {
            engineAnimator.SetBool("IsPlay", false);

        }

    }

    public void PlayAnimation ()
    {
        engineAnimator.SetBool("IsPlay", true);
    }

    public void StopAnimation()
    {
        engineAnimator.SetBool("IsPlay", false);
    }

}
