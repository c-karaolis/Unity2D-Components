using UnityEngine;
using System.Collections;
using DG.Tweening;
using Matcha.Lib;


public class GameInit : BaseBehaviour
{
    void Awake()
    {
        // initialize DOTween before first use.
        DOTween.Init(true, true, LogBehaviour.Verbose).SetCapacity(4000, 4000);

        // seed Random with current seconds;
        Random.seed = (int)System.DateTime.Now.Ticks;
    }
}
