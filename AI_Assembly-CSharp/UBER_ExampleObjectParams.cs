﻿// Decompiled with JetBrains decompiler
// Type: UBER_ExampleObjectParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\\AI_Assembly-CSharp.dll

using System;
using UnityEngine;

[Serializable]
public class UBER_ExampleObjectParams
{
  public GameObject target;
  public string materialProperty;
  public MeshRenderer renderer;
  public int submeshIndex;
  public Vector2 SliderRange;
  public string Title;
  public string MatParamName;
  [TextArea(2, 5)]
  public string Description;
}
