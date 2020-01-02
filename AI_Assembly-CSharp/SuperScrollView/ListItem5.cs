﻿// Decompiled with JetBrains decompiler
// Type: SuperScrollView.ListItem5
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB45F06-6483-4AD8-97CB-A1C42CCDD6C3
// Assembly location: E:\GAME\illusion_AI\PluginDev\反编译阅读\AI_Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
  public class ListItem5 : MonoBehaviour
  {
    public Text mNameText;
    public Image mIcon;
    public Image mStarIcon;
    public Text mStarCount;
    public Text mDescText;
    public Color32 mRedStarColor;
    public Color32 mGrayStarColor;
    private int mItemDataIndex;
    public GameObject mContentRootObj;

    public ListItem5()
    {
      base.\u002Ector();
    }

    public void Init()
    {
      ClickEventListener.Get(((Component) this.mStarIcon).get_gameObject()).SetClickEventHandler(new Action<GameObject>(this.OnStarClicked));
    }

    private void OnStarClicked(GameObject obj)
    {
      ItemData itemDataByIndex = DataSourceMgr.Get.GetItemDataByIndex(this.mItemDataIndex);
      if (itemDataByIndex == null)
        return;
      if (itemDataByIndex.mStarCount == 5)
        itemDataByIndex.mStarCount = 0;
      else
        ++itemDataByIndex.mStarCount;
      this.SetStarCount(itemDataByIndex.mStarCount);
    }

    public void SetStarCount(int count)
    {
      this.mStarCount.set_text(count.ToString());
      if (count == 0)
        ((Graphic) this.mStarIcon).set_color(Color32.op_Implicit(this.mGrayStarColor));
      else
        ((Graphic) this.mStarIcon).set_color(Color32.op_Implicit(this.mRedStarColor));
    }

    public void SetItemData(ItemData itemData, int itemIndex)
    {
      this.mItemDataIndex = itemIndex;
      this.mNameText.set_text(itemData.mName);
      this.mDescText.set_text(itemData.mFileSize.ToString() + "KB");
      this.mIcon.set_sprite(ResManager.Get.GetSpriteByName(itemData.mIcon));
      this.SetStarCount(itemData.mStarCount);
    }
  }
}
