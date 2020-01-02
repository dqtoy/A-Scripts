﻿// Decompiled with JetBrains decompiler
// Type: Rewired.RacingWheelTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System;

namespace Rewired
{
  public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
  {
    public static readonly Guid typeGuid = new Guid("104e31d8-9115-4dd5-a398-2e54d35e6c83");
    public const int elementId_wheel = 0;
    public const int elementId_accelerator = 1;
    public const int elementId_brake = 2;
    public const int elementId_clutch = 3;
    public const int elementId_shiftDown = 4;
    public const int elementId_shiftUp = 5;
    public const int elementId_wheelButton1 = 6;
    public const int elementId_wheelButton2 = 7;
    public const int elementId_wheelButton3 = 8;
    public const int elementId_wheelButton4 = 9;
    public const int elementId_wheelButton5 = 10;
    public const int elementId_wheelButton6 = 11;
    public const int elementId_wheelButton7 = 12;
    public const int elementId_wheelButton8 = 13;
    public const int elementId_wheelButton9 = 14;
    public const int elementId_wheelButton10 = 15;
    public const int elementId_consoleButton1 = 16;
    public const int elementId_consoleButton2 = 17;
    public const int elementId_consoleButton3 = 18;
    public const int elementId_consoleButton4 = 19;
    public const int elementId_consoleButton5 = 20;
    public const int elementId_consoleButton6 = 21;
    public const int elementId_consoleButton7 = 22;
    public const int elementId_consoleButton8 = 23;
    public const int elementId_consoleButton9 = 24;
    public const int elementId_consoleButton10 = 25;
    public const int elementId_shifter1 = 26;
    public const int elementId_shifter2 = 27;
    public const int elementId_shifter3 = 28;
    public const int elementId_shifter4 = 29;
    public const int elementId_shifter5 = 30;
    public const int elementId_shifter6 = 31;
    public const int elementId_shifter7 = 32;
    public const int elementId_shifter8 = 33;
    public const int elementId_shifter9 = 34;
    public const int elementId_shifter10 = 35;
    public const int elementId_reverseGear = 44;
    public const int elementId_select = 36;
    public const int elementId_start = 37;
    public const int elementId_systemButton = 38;
    public const int elementId_horn = 43;
    public const int elementId_dPadUp = 39;
    public const int elementId_dPadRight = 40;
    public const int elementId_dPadDown = 41;
    public const int elementId_dPadLeft = 42;
    public const int elementId_dPad = 45;

    public RacingWheelTemplate(object payload)
    {
      base.\u002Ector(payload);
    }

    IControllerTemplateAxis IRacingWheelTemplate.wheel
    {
      get
      {
        return (IControllerTemplateAxis) this.GetElement<IControllerTemplateAxis>(0);
      }
    }

    IControllerTemplateAxis IRacingWheelTemplate.accelerator
    {
      get
      {
        return (IControllerTemplateAxis) this.GetElement<IControllerTemplateAxis>(1);
      }
    }

    IControllerTemplateAxis IRacingWheelTemplate.brake
    {
      get
      {
        return (IControllerTemplateAxis) this.GetElement<IControllerTemplateAxis>(2);
      }
    }

    IControllerTemplateAxis IRacingWheelTemplate.clutch
    {
      get
      {
        return (IControllerTemplateAxis) this.GetElement<IControllerTemplateAxis>(3);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shiftDown
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(4);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shiftUp
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(5);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton1
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(6);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton2
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(7);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton3
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(8);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton4
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(9);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton5
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(10);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton6
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(11);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton7
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(12);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton8
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(13);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton9
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(14);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.wheelButton10
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(15);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton1
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(16);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton2
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(17);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton3
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(18);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton4
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(19);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton5
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(20);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton6
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(21);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton7
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(22);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton8
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(23);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton9
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(24);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.consoleButton10
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(25);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter1
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(26);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter2
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(27);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter3
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(28);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter4
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(29);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter5
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(30);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter6
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(31);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter7
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(32);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter8
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(33);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter9
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(34);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.shifter10
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(35);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.reverseGear
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(44);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.select
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(36);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.start
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(37);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.systemButton
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(38);
      }
    }

    IControllerTemplateButton IRacingWheelTemplate.horn
    {
      get
      {
        return (IControllerTemplateButton) this.GetElement<IControllerTemplateButton>(43);
      }
    }

    IControllerTemplateDPad IRacingWheelTemplate.dPad
    {
      get
      {
        return (IControllerTemplateDPad) this.GetElement<IControllerTemplateDPad>(45);
      }
    }
  }
}
