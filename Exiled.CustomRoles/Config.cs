// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.CustomRoles
{
    using System.ComponentModel;

    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using Exiled.CustomRoles.API.Features;

    /// <summary>
    /// The plugin's config.
    /// </summary>
    public class Config : IConfig
    {
        /// <inheritdoc/>
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug messages should be printed to the console.
        /// </summary>
        /// <returns><see cref="bool"/>.</returns>
        [Description("Whether or not debug messages should be shown.")]
        public bool Debug { get; set; } = false;

        /// <summary>
        /// Gets the hint that is shown when someone gets a <see cref="CustomRole"/>.
        /// </summary>
        [Description("The hint that is shown when someone gets a custom role.")]
        public Broadcast GotRoleHint { get; private set; } = new("You have spawned as a {0}\n{1}", 6);

        /// <summary>
        /// Gets the hint that is shown when someone used a <see cref="CustomAbility"/>.
        /// </summary>
        [Description("The hint that is shown when someone used a custom ability.")]
        public Broadcast UsedAbilityHint { get; private set; } = new("Ability {0} has been activated.\n{1}", 5);

        /// <summary>
        /// Gets or sets a value indicating whether keypress ability activations can be used on the server.
        /// </summary>
        [Description("Whether or not Keypress ability activations will work on the server.")]
        public bool UseKeypressActivation { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether abilities that are not the keypress primary can still be activated.
        /// </summary>
        [Description("Whether or not abilities that are not selected as the current keypress ability can still be activated.")]
        public bool ActivateOnlySelected { get; set; } = true;
    }
}