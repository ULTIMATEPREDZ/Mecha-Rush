using UnrealBuildTool;

public class Mecha_RushClientTarget : TargetRules
{
	public Mecha_RushClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Mecha_Rush");
	}
}
