﻿// Decompiled with JetBrains decompiler
// Type: AIProject.AgentHiddenAreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace AIProject
{
  public class AgentHiddenAreaData : ScriptableObject
  {
    public List<AgentHiddenAreaData.Param> param;

    public AgentHiddenAreaData()
    {
      base.\u002Ector();
    }

    [Serializable]
    public class Param
    {
      public string Name;
      public int MapID;
      public int AreaID;
      public string HiddenAreaIDMulti;
    }
  }
}
