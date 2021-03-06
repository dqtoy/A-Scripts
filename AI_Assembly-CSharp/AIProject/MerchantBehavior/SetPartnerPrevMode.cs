﻿// Decompiled with JetBrains decompiler
// Type: AIProject.MerchantBehavior.SetPartnerPrevMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\\AI_Assembly-CSharp.dll

using AIProject.Definitions;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

namespace AIProject.MerchantBehavior
{
  [TaskCategory("商人")]
  public class SetPartnerPrevMode : MerchantAction
  {
    [SerializeField]
    private Desire.ActionType _mode;

    public virtual TaskStatus OnUpdate()
    {
      AgentActor partner = this.Merchant.Partner as AgentActor;
      if (Object.op_Equality((Object) partner, (Object) null))
        return (TaskStatus) 1;
      partner.PrevMode = this._mode;
      return (TaskStatus) 2;
    }
  }
}
