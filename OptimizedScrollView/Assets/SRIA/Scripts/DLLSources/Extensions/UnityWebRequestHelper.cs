﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityEngine.UI.Extension
{
#if UNITY_5_2 || UNITY_5_3_OR_NEWER
    public static class UnityWebRequestHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>the size in bytes given by Content-Length header. -1 if N/A</returns>
#if UNITY_5_2 || UNITY_5_3
        public static long GetContentLengthFromHeader(this UnityEngine.Experimental.Networking.UnityWebRequest www)
#else
        public static long GetContentLengthFromHeader(this UnityEngine.Networking.UnityWebRequest www)
#endif
        {
            string length;
            if ((length = www.GetResponseHeader("Content-Length")) != null)
            {
                long lengthLong;
                if (long.TryParse(length, out lengthLong))
                    return lengthLong;
            }

            return -1;
        }

    }
#endif
}