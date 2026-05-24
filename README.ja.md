<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Gravity Engine

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine)](https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

  [ドキュメント](https://gameframex.doc.alianblank.com) | [クイックスタート](#クイックスタート)

  [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)
</div>

---

## プロジェクト概要

[Gravity Engine](https://gravity-engine.com/) Unity SDK 統合ガイド。完全なデモは [GitHub](https://github.com/GravityInfinite/Turbo-Unity-Demo) オープンソースプロジェクトを参照してください。デモプロジェクトの `GravityEngineDemo.cs` スクリプトに各メソッドの呼び出し例があります。

**Gravity Engine SDK** は、Android プラットフォーム向けにコードベースのイベントトラッキングと広告アトリビューションを実装する SDK です。現在サポートされているメディアプラットフォーム：

- Toutiao Ocean Engine
- Kuaishou Magnetic Engine
- Tencent Advertising
- Baidu Marketing

> より多くのプラットフォームがサポートされる予定です。詳細な使用方法については、[公式ユーザーマニュアル](https://doc.gravity-engine.com/#/turbo-integrated/unity/unity-sdk)をご参照ください。

## クイック使用（ミニゲーム）

メニューバー：Tools -> Gravity Engine -> 対応するマクロ定義を有効にする

## インストール

### Git URL 経由（推奨）

1. Unity エディタで Package Manager を開く
2. "+" ボタンをクリックし "Add package from git URL" を選択
3. 以下の URL を入力：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git
   ```

### manifest.json 経由

プロジェクトの `Packages/manifest.json` に以下を追加：

```json
{
  "dependencies": {
    "com.gameframex.unity.gravityinfinite.gravity-engine": "https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git"
  }
}
```

### 手動インストール

1. 最新のリリースパッケージをダウンロード
2. プロジェクトの `Packages` ディレクトリに展開
3. Unity が自動的にパッケージを認識して読み込みます

## 変更履歴

詳細は [CHANGELOG.md](CHANGELOG.md) をご覧ください。

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE.md](LICENSE.md) をご覧ください。
