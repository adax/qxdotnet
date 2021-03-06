﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// A basic layout, which supports positioning of child widgets by absolute
    /// left/top coordinates. This layout is very simple but should also
    /// perform best.
    /// 
    /// Features
    /// 
    /// 
    /// Basic positioning using left and top properties
    /// Respects minimum and maximum dimensions without skrinking/growing
    /// Margins for top and left side (including negative ones)
    /// Respects right and bottom margins in the size hint
    /// Auto-sizing
    /// 
    /// 
    /// Item Properties
    /// 
    /// 
    /// left (Integer): The left coordinate in pixel
    /// top (Integer): The top coordinate in pixel
    /// 
    /// 
    /// Details
    /// 
    /// The default location of any widget is zero for both
    /// left and top.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the basic layout.
    /// 
    /// 
    /// var container = new qx.ui.container.Composite(new qx.ui.layout.Basic());
    /// 
    /// // simple positioning
    /// container.add(new qx.ui.core.Widget(), {left: 10, top: 10});
    /// container.add(new qx.ui.core.Widget(), {left: 100, top: 50});
    /// 
    /// 
    /// External Documentation
    /// 
    /// 
    /// Extended documentation and links to demos of this layout in the qooxdoo manual.
    /// </summary>
    public partial class Basic : qxDotNet.UI.Layout.Abstract
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Basic";
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
