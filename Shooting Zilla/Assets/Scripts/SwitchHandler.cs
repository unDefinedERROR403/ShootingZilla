 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class SwitchHandler : MonoBehaviour {
private int switchState = 1;

public GameObject switchBtn;

public void OnSwitchButtonClicked(){
    
switchBtn.transform.DOLocalMoveX(-switchBtn.transform.localPosition.x,0.2f);
switchState = Math.Sign(-switchBtn.transform.localPosition.x);
  }
}

