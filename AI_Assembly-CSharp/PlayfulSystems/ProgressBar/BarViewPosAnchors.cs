﻿// Decompiled with JetBrains decompiler
// Type: PlayfulSystems.ProgressBar.BarViewPosAnchors
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\\AI_Assembly-CSharp.dll

namespace PlayfulSystems.ProgressBar
{
  public class BarViewPosAnchors : BarViewSizeAnchors
  {
    public override void UpdateView(float currentValue, float targetValue)
    {
      this.SetPivot(currentValue, currentValue);
    }
  }
}
