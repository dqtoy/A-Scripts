﻿// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2.Dot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\\AI_Assembly-CSharp.dll

using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
  [TaskCategory("Unity/Vector2")]
  [TaskDescription("Stores the dot product of two Vector2 values.")]
  public class Dot : Action
  {
    [Tooltip("The left hand side of the dot product")]
    public SharedVector2 leftHandSide;
    [Tooltip("The right hand side of the dot product")]
    public SharedVector2 rightHandSide;
    [Tooltip("The dot product result")]
    [RequiredField]
    public SharedFloat storeResult;

    public Dot()
    {
      base.\u002Ector();
    }

    public virtual TaskStatus OnUpdate()
    {
      this.storeResult.set_Value(Vector2.Dot(this.leftHandSide.get_Value(), this.rightHandSide.get_Value()));
      return (TaskStatus) 2;
    }

    public virtual void OnReset()
    {
      this.leftHandSide = this.rightHandSide = (SharedVector2) Vector2.get_zero();
      this.storeResult = (SharedFloat) 0.0f;
    }
  }
}
