#if UNITY_WEBGL
using GameFrameX.Editor;
using UnityEditor;

namespace GravityEngine.Editor
{
    /// <summary>
    /// 引力引擎打点脚本宏定义。
    /// </summary>
    public static class GravityEngineScriptingDefineSymbols
    {
        private const string GravityWechatGameModeScriptingDefineSymbol = "GRAVITY_WECHAT_GAME_MODE";
        private const string GravityBytedanceGameModeScriptingDefineSymbol = "GRAVITY_BYTEDANCE_GAME_MODE";
        private const string GravityKuaiShouGameModeScriptingDefineSymbol = "GRAVITY_KUAISHOU_GAME_MODE";

        /// <summary>
        /// 禁用快手小游戏脚本宏定义。
        /// </summary>
        [MenuItem("Tools/Gravity Engine/Disable KuaiShou Game Mode", false, 100)]
        public static void DisableKuaiShouGameMode()
        {
            ScriptingDefineSymbols.RemoveScriptingDefineSymbol(GravityKuaiShouGameModeScriptingDefineSymbol);
        }

        /// <summary>
        /// 开启快手小游戏脚本宏定义。
        /// </summary>
        [MenuItem("Tools/Gravity Engine/Enable KuaiShou Game Mode", false, 101)]
        public static void EnableKuaiShouGameMode()
        {
            ScriptingDefineSymbols.AddScriptingDefineSymbol(GravityKuaiShouGameModeScriptingDefineSymbol);
        }

        /// <summary>
        /// 禁用微信小游戏脚本宏定义。
        /// </summary>
        [MenuItem("Tools/Gravity Engine/Disable Wechat Game Mode", false, 200)]
        public static void DisableWechatGameMode()
        {
            ScriptingDefineSymbols.RemoveScriptingDefineSymbol(GravityWechatGameModeScriptingDefineSymbol);
        }

        /// <summary>
        /// 开启微信小游戏脚本宏定义。
        /// </summary>
        [MenuItem("Tools/Gravity Engine/Enable Wechat Game Mode", false, 201)]
        public static void EnableWechatGameMode()
        {
            ScriptingDefineSymbols.AddScriptingDefineSymbol(GravityWechatGameModeScriptingDefineSymbol);
        }

        /// <summary>
        /// 禁用抖音小游戏脚本宏定义。
        /// </summary>
        [MenuItem("Tools/Gravity Engine/Disable Bytedance Game Mode", false, 303)]
        public static void DisableBytedanceGameMode()
        {
            ScriptingDefineSymbols.RemoveScriptingDefineSymbol(GravityBytedanceGameModeScriptingDefineSymbol);
        }

        /// <summary>
        /// 开启抖音小游戏脚本宏定义。
        /// </summary>
        [MenuItem("Tools/Gravity Engine/Enable Bytedance Game Mode", false, 304)]
        public static void EnableBytedanceGameMode()
        {
            ScriptingDefineSymbols.AddScriptingDefineSymbol(GravityBytedanceGameModeScriptingDefineSymbol);
        }
    }
}
#endif