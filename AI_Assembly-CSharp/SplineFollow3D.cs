﻿// Decompiled with JetBrains decompiler
// Type: SplineFollow3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class SplineFollow3D : MonoBehaviour
{
  public int segments;
  public bool doLoop;
  public Transform cube;
  public float speed;

  public SplineFollow3D()
  {
    base.\u002Ector();
  }

  [DebuggerHidden]
  private IEnumerator Start()
  {
    // ISSUE: object of a compiler-generated type is created
    return (IEnumerator) new SplineFollow3D.\u003CStart\u003Ec__Iterator0()
    {
      \u0024this = this
    };
  }
}
