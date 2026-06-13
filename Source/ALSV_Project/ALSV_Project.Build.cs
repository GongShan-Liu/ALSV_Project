// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ALSV_Project : ModuleRules
{
	public ALSV_Project(ReadOnlyTargetRules Target) : base(Target)
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
			"ALSV_Project",
			"ALSV_Project/Variant_Platforming",
			"ALSV_Project/Variant_Platforming/Animation",
			"ALSV_Project/Variant_Combat",
			"ALSV_Project/Variant_Combat/AI",
			"ALSV_Project/Variant_Combat/Animation",
			"ALSV_Project/Variant_Combat/Gameplay",
			"ALSV_Project/Variant_Combat/Interfaces",
			"ALSV_Project/Variant_Combat/UI",
			"ALSV_Project/Variant_SideScrolling",
			"ALSV_Project/Variant_SideScrolling/AI",
			"ALSV_Project/Variant_SideScrolling/Gameplay",
			"ALSV_Project/Variant_SideScrolling/Interfaces",
			"ALSV_Project/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
