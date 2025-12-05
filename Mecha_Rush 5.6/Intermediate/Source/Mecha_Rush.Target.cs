using UnrealBuildTool;

public class Mecha_RushTarget : TargetRules
{
	public Mecha_RushTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Mecha_Rush");
	}
}
