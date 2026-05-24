<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Gravity Engine

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine)](https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

  [文档](https://gameframex.doc.alianblank.com) | [快速开始](#快速开始)

  [English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## 项目简介

[引力引擎](https://gravity-engine.com/) Unity SDK 接入指南。完整 Demo 请参考 [GitHub](https://github.com/GravityInfinite/Turbo-Unity-Demo) 开源项目，Demo 工程中可以参考 `GravityEngineDemo.cs` 脚本中对每一个方法的调用示例。

**引力引擎SDK** 是为 Android 平台实现的代码埋点+买量归因的工具 SDK，目前 SDK 的兼容性如下：

支持媒体

- 头条巨量引擎
- 快手磁力引擎
- 腾讯广告
- 百度营销

> 更多平台正在支持中，详细的使用说明，请参考我们的[官方使用手册](https://doc.gravity-engine.com/#/turbo-integrated/unity/unity-sdk)。

## 快捷使用（小游戏）

菜单栏 Tools->Gravity Engine->开启对应宏定义启用

## 安装

### 通过 Git URL 安装（推荐）

1. 在 Unity 编辑器中打开 Package Manager
2. 点击 "+" 按钮选择 "Add package from git URL"
3. 输入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git
   ```

### 通过 manifest.json 安装

在项目的 `Packages/manifest.json` 文件中添加：

```json
{
  "dependencies": {
    "com.gameframex.unity.gravityinfinite.gravity-engine": "https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git"
  }
}
```

### 手动安装

1. 下载最新版本发布包
2. 解压到项目的 `Packages` 目录下
3. Unity 会自动识别并加载包

## 更新日志

详见 [CHANGELOG.md](CHANGELOG.md)。

## 开源协议

本项目基于 MIT 协议开源，详见 [LICENSE.md](LICENSE.md)。
