﻿// Decompiled with JetBrains decompiler
// Type: ConsoleHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class ConsoleHandler : Attribute
{
  public string Command;

  public ConsoleHandler(string cmd)
  {
    this.Command = cmd;
  }
}
