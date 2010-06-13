﻿/* Copyright (C) 2008-2009, Bit Miracle
 * http://www.bitmiracle.com
 * 
 * Copyright (C) 1994-1996, Thomas G. Lane.
 * This file is part of the Independent JPEG Group's software.
 * For conditions of distribution and use, see the accompanying README file.
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BitMiracle.LibJpeg.Classic
{
    /// <summary>
    /// Known color spaces.
    /// </summary>
    /// <seealso cref="Special color spaces"/>
#if EXPOSE_LIBJPEG
    public
#endif
    enum J_COLOR_SPACE
    {
        /// <summary>
        /// Unspecified color space.
        /// </summary>
        JCS_UNKNOWN,
        /// <summary>
        /// Grayscale
        /// </summary>
        JCS_GRAYSCALE,  /* monochrome */
        /// <summary>
        /// RGB
        /// </summary>
        JCS_RGB,
        /// <summary>
        /// YCbCr (also known as YUV)
        /// </summary>
        JCS_YCbCr,
        /// <summary>
        /// CMYK
        /// </summary>
        JCS_CMYK,
        /// <summary>
        /// YCbCrK
        /// </summary>
        JCS_YCCK
    }
}