﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace UnityEngine.UI.Extension.Tools
{
	/// <summary>
	/// Used if you have your own custom input module. Otherwise, see <see cref="SmartScrollViewStandaloneInputModule"/> and <see cref="SRIATouchInputModule"/>.
	/// Required if building for UWP (WSA), but recommended in all cases: your InputModule should implement this interface and return the "PointerInputModule.m_PointerData" field (like <see cref="SmartScrollViewStandaloneInputModule"/> does)</summary>
	public interface ISmartScrollViewPointerInputModule
    {
		Dictionary<int, PointerEventData> GetPointerEventData();
	}
}