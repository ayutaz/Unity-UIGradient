using UnityEditor;

public class ExportUnityPackage
{
    [MenuItem("UIGradients/Export Unity Package")]
    private static void ExportPackage()
    {
        AssetDatabase.ExportPackage(
            new string[]
            {
                "Assets/UIGradients",
            },
            "UIGradients.unitypackage",
            ExportPackageOptions.Recurse |
            ExportPackageOptions.IncludeDependencies
        );
    }
}