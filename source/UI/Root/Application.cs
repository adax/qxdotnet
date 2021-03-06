﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Root
{
    /// <summary>
    /// This is the root widget for qooxdoo applications with an
    /// "application" like behaviour. The widget will span the whole viewport
    /// and the document body will have no scrollbars.
    /// 
    /// The root widget does not support paddings and decorators with insets.
    /// 
    /// If you want to enhance HTML pages with qooxdoo widgets please use
    /// {@link qx.ui.root.Page} eventually in combination with
    /// {@link qx.ui.root.Inline} widgets.
    /// 
    /// This class uses a {@link qx.ui.layout.Canvas} as fixed layout. The layout
    /// cannot be changed.
    /// 
    /// </summary>
    public partial class Application : qxDotNet.UI.Root.Abstract
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.root.Application";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
