using UnrealBuildTool;

public class MyProject2ServerTarget : TargetRules
{
	public MyProject2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyProject2");
	}
}
