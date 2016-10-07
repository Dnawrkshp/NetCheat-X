﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NetCheatX.Core
{
    /// <summary>
    /// UI application communicator interface
    /// </summary>
    public interface ICommunicatorHost
    {
        /// <summary>
        /// Register a function under the Platform drop down
        /// </summary>
        /// <param name="com">ICommunicator calling function</param>
        /// <param name="path">Drop down path. Ex: "Extra/Temperature"</param>
        /// <param name="description">Information about function. Displayed in a ToolTip</param>
        /// <param name="callback">Function called when drop down item clicked</param>
        /// <returns>True if succeeded. False if invalid path</returns>
        bool RegisterItem(ICommunicator com, string path, string description, Types.CommunicatorMenuItemCallback callback);

        /// <summary>
        /// Register a function on the toolbar menu
        /// </summary>
        /// <param name="com">ICommunicator calling function</param>
        /// <param name="icon">Image displayed</param>
        /// <param name="description">Information about function. Displayed in a ToolTip</param>
        /// <param name="callback">Function called when drop down item clicked</param>
        /// <returns>True if succeeded. False if invalid image</returns>
        bool RegisterItem(ICommunicator com, Image icon, string description, Types.CommunicatorMenuItemCallback callback);

        /// <summary>
        /// Add a new MDI child form to the UI.
        /// </summary>
        /// <param name="com">ICommunicator calling function</param>
        /// <param name="uniqueName">Unique name of form. Used when returning to a saved user layout</param>
        /// <param name="description">Information about window. Displayed in a ToolTip</param>
        /// <param name="callback">Function called when drop down item clicked</param>
        /// <returns>True if succeeded. False if invalid uniqueName</returns>
        bool RegisterWindow(ICommunicator com, string uniqueName, string description, Types.CommunicatorMenuWindowCallback callback);
    }
}
