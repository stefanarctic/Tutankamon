using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideSceneManager : MonoBehaviour
{

    public Animator fadingTextAnimator;
    public string triggerParameterName = "TriggerFadeIn";
    public GameObject canvas2;

    private FunctionTimer timer;

    private void Start()
    {
        fadingTextAnimator.SetTrigger(triggerParameterName);
        //fadingTextAnimator.f
        timer = new FunctionTimer(OnAnimationFinish, 480 / 60 - 1);
    }

    private void Update()
    {
        timer.Update();
    }

    private void OnAnimationFinish()
    {
        //print("Animation finish");
        canvas2.SetActive(false);
    }

}