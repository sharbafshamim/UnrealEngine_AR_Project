using UnrealBuildTool;

public class MyProject2Target : TargetRules
{
	public MyProject2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject2");
	}
}
