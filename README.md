# MyRustServerHeal

MyRustServerHeal is a lightweight and reliable Oxide/uMod plugin designed to work seamlessly with MyRustServer.  
It allows external systems to remotely heal and fully restore Rust players by executing a single command.

This plugin is intended as an integration component for automated server management, moderation tools, and external admin panels.

---

## Features

When executed, the plugin fully restores the targeted player:

- Health (set to maximum)
- Hydration (maximum)
- Calories (maximum)
- Bleeding removed
- Radiation poison removed
- Radiation level reset
- Poison removed
- Oxygen normalized
- Body temperature reset
- Wetness removed

All changes are applied instantly and synchronized with the client.

---

## Command

```
mrsheal <SteamID>
```

### Description

Heals and fully restores the specified online player using their SteamID.

### Example

```
mrsheal 76561198000000000
```

---

## Intended Usage

This plugin is designed to be triggered remotely by MyRustServer, for example:

- Admin actions from an external UI
- Automated recovery or moderation tasks
- Remote support and player management

It can also be executed manually via server console or chat if required.

---

## Requirements

- Rust Dedicated Server
- Oxide/uMod installed
- Uses Covalence API (Oxide.Core.Libraries.Covalence)

---

## Installation

1. Copy MyRustServerHeal.cs into your server’s oxide/plugins directory.
2. Reload the plugin or restart the server:
   ```
   oxide.reload MyRustServerHeal
   ```
3. The command is now available.

---

## Notes

- The target player must be online.
- No permission checks are enforced by default.
- Permission handling is expected to be managed externally (e.g. via MyRustServer).

---

## Author

LosGranada

---

## License

MIT License

Copyright (c) 2025 LosGranada

Permission is hereby granted, free of charge, to any person obtaining a copy  
of this software and associated documentation files (the "Software"), to deal  
in the Software without restriction, including without limitation the rights  
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell  
copies of the Software, and to permit persons to whom the Software is  
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all  
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR  
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,  
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE  
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER  
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,  
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE  
SOFTWARE.
