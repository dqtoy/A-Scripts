﻿// Decompiled with JetBrains decompiler
// Type: PlayfulSystems.LoadingScreen.SceneInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\\AI_Assembly-CSharp.dll

using System;
using UnityEngine;

namespace PlayfulSystems.LoadingScreen
{
  [Serializable]
  public class SceneInfo
  {
    public string sceneName;
    [Tooltip("Images are loaded from Resources/ScenePreviews/. Leave empty to keep default background in Loading Scene.")]
    public string imageName;
    public string header;
    [Multiline(4)]
    public string description;
  }
}
