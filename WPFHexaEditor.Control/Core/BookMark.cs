﻿//////////////////////////////////////////////
// Apache 2.0  - 2016-2017
// Author : Derek Tremblay (derektremblay666@gmail.com)
//////////////////////////////////////////////

using System;
using WPFHexaEditor.Core.Bytes;

namespace WPFHexaEditor.Core
{
    /// <summary>
    /// BookMark class
    /// </summary>
    public sealed class BookMark
    {
        public ScrollMarker Marker { get; set; } = ScrollMarker.Nothing;
        public long BytePositionInFile { get; set; } = 0;
        public string Description { get; set; } = string.Empty;

        public BookMark() { }

        public BookMark(string description, long position)
        {
            BytePositionInFile = position;
            Description = description;
        }

        public BookMark(string description, long position, ScrollMarker marker)
        {
            BytePositionInFile = position;
            Description = description;
            Marker = marker;
        }

        /// <summary>
        /// String representation
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"({ByteConverters.LongToHex(BytePositionInFile)}h){Description}";
    }
}