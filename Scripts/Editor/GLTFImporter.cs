using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

namespace loomai.gltf.Editor {
	[ScriptedImporter(1, "gltf")]
	public class GLTFImporter : ScriptedImporter {

		public ImportSettings importSettings;

		public override void OnImportAsset(AssetImportContext ctx) {
			// Load asset
			GLTFAnimation.ImportResult[] animations;
			if (importSettings == null) importSettings = new ImportSettings();
			GameObject root = Importer.LoadFromFile(ctx.assetPath, importSettings, out animations, Format.GLTF);
			// Save asset
			GLTFAssetUtility.SaveToAsset(root, animations, ctx);
		}
	}
}