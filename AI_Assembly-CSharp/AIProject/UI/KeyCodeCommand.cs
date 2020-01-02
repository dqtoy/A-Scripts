﻿// Decompiled with JetBrains decompiler
// Type: AIProject.UI.KeyCodeCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using Manager;
using System;
using UnityEngine;

namespace AIProject.UI
{
  [Serializable]
  public class KeyCodeCommand : DownCommandDataBase
  {
    [SerializeField]
    private KeyCode _keyCode = (KeyCode) 97;

    public KeyCode KeyCode
    {
      get
      {
        return this._keyCode;
      }
      set
      {
        this._keyCode = value;
      }
    }

    protected override bool IsInput(Input input)
    {
      return input.IsDown(this._keyCode);
    }
  }
}
