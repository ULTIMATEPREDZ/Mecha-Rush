using UnrealBuildTool;

public class Mecha_RushEditorTarget : TargetRules
{
	public Mecha_RushEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Mecha_Rush");
	}
}
