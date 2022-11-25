﻿using AdofaiTweaks.Core;

namespace AdofaiTweaks.Tweaks.Miscellaneous
{
    /// <summary>
    /// Settings for the Miscellaneous tweak.
    /// </summary>
    public class MiscellaneousSettings : TweakSettings
    {
        /// <summary>
        /// Disables the screen flip in the "Glitch" filter.
        /// </summary>
        public bool DisableGlitchFlip { get; set; }

        /// <summary>
        /// Disables editor zoom in/out when in gameplay.
        /// </summary>
        public bool DisableEditorZoom { get; set; }
    }
}
