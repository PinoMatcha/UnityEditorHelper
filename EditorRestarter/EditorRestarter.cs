using UnityEditor;
using UnityEngine;

namespace PMP.EditorHelper {
    /// <summary>
    /// エディタを再起動するクラス
    /// </summary>
    public static class EditorRestarter {

        [MenuItem("File/Restart")]
        private static void RestartEditor() {
            // プロジェクトパス
            string projectPath = Application.dataPath.Remove(Application.dataPath.Length - "/Assets".Length, "/Assets".Length);
            // Unityプロジェクトを開く
            EditorApplication.OpenProject(projectPath);
        }
    }
}