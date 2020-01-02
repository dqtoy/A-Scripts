﻿// Decompiled with JetBrains decompiler
// Type: Studio.SampleColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using Illusion.Component.UI.ColorPicker;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Studio
{
  public class SampleColor : MonoBehaviour
  {
    [SerializeField]
    private Image image;
    [SerializeField]
    private PickerRect rect;
    [SerializeField]
    private PickerSliderInput slider;
    [SerializeField]
    private ColorPresets preset;
    private bool callUpdate;
    public Action<Color> actUpdateColor;

    public SampleColor()
    {
      base.\u002Ector();
    }

    private void Start()
    {
      if (!Object.op_Implicit((Object) this.image))
        return;
      if (Object.op_Implicit((Object) this.rect))
      {
        this.rect.SetColor(((Graphic) this.image).get_color());
        this.rect.updateColorAction += (Action<Color>) (color => this.UpdateRectColor(color));
      }
      if (Object.op_Implicit((Object) this.slider))
      {
        this.slider.color = ((Graphic) this.image).get_color();
        this.slider.SetInputText();
        this.slider.updateColorAction += (Action<Color>) (color => this.UpdateSliderColor(color));
      }
      if (!Object.op_Implicit((Object) this.preset))
        return;
      this.preset.color = ((Graphic) this.image).get_color();
      this.preset.updateColorAction += (Action<Color>) (color => this.UpdatePresetsColor(color));
    }

    public void SetColor(Color color)
    {
      this.callUpdate = true;
      ((Graphic) this.image).set_color(color);
      if (Object.op_Implicit((Object) this.rect))
        this.rect.SetColor(color);
      if (Object.op_Implicit((Object) this.slider))
        this.slider.color = color;
      if (Object.op_Implicit((Object) this.preset))
        this.preset.color = color;
      this.callUpdate = false;
    }

    public void UpdateRectColor(Color color)
    {
      if (this.callUpdate)
        return;
      this.callUpdate = true;
      ((Graphic) this.image).set_color(color);
      if (Object.op_Implicit((Object) this.slider))
        this.slider.color = color;
      if (Object.op_Implicit((Object) this.preset))
        this.preset.color = color;
      this.actUpdateColor.Call<Color>(color);
      this.callUpdate = false;
    }

    public void UpdateSliderColor(Color color)
    {
      if (this.callUpdate)
        return;
      this.callUpdate = true;
      ((Graphic) this.image).set_color(color);
      if (Object.op_Implicit((Object) this.rect))
        this.rect.SetColor(color);
      if (Object.op_Implicit((Object) this.preset))
        this.preset.color = color;
      this.actUpdateColor.Call<Color>(color);
      this.callUpdate = false;
    }

    public void UpdatePresetsColor(Color color)
    {
      if (this.callUpdate)
        return;
      this.callUpdate = true;
      ((Graphic) this.image).set_color(color);
      if (Object.op_Implicit((Object) this.rect))
        this.rect.SetColor(color);
      if (Object.op_Implicit((Object) this.slider))
        this.slider.color = color;
      this.actUpdateColor.Call<Color>(color);
      this.callUpdate = false;
    }
  }
}