using UnrealBuildTool;

public class MyProject2ClientTarget : TargetRules
{
	public MyProject2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyProject2");
	}
}
