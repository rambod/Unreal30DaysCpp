// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Unreal30DaysCpp : ModuleRules
{
	public Unreal30DaysCpp(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Unreal30DaysCpp",
			"Unreal30DaysCpp/Variant_Horror",
			"Unreal30DaysCpp/Variant_Horror/UI",
			"Unreal30DaysCpp/Variant_Shooter",
			"Unreal30DaysCpp/Variant_Shooter/AI",
			"Unreal30DaysCpp/Variant_Shooter/UI",
			"Unreal30DaysCpp/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
