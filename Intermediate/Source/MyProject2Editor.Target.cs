using UnrealBuildTool;

public class MyProject2EditorTarget : TargetRules
{
	public MyProject2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyProject2");
	}
}
