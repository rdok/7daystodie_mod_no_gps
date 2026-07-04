# Agent instructions

This repository is one of the 7 Days to Die mods managed by the **7dtd-Modkit**. Before doing any
work here, **read the shared instructions in [`../AGENTS.md`](../AGENTS.md)** (the modkit root) —
they are the source of truth and override local habits.

They cover:
- the dev loop (build Debug, `../bin/launch.ps1`, verify in `Player.log`),
- the release flow, `.env`, and dev-deployment cleanup,
- the local-first unit-test policy,
- and — for any C# change — the rule that **Harmony patches are designed from the local Harmony
  docs (`C:\Code\harmony-docs`) as the bible: read the relevant article first, design event-driven,
  never guess the API or poll state per-frame.** Set up / refresh the docs with
  `../bin/update-harmony-docs.ps1` (it reports the game's exact HarmonyX version).
