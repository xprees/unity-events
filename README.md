# Unity Event System based on ScriptableObjects

[![NPM Version](https://img.shields.io/npm/v/cz.xprees.events)](https://www.npmjs.com/package/cz.xprees.events)

This package provides a simple and powerful event system for Unity using ScriptableObject EventChannels. It allows you to create and receive events
across different parts of your game without tightly coupling components and even in multi-scene environment.

## Usage

To use in Unity clone with following git url to package
manager.

## Installation

Install the package using one of the following methods:

### Git URL

Install in the package manager using the following Git URL

```git
https://github.com/xprees/Unity-Events.git
```

### Scoped NPM Registry

Install the package using npm scoped registry in `Project Settings > Package Manager > Scoped Registries` (For more details
see [Unity Docs - Use a scoped registry in your project](https://docs.unity3d.com/6000.2/Documentation/Manual/upm-scoped-use.html))

`Packages/manifest.json`

```json
{
    "scopedRegistries": [
        {
            "name": "NPM - xprees",
            "url": "https://registry.npmjs.org",
            "scopes": [
                "cz.xprees",
                "com.dbrizov.naughtyattributes"
            ]
        }
    ]
}
```

Then simply install the package using the Unity Package Manager using the NPM - xprees scope or by the package name `cz.xprees.events`.

## Event Logging

The package will automatically enable event-logging capabilities when detects the Script Define Symbol `XPREES_EVENT_LOGGING` from
[`cz.xprees.event-logging`](https://www.npmjs.com/package/cz.xprees.event-logging) package.