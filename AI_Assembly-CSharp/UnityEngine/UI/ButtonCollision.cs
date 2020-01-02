﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ButtonCollision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

namespace UnityEngine.UI
{
  internal class ButtonCollision : Button, ICanvasRaycastFilter
  {
    [SerializeField]
    private RectTransform _target;

    public ButtonCollision()
    {
      base.\u002Ector();
    }

    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
      return RectTransformUtility.RectangleContainsScreenPoint(this._target, sp, eventCamera);
    }

    protected virtual void Awake()
    {
      ((Selectable) this).Awake();
      if (!Object.op_Equality((Object) this._target, (Object) null))
        return;
      this._target = ((Component) this).get_transform() as RectTransform;
    }
  }
}