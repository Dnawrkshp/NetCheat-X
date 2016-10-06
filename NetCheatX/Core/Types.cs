﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCheatX.Core
{
    /// <summary>
    /// Contains relevant data types and delegates
    /// </summary>
    public static class Types
    {
        /// <summary>
        /// CPU Endianess
        /// </summary>
        public enum Endian
        {
            ///<summary>Little Endian</summary>
            LittleEndian,
            ///<summary>Big Endian</summary>
            BigEndian
        }

        /// <summary>
        /// Process State
        /// </summary>
        public enum ProcessState
        {
            ///<summary>The process is actively running</summary>
            Running,
            ///<summary>The process is paused</summary>
            Paused,
            ///<summary>The process is terminated</summary>
            Killed
        }

        /// <summary>
        /// Search Mode
        /// </summary>
        public enum SearchMode
        {
            ///<summary>An ISearchMethod that can only be used for the first scan</summary>
            First,
            ///<summary>An ISearchMethod that can only be used after the first scan</summary>
            Next,
            ///<summary>An ISearchMethod that can be used for both the first and later scans</summary>
            Both
        }

        /// <summary>
        /// Search parameter
        /// </summary>
        public struct SearchParam
        {
            ///<summary>Name of parameter</summary>
            public string name;
            ///<summary>Type of parameter. Ignore if process is set true</summary>
            public Type type;
            ///<summary>If the parameter needs to be processed by an ISearchType first set this true. It wll be passed to your method as a byte array</summary>
            public bool process;
        }

        /// <summary>
        /// Memory range
        /// </summary>
        public struct MemoryRange
        {
            ///<summary>Start of memory range</summary>
            public ulong start;
            ///<summary>Stop of memory range</summary>
            public ulong stop;
        }

        /// <summary>
        /// Callback function blueprint for plugin menu items
        /// </summary>
        /// <param name="comHost">UI application making call</param>
        /// <returns></returns>
        public delegate bool MenuItemCallback(ICommunicatorHost comHost);

    }
}