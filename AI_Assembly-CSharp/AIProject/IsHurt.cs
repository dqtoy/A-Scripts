﻿// Decompiled with JetBrains decompiler
// Type: AIProject.IsHurt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\\AI_Assembly-CSharp.dll

using BehaviorDesigner.Runtime.Tasks;

namespace AIProject
{
  [TaskCategory("")]
  public class IsHurt : AgentConditional
  {
    public virtual TaskStatus OnUpdate()
    {
      return this.Agent.AgentData.SickState.ID == 4 ? (TaskStatus) 2 : (TaskStatus) 1;
    }
  }
}
