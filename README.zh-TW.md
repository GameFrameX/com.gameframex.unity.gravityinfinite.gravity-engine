<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Gravity Engine

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine)](https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

  [文檔](https://gameframex.doc.alianblank.com) | [快速開始](#快速開始)

  [English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## 項目簡介

[引力引擎](https://gravity-engine.com/) Unity SDK 整合指南。完整 Demo 請參考 [GitHub](https://github.com/GravityInfinite/Turbo-Unity-Demo) 開源專案，Demo 工程中可以參考 `GravityEngineDemo.cs` 指令碼中對每個方法的呼叫範例。

**引力引擎SDK** 是為 Android 平台實現的程式碼埋點+買量歸因的工具 SDK，目前 SDK 的相容性如下：

支援媒體

- 頭條巨量引擎
- 快手磁力引擎
- 騰訊廣告
- 百度行銷

> 更多平台正在支援中，詳細的使用說明，請參考我們的[官方使用手冊](https://doc.gravity-engine.com/#/turbo-integrated/unity/unity-sdk)。

## 快捷使用（小遊戲）

選單列 Tools->Gravity Engine->開啟對應巨集定義啟用

## 安裝

### 透過 Git URL 安裝（推薦）

1. 在 Unity 編輯器中開啟 Package Manager
2. 點擊 "+" 按鈕選擇 "Add package from git URL"
3. 輸入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git
   ```

### 透過 manifest.json 安裝

在專案的 `Packages/manifest.json` 檔案中新增：

```json
{
  "dependencies": {
    "com.gameframex.unity.gravityinfinite.gravity-engine": "https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git"
  }
}
```

### 手動安裝

1. 下載最新版本發佈包
2. 解壓縮到專案的 `Packages` 目錄下
3. Unity 會自動辨識並載入包

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。

## 開源協議

本專案基於 MIT 協議開源，詳見 [LICENSE.md](LICENSE.md)。
