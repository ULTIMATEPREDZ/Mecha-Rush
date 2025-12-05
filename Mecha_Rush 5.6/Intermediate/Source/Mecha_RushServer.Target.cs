using UnrealBuildTool;

public class Mecha_RushServerTarget : TargetRules
{
	public Mecha_RushServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Mecha_Rush");
	}
}
