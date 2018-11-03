
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extension.Tools.Util.Drawer
{
	public class LabelWithSliderPanel : MonoBehaviour
	{
		public Text labelText, minLabelText, maxLabelText;
		public Slider slider;


		public void Init(string label, string minLabel, string maxLabel)
		{
			labelText.text = label;
			minLabelText.text = minLabel;
			maxLabelText.text = maxLabel;
		}

		internal void Set(float min, float max, float val)
		{
			slider.minValue = min;
			slider.maxValue = max;
			slider.onValueChanged.Invoke(slider.value = val);
		}
	}
}
