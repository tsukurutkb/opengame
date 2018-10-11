using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class Constants {
#if RELEASE
    public const string Environment = "本番環境";
    public const string Host = "honban.domain.come";
    public const bool IsDevelop = false;
#elif DEVELOP
    public const string Environment = "開発環境";
    public const string Host = "kaihatsu.domain.come";
    public const bool IsDevelop = true;
#endif
}
public class ChangeEnvironment {

    // 開発環境に切り替え
    [MenuItem("Environment/Develop")]
    static void Develop(){
        var symbols = GetSymbols();
        symbols.Add("DEVELOP");
        symbols.Remove("RELEASE");
        SetSymbols(symbols);
    }

    // 本番環境に切り替え
    [MenuItem("Environment/Release")]
    static void Release(){
        var symbols = GetSymbols();
        symbols.Add("RELEASE");
        symbols.Remove("DEVELOP");
        SetSymbols(symbols);
    }

    // 設定されているシンボル定義を取得する
    static List<string> GetSymbols(){
        return PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup).Split(';').ToList();
    }

    // シンボル定義をセットする
    static void SetSymbols(List<string> symbols){
        var symbolStr = string.Empty;
        symbols.ForEach(s => symbolStr += s + ";");
        PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, symbolStr);
    }
}
