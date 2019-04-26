﻿// <copyright file="AlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items are laid out along the flex-line's cross axis.
    /// </summary>
    public static class AlignItems
    {
        /// <summary>
        /// Items are aligned along the start of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignItems Start => new FluentAlignItems().Is(AlignItemsOption.Start).OnAll();

        /// <summary>
        /// Items are aligned along the center of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignItems Center => new FluentAlignItems().Is(AlignItemsOption.Center).OnAll();

        /// <summary>
        /// Items are aligned along the end of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignItems End => new FluentAlignItems().Is(AlignItemsOption.End).OnAll();

        /// <summary>
        /// Items are stretched along the entirety of the flex-line's cross axis.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignItems Stretch => new FluentAlignItems().Is(AlignItemsOption.Stretch).OnAll();

        /// <summary>
        /// Items are aligned as their baseline is aligned.
        /// Items are rendered this way consistently across all CSS media query breakpoints.
        /// </summary>
        public static IAlignItems Baseline => new FluentAlignItems().Is(AlignItemsOption.Baseline).OnAll();

        /// <summary>
        /// Flex-items are rendered by default according to the supplied item alignment.
        /// Rendering is configurable based on CSS media query breakpoints.
        /// </summary>
        /// <param name="value">The default item alignment.</param>
        /// <returns>The item alignment configuration.</returns>
        public static IFluentAlignItemsWithValueOnBreakpoint Is(AlignItemsOption value) => new FluentAlignItems().Is(value);
    }
}
