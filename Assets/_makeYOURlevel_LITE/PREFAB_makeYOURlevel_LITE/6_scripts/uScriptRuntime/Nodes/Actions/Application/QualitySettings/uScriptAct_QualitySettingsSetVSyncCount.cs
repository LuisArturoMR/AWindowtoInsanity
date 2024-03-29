// uScript Action Node
// (C) 2012 Detox Studios LLC
#if UNITY_3_4 || UNITY_3_5
using UnityEngine;
using System.Collections;

[NodePath("Actions/Application/Quality Settings")]

[NodeCopyright("Copyright 2011 by Detox Studios LLC")]
[NodeToolTip("Sets the VSync Count on the current Quality Settings.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://www.uscript.net/docs/index.php?title=Node_Reference_Guide")]

[FriendlyName("Set VSync Count", "Sets the VSync Count on the current Quality Settings.")]
public class uScriptAct_QualitySettingsSetVSyncCount : uScriptLogic
{
   public bool Out { get { return true; } }

   public void In([FriendlyName("Value", "The value to set on this quality setting. The number of VSyncs that should pass between each frame. Use 'Don't Sync' (0) to not wait for VSync. Value must be 0, 1 or 2")] int Value)
   {
      if (Value > 0 && Value < 3)
      {
         QualitySettings.vSyncCount = Value;
      }     
   }
}
#endif