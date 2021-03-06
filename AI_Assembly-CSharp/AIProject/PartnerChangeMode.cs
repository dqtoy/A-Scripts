﻿// Decompiled with JetBrains decompiler
// Type: AIProject.PartnerChangeMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\\AI_Assembly-CSharp.dll

using AIProject.Definitions;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

namespace AIProject
{
  [TaskCategory("")]
  public class PartnerChangeMode : AgentAction
  {
    [SerializeField]
    private Desire.ActionType _modeToChange;

    public virtual TaskStatus OnUpdate()
    {
      AgentActor partner = this.Agent.Partner as AgentActor;
      partner.BehaviorResources.ChangeMode(this._modeToChange);
      partner.Mode = this._modeToChange;
      return (TaskStatus) 2;
    }
  }
}
