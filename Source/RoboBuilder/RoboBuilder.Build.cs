// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RoboBuilder : ModuleRules
{
	public RoboBuilder(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
