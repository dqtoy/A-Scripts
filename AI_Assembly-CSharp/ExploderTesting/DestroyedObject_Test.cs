﻿// Decompiled with JetBrains decompiler
// Type: ExploderTesting.DestroyedObject_Test
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;

namespace ExploderTesting
{
  internal class DestroyedObject_Test : TestCase
  {
    [DebuggerHidden]
    protected override IEnumerator RunTest()
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerator) new DestroyedObject_Test.\u003CRunTest\u003Ec__Iterator0()
      {
        \u0024this = this
      };
    }
  }
}