using Game;
using MessyCore;

namespace MessyTooltips.Systems
{
    public partial class TooltipOverlaySystem : GameSystemBase
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            global::MessyCore.Mod.Log.Info("TooltipOverlaySystem ready");
            global::MessyCore.Mod.Capabilities.Set("tooltips.module", "ready");
            global::MessyCore.Mod.Capabilities.Set("tooltips.diagnostics", global::MessyCore.Mod.Settings.ShowDiagnostics ? "enabled" : "disabled");
            global::MessyCore.Mod.Diagnostics.SetState("tooltips.module", "ready");
        }

        protected override void OnUpdate()
        {
            if (!global::MessyCore.Mod.Settings.TooltipModuleEnabled)
            {
                global::MessyCore.Mod.Diagnostics.SetState("tooltips.runtime", "disabled");
                return;
            }
            global::MessyCore.Mod.Capabilities.Set("tooltips.runtime", "active");
            global::MessyCore.Mod.Diagnostics.SetState("tooltips.runtime", "active");
        }
    }
}
