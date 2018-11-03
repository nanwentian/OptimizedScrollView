﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace UnityEngine.UI.Extension.Tools
{
	/// <summary>Required if building for UWP (WSA), but recommended in all cases: Replace your TouchInputModule(if exists) with this one.</summary>
	public class SmartScrollViewTouchInputModule : StandaloneInputModule, ISmartScrollViewPointerInputModule
    {
		public Dictionary<int, PointerEventData> GetPointerEventData() { return m_PointerData; }
	}
}