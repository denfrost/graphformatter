/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Howaajin. All rights reserved.
 *  Licensed under the MIT License. See License in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace UnrealBuildTool.Rules
{
	using System.IO;

	public class GraphFormatter : ModuleRules
	{
		public GraphFormatter(ReadOnlyTargetRules Target) : base(Target)
		{
			PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

			var EngineDir = Path.GetFullPath(Target.RelativeEnginePath);

			PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
            PublicIncludePaths.Add(ModuleDirectory);

            PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"ApplicationCore",
					"InputCore",
					"Engine",
					"Kismet",
					"UnrealEd",
					"SlateCore",
					"Slate",
					"EditorStyle",
					"GraphEditor",
					"BlueprintGraph",
					"MaterialEditor",
					"AIModule",
					"AIGraph",
					"BehaviorTreeEditor",
				}
			);
		}
	}
}
