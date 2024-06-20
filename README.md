## HOMEPAGE

# 引力引擎 Unity SDK 接入指南

本文档为**Unity**接入 [引力引擎](https://gravity-engine.com/)的技术接入方案，具体 Demo
请参考[GitHub](https://github.com/GravityInfinite/Turbo-Unity-Demo)开源项目，Demo 工程中可以参考 `GravityEngineDemo.cs` 脚本中对每一个方法的调用示例。

**引力引擎SDK** 是为Android平台实现的代码埋点+买量归因的工具 SDK，目前 SDK 的兼容性如下：

支持媒体

- 头条巨量引擎
- 快手磁力引擎
- 腾讯广告
- 百度营销

> 更多平台正在支持中，详细的使用说明，请参考我们的[官方使用手册](https://doc.gravity-engine.com/#/turbo-integrated/unity/unity-sdk)。

# 快捷使用(小游戏)

菜单栏 Tools->Gravity Engine->开启对应宏定义启用

# 使用方式(任选其一)

1. 直接在 `manifest.json` 的文件中的 `dependencies` 节点下添加以下内容
   ```json
      {"com.gameframex.unity.gameanalytics": "https://github.com/AlianBlank/com.gameframex.unity.gameanalytics.git"}
    ```
2. 在Unity 的`Packages Manager` 中使用`Git URL` 的方式添加库,地址为：https://github.com/AlianBlank/com.gameframex.unity.gameanalytics.git

3. 直接下载仓库放置到Unity 项目的`Packages` 目录下。会自动加载识别