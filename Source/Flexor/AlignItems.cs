﻿// <copyright file="AlignItems.cs" company="Derek Chasse">
// Copyright (c) Derek Chasse. All rights reserved.
// </copyright>

namespace Flexor
{
    /// <summary>
    /// Defines how flex-items are laid out along the flex-container's cross axis.
    /// </summary>
    public static class AlignItems
    {
        /// <summary>
        /// The default alignment of <see cref="ItemAxisAlignment.Stretch"/> for items within a flex-container across all CSS media query breakpoints.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Is => new FluentAlignItems();

        /// <summary>
        /// Items are aligned along the start of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Start => new FluentAlignItems(ItemAxisAlignment.Start);

        /// <summary>
        /// Items are aligned along the center of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Center => new FluentAlignItems(ItemAxisAlignment.Center);

        /// <summary>
        /// Items are aligned along the end of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint End => new FluentAlignItems(ItemAxisAlignment.End);

        /// <summary>
        /// Items are stretched along the entirety of the flex-container's cross axis.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Stretch => new FluentAlignItems(ItemAxisAlignment.Stretch);

        /// <summary>
        /// Items are aligned as their baseline is aligned.
        /// </summary>
        public static IFluentAlignItemsOnBreakpoint Baseline => new FluentAlignItems(ItemAxisAlignment.Baseline);
    }
}
