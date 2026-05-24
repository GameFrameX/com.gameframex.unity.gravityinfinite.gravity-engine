<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX Gravity Engine

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine)](https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

  [문서](https://gameframex.doc.alianblank.com) | [빠른 시작](#빠른-시작)

  [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**
</div>

---

## 프로젝트 개요

[Gravity Engine](https://gravity-engine.com/) Unity SDK 통합 가이드. 전체 데모는 [GitHub](https://github.com/GravityInfinite/Turbo-Unity-Demo) 오픈 소스 프로젝트를 참조하세요. 데모 프로젝트의 `GravityEngineDemo.cs` 스크립트에서 각 메서드의 호출 예시를 확인할 수 있습니다.

**Gravity Engine SDK**는 Android 플랫폼용 코드 기반 이벤트 추적 및 광고 어트리뷰션을 구현한 SDK입니다. 현재 지원되는 미디어 플랫폼:

- Toutiao Ocean Engine
- Kuaishou Magnetic Engine
- Tencent Advertising
- Baidu Marketing

> 더 많은 플랫폼이 지원될 예정입니다. 자세한 사용 방법은 [공식 사용자 매뉴얼](https://doc.gravity-engine.com/#/turbo-integrated/unity/unity-sdk)을 참조하세요.

## 빠른 사용 (미니게임)

메뉴 바: Tools -> Gravity Engine -> 해당 매크로 정의 활성화

## 설치

### Git URL을 통해 설치 (권장)

1. Unity 에디터에서 Package Manager 열기
2. "+" 버튼을 클릭하고 "Add package from git URL" 선택
3. 다음 URL 입력:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git
   ```

### manifest.json을 통해 설치

프로젝트의 `Packages/manifest.json`에 다음을 추가:

```json
{
  "dependencies": {
    "com.gameframex.unity.gravityinfinite.gravity-engine": "https://github.com/GameFrameX/com.gameframex.unity.gravityinfinite.gravity-engine.git"
  }
}
```

### 수동 설치

1. 최신 릴리스 패키지 다운로드
2. 프로젝트의 `Packages` 디렉토리에 압축 해제
3. Unity가 자동으로 패키지를 인식하고 로드합니다

## 변경 로그

자세한 내용은 [CHANGELOG.md](CHANGELOG.md)를 참조하세요.

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE.md](LICENSE.md)를 참조하세요.
