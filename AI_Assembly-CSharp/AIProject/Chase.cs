﻿// Decompiled with JetBrains decompiler
// Type: AIProject.Chase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using AIProject.Definitions;
using BehaviorDesigner.Runtime.Tasks;
using Manager;
using ReMotion;
using System;
using UniRx;
using UnityEngine;

namespace AIProject
{
  [TaskCategory("")]
  public class Chase : AgentMovement
  {
    public virtual void OnStart()
    {
      AgentActor agent = this.Agent;
      ((Task) this).OnStart();
      agent.StateType = AIProject.Definitions.State.Type.Normal;
      agent.ActivateTransfer(true);
      float speed = agent.NavMeshAgent.get_speed();
      ObservableExtensions.Subscribe<TimeInterval<float>>((IObservable<M0>) Observable.FrameTimeInterval<float>(Observable.TakeUntilDestroy<float>((IObservable<M0>) ObservableEasing.Linear(1f, false), (Component) agent), false), (System.Action<M0>) (x => agent.NavMeshAgent.set_speed(Mathf.Lerp(speed, Singleton<Resources>.Instance.LocomotionProfile.AgentSpeed.walkSpeed, ((TimeInterval<float>) ref x).get_Value()))));
    }

    public virtual TaskStatus OnUpdate()
    {
      AgentActor agent = this.Agent;
      if (Object.op_Equality((Object) agent.TargetInSightActor, (Object) null))
        return (TaskStatus) 1;
      Actor targetInSightActor = agent.TargetInSightActor;
      if (Object.op_Inequality((Object) targetInSightActor.Partner, (Object) null))
      {
        agent.ClearDesire(Desire.Type.Lonely);
        agent.ClearDesire(Desire.Type.H);
        return (TaskStatus) 1;
      }
      AgentProfile.RangeParameter rangeSetting = Singleton<Resources>.Instance.AgentProfile.RangeSetting;
      if (!agent.NavMeshAgent.get_pathPending())
        this.SetDestination(targetInSightActor.Position);
      return this.HasArrived() ? (TaskStatus) 2 : (TaskStatus) 3;
    }

    public virtual void OnEnd()
    {
      this.Agent.StopNavMeshAgent();
    }

    public virtual void OnPause(bool paused)
    {
      AgentActor agent = this.Agent;
      if (paused)
      {
        agent.StopNavMeshAgent();
      }
      else
      {
        if (this.Agent.NavMeshAgent.get_pathPending() || !Object.op_Inequality((Object) agent.TargetInSightActor, (Object) null))
          return;
        this.SetDestination(agent.TargetInSightActor.Position);
      }
    }

    private float RemainingDistance
    {
      get
      {
        return ((Behaviour) this.Agent).get_enabled() ? (!this.Agent.NavMeshAgent.get_pathPending() ? this.Agent.NavMeshAgent.get_remainingDistance() : float.PositiveInfinity) : float.PositiveInfinity;
      }
    }

    protected override bool HasArrived()
    {
      return (double) this.RemainingDistance <= (double) Singleton<Resources>.Instance.AgentProfile.RangeSetting.arrivedDistance;
    }

    protected override bool HasPath()
    {
      return this.Agent.NavMeshAgent.get_hasPath() && (double) this.Agent.NavMeshAgent.get_remainingDistance() > (double) Singleton<Resources>.Instance.AgentProfile.RangeSetting.arrivedDistance;
    }

    protected override bool SetDestination(Vector3 destination)
    {
      if (this.Agent.NavMeshAgent.get_isStopped())
        this.Agent.NavMeshAgent.set_isStopped(false);
      return this.Agent.NavMeshAgent.SetDestination(destination);
    }

    protected override void Stop()
    {
      if (!this.Agent.NavMeshAgent.get_hasPath())
        return;
      this.Agent.NavMeshAgent.set_isStopped(true);
    }

    protected override void UpdateRotation(bool update)
    {
      this.Agent.NavMeshAgent.set_updateRotation(update);
    }

    protected override Vector3 Velocity()
    {
      return this.Agent.NavMeshAgent.get_velocity();
    }
  }
}