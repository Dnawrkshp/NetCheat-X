﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCheatX.Core.Interfaces
{
    /// <summary>
    /// Add on plugin interface
    /// </summary>
    public interface IAddOn : IPluginBase
    {
        /// <summary>
        /// List of all supported platforms in abbreviated format (PS3, PC, iOS, Android)
        /// Leave null if all are supported
        /// </summary>
        string[] SupportedPlatforms { get; }

        /// <summary>
        /// Initializes a new XForm identified by param uniqueName
        /// </summary>
        /// <param name="xForm">Uninitialized XForm</param>
        /// <param name="uniqueName">XForm identifier</param>
        /// <returns>False if failed</returns>
        bool InitializeXForm(out NetCheatX.Core.UI.XForm xForm, string uniqueName);
    }
}