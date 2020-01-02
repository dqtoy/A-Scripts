﻿// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform.GetRotation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
  [TaskCategory("Unity/Transform")]
  [TaskDescription("Stores the rotation of the Transform. Returns Success.")]
  public class GetRotation : Action
  {
    [Tooltip("The GameObject that the task operates on. If null the task GameObject is used.")]
    public SharedGameObject targetGameObject;
    [Tooltip("The rotation of the Transform")]
    [RequiredField]
    public SharedQuaternion storeValue;
    private Transform targetTransform;
    private GameObject prevGameObject;

    public GetRotation()
    {
      base.\u002Ector();
    }

    public virtual void OnStart()
    {
      GameObject defaultGameObject = ((Task) this).GetDefaultGameObject(this.targetGameObject.get_Value());
      if (!Object.op_Inequality((Object) defaultGameObject, (Object) this.prevGameObject))
        return;
      this.targetTransform = (Transform) defaultGameObject.GetComponent<Transform>();
      this.prevGameObject = defaultGameObject;
    }

    public virtual TaskStatus OnUpdate()
    {
      if (Object.op_Equality((Object) this.targetTransform, (Object) null))
      {
        Debug.LogWarning((object) "Transform is null");
        return (TaskStatus) 1;
      }
      this.storeValue.set_Value(this.targetTransform.get_rotation());
      return (TaskStatus) 2;
    }

    public virtual void OnReset()
    {
      this.targetGameObject = (SharedGameObject) null;
      this.storeValue = (SharedQuaternion) Quaternion.get_identity();
    }
  }
}
