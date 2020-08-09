using Rage;

/**
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace NoReticleRPHAutomatic
{
    public static class Entrypoint
    {
        public static void Main()
        {
            Game.DisplayNotification("NoReticle loaded");
            while (true)
            {
                if (Game.LocalPlayer.Character.IsAiming || Game.LocalPlayer.Character.IsDoingDriveby)
                {
                    Rage.Native.NativeFunction.Natives.HIDE_HUD_COMPONENT_THIS_FRAME(14L);
                }
                GameFiber.Yield();
            }
        }

        public static void OnUnload() => Game.DisplayNotification("NoReticle unloaded");
    }
}
