<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Gravity Engine

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine)](https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

  [Documentation](https://gameframex.doc.alianblank.com) | [Quick Start](#quick-start)

  **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## Project Overview

Unity SDK integration guide for [Gravity Engine](https://gravity-engine.com/). For a complete demo, refer to the [GitHub](https://github.com/GravityInfinite/Turbo-Unity-Demo) open source project. The `GravityEngineDemo.cs` script in the demo project provides method call examples.

The **Gravity Engine SDK** is an Android platform SDK that implements code-based event tracking and ad attribution. Currently supported media platforms:

- Toutiao Ocean Engine
- Kuaishou Magnetic Engine
- Tencent Advertising
- Baidu Marketing

> More platforms are being supported. For detailed usage instructions, please refer to the [official user manual](https://doc.gravity-engine.com/#/turbo-integrated/unity/unity-sdk).

## Quick Use (Mini Games)

Enable via menu bar: Tools -> Gravity Engine -> Enable the corresponding macro definition

## Installation

### Via Git URL (Recommended)

1. Open Package Manager in Unity Editor
2. Click the "+" button and select "Add package from git URL"
3. Enter the following URL:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git
   ```

### Via manifest.json

Add the following to your project's `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.gameframex.unity.gravityinfinite.gravity-engine": "https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git"
  }
}
```

### Manual Installation

1. Download the latest release package
2. Extract it to your project's `Packages` directory
3. Unity will automatically recognize and load the package

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for details.

## License

This project is licensed under the MIT License - see [LICENSE.md](LICENSE.md) for details.
