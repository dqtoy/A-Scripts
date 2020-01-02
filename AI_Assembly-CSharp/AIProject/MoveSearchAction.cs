﻿// Decompiled with JetBrains decompiler
// Type: AIProject.MoveSearchAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

namespace AIProject
{
  public class MoveSearchAction : AgentAction
  {
    public virtual void OnStart()
    {
      AgentActor agent = this.Agent;
      ((Task) this).OnStart();
      agent.StateType = AIProject.Definitions.State.Type.Normal;
      this.Replay(agent);
    }

    private void Replay(AgentActor agent)
    {
      agent.ResetLocomotionAnimation(true);
      agent.SetOriginalDestination();
      agent.StartActionPatrol();
    }

    public virtual TaskStatus OnUpdate()
    {
      AgentActor agent = this.Agent;
      if (agent.LivesActionCalc)
        return (TaskStatus) 3;
      return agent.SearchActionRoute.Count == 0 && Object.op_Equality((Object) agent.DestWaypoint, (Object) null) || !agent.LivesActionPatrol ? (TaskStatus) 2 : (TaskStatus) 3;
    }

    public virtual void OnEnd()
    {
      this.Agent.StopActionPatrol();
    }

    public virtual void OnPause(bool paused)
    {
      AgentActor agent = this.Agent;
      if (paused)
        agent.StopActionPatrol();
      else
        this.Replay(agent);
    }

    public virtual void OnBehaviorRestart()
    {
    }
  }
}
