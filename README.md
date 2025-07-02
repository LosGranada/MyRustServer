# MyRustServer Version Tracker

This repository holds the automatically maintained `version.json` for MyRustServer.  
It is regularly updated via a custom-built VB.NET application.

## 🔁 Automated Workflow

On each execution, the tool performs the following steps:

- Retrieves the latest version data from:
  - **Steam Rust Server** (Build IDs)
  - **Oxide** (public & staging)
  - **Carbon** (Production, Preview, Edge, etc.)
  - **MyRustServer** (custom values from the GUI)
- Compares the new `version.json` to the current version in this repository
- If changes are detected:
  - Commits the new version.json
  - Generates a detailed commit message showing what has changed
  - Pushes the commit to GitHub via LibGit2Sharp

## 📁 Files

- `version.json`: holds all current version values in structured JSON format
- `README.md`: explains this repository's purpose and behavior

## 🧾 Example Commit Message

```text
Auto-Update: 2025-07-01 20:25:00
Changes:
- Server.public: 18796302 → 18796303
- MyRustServer.beta: 5.0.2 → 5.0.3
