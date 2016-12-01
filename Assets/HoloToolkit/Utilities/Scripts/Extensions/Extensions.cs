﻿//
// Copyright (C) Microsoft. All rights reserved.
//

using UnityEngine;

namespace HoloToolkit.Unity
{
    /// <summary>
    /// A class with general purpose extensions methods.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Returns the absolute duration of the curve from first to last key frame
        /// </summary>
        /// <param name="curve">The animation curve to check duration of.</param>
        /// <returns>Returns 0 if the curve is null or has less than 1 frame, otherwise returns time difference between first and last frame.</returns>
        public static float Duration(this AnimationCurve curve)
        {
            if (curve == null || curve.length <= 1)
            {
                return 0.0f;
            }

            return Mathf.Abs(curve[curve.length - 1].time - curve[0].time);
        }
    }
}