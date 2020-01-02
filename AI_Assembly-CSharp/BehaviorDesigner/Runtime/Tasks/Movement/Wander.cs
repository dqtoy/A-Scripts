﻿// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Movement.Wander
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
  [TaskDescription("Wander using the Unity NavMesh.")]
  [TaskCategory("Movement")]
  [HelpURL("http://www.opsive.com/assets/BehaviorDesigner/Movement/documentation.php?id=9")]
  [TaskIcon("Assets/Behavior Designer Movement/Editor/Icons/{SkinColor}WanderIcon.png")]
  public class Wander : NavMeshMovement
  {
    [Tooltip("Minimum distance ahead of the current position to look ahead for a destination")]
    public SharedFloat minWanderDistance = (SharedFloat) 20f;
    [Tooltip("Maximum distance ahead of the current position to look ahead for a destination")]
    public SharedFloat maxWanderDistance = (SharedFloat) 20f;
    [Tooltip("The amount that the agent rotates direction")]
    public SharedFloat wanderRate = (SharedFloat) 2f;
    [Tooltip("The minimum length of time that the agent should pause at each destination")]
    public SharedFloat minPauseDuration = (SharedFloat) 0.0f;
    [Tooltip("The maximum length of time that the agent should pause at each destination (zero to disable)")]
    public SharedFloat maxPauseDuration = (SharedFloat) 0.0f;
    [Tooltip("The maximum number of retries per tick (set higher if using a slow tick time)")]
    public SharedInt targetRetries = (SharedInt) 1;
    private float pauseTime;
    private float destinationReachTime;

    public virtual TaskStatus OnUpdate()
    {
      if (this.HasArrived())
      {
        if ((double) this.maxPauseDuration.get_Value() > 0.0)
        {
          if ((double) this.destinationReachTime == -1.0)
          {
            this.destinationReachTime = Time.get_time();
            this.pauseTime = Random.Range(this.minPauseDuration.get_Value(), this.maxPauseDuration.get_Value());
          }
          if ((double) this.destinationReachTime + (double) this.pauseTime <= (double) Time.get_time() && this.TrySetTarget())
            this.destinationReachTime = -1f;
        }
        else
          this.TrySetTarget();
      }
      return (TaskStatus) 3;
    }

    private bool TrySetTarget()
    {
      Vector3 vector3_1 = ((Transform) ((Task) this).transform).get_forward();
      bool flag = false;
      int num = this.targetRetries.get_Value();
      Vector3 vector3_2 = ((Transform) ((Task) this).transform).get_position();
      for (; !flag && num > 0; --num)
      {
        vector3_1 = Vector3.op_Addition(vector3_1, Vector3.op_Multiply(Random.get_insideUnitSphere(), this.wanderRate.get_Value()));
        vector3_2 = Vector3.op_Addition(((Transform) ((Task) this).transform).get_position(), Vector3.op_Multiply(((Vector3) ref vector3_1).get_normalized(), Random.Range(this.minWanderDistance.get_Value(), this.maxWanderDistance.get_Value())));
        flag = this.SamplePosition(vector3_2);
      }
      if (flag)
        this.SetDestination(vector3_2);
      return flag;
    }

    public override void OnReset()
    {
      this.minWanderDistance = (SharedFloat) 20f;
      this.maxWanderDistance = (SharedFloat) 20f;
      this.wanderRate = (SharedFloat) 2f;
      this.minPauseDuration = (SharedFloat) 0.0f;
      this.maxPauseDuration = (SharedFloat) 0.0f;
      this.targetRetries = (SharedInt) 1;
    }
  }
}
