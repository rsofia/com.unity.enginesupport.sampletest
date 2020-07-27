using System.IO;
using UnityEditor;

public class ImportPackage : Editor
{
    [MenuItem("Tools/Import .unitypackage directly from Package")]
    private static void ImportPackageDirectly()
    {
        string packageFullPath = Path.GetFullPath("Packages/com.unity.enginesupport.sampletest/resource/SomePackage.unitypackage");
        AssetDatabase.ImportPackage(packageFullPath, true);
    }
}
