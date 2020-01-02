﻿// Decompiled with JetBrains decompiler
// Type: UnityStandardAssets.CinematicEffects.ME_RenderTextureUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
  public class ME_RenderTextureUtility
  {
    private List<RenderTexture> m_TemporaryRTs = new List<RenderTexture>();

    public RenderTexture GetTemporaryRenderTexture(
      int width,
      int height,
      int depthBuffer = 0,
      RenderTextureFormat format = 2,
      FilterMode filterMode = 1)
    {
      RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer, format);
      ((Texture) temporary).set_filterMode(filterMode);
      ((Texture) temporary).set_wrapMode((TextureWrapMode) 1);
      ((Object) temporary).set_name("RenderTextureUtilityTempTexture");
      this.m_TemporaryRTs.Add(temporary);
      return temporary;
    }

    public void ReleaseTemporaryRenderTexture(RenderTexture rt)
    {
      if (Object.op_Equality((Object) rt, (Object) null))
        return;
      if (!this.m_TemporaryRTs.Contains(rt))
      {
        Debug.LogErrorFormat("Attempting to remove texture that was not allocated: {0}", new object[1]
        {
          (object) rt
        });
      }
      else
      {
        this.m_TemporaryRTs.Remove(rt);
        RenderTexture.ReleaseTemporary(rt);
      }
    }

    public void ReleaseAllTemporaryRenderTextures()
    {
      for (int index = 0; index < this.m_TemporaryRTs.Count; ++index)
        RenderTexture.ReleaseTemporary(this.m_TemporaryRTs[index]);
      this.m_TemporaryRTs.Clear();
    }
  }
}
