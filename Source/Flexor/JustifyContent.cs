﻿// <copyright file="JustifyContent.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines the alignment of items along a flex-line's main axis.
    /// </summary>
    public static class JustifyContent
    {
        /// <summary>
        /// Content is aligned along the start line of the flex-line's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IJustifyContent Start => new FluentJustifyContent(JustificationOption.Start);

        /// <summary>
        /// Content is centered along the midpoint of the flex-line's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IJustifyContent Center => new FluentJustifyContent(JustificationOption.Center);

        /// <summary>
        /// Content is aligned along the end line of the flex-line's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IJustifyContent End => new FluentJustifyContent(JustificationOption.End);

        /// <summary>
        /// Content is spaced evenly along the flex-line's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// The space between flex-line and adjacent items is half the space between items.
        /// </summary>
        public static IJustifyContent SpaceAround => new FluentJustifyContent(JustificationOption.SpaceAround);

        /// <summary>
        /// Content is spaced evenly along the flex-line's main axis.
        /// Content is rendered this way consistently across all CSS media query breakpoints.
        /// Items touch the flex-line's start and end.
        /// </summary>
        public static IJustifyContent SpaceBetween => new FluentJustifyContent(JustificationOption.SpaceBetween);

        /// <summary>
        /// Flex-items will be rendered and configured with the supplied justufucation option.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="justification">The default justification value.</param>
        /// <returns>The justification configuration.</returns>
        public static IFluentJustifyContentWithValueOnBreakpoint Is(JustificationOption justification) => new FluentJustifyContent().Is(justification);
    }
}
