﻿// Decompiled with JetBrains decompiler
// Type: CharaCustom.CvsB_ShapeLeg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace CharaCustom
{
  public class CvsB_ShapeLeg : CvsBase
  {
    [SerializeField]
    private CustomSliderSet ssThighUp;
    [SerializeField]
    private CustomSliderSet ssThighLow;
    [SerializeField]
    private CustomSliderSet ssCalf;
    [SerializeField]
    private CustomSliderSet ssAnkle;
    private CustomSliderSet[] ssShape;
    private int[] shapeIdx;

    public override void ChangeMenuFunc()
    {
      base.ChangeMenuFunc();
      this.customBase.customCtrl.showColorCvs = false;
      this.customBase.customCtrl.showFileList = false;
    }

    private void CalculateUI()
    {
      for (int index = 0; index < this.ssShape.Length; ++index)
        this.ssShape[index].SetSliderValue(this.body.shapeValueBody[this.shapeIdx[index]]);
    }

    public override void UpdateCustomUI()
    {
      base.UpdateCustomUI();
      this.CalculateUI();
    }

    [DebuggerHidden]
    public IEnumerator SetInputText()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new CvsB_ShapeLeg.\u003CSetInputText\u003Ec__Iterator0()
      {
        \u0024this = this
      };
    }

    public void Awake()
    {
      this.shapeIdx = new int[4]{ 25, 26, 27, 28 };
      this.ssShape = new CustomSliderSet[4]
      {
        this.ssThighUp,
        this.ssThighLow,
        this.ssCalf,
        this.ssAnkle
      };
    }

    protected override void Start()
    {
      base.Start();
      this.customBase.actUpdateCvsBodyShapeWhole += new Action(((CvsBase) this).UpdateCustomUI);
      for (int index = 0; index < this.ssShape.Length; ++index)
      {
        int idx = this.shapeIdx[index];
        this.ssShape[index].onChange = (Action<float>) (value =>
        {
          this.body.shapeValueBody[idx] = value;
          this.chaCtrl.SetShapeBodyValue(idx, value);
        });
        this.ssShape[index].onSetDefaultValue = (Func<float>) (() => this.defChaCtrl.custom.body.shapeValueBody[idx]);
      }
      this.StartCoroutine(this.SetInputText());
    }
  }
}