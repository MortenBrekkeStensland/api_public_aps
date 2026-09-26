# Agent Notes

## Worktree Housekeeping

- Scope: this cleanup applies only to worktrees and local branches the current agent created for its own task. Do not remove, prune, or delete other worktrees or branches, including older or legacy ones, those created by other agents or sessions, and those of other developers, even when they look stale or merged. Someone may still be working on them. Report them instead, and act only when the user explicitly asks.
- Treat Git worktrees as temporary task checkouts; the branch holds the work. The primary checkout is permanent.
- When your own worktree's task is complete, confirm it has no uncommitted changes, untracked files, or stashes, and that its commits are merged into the working branch or pushed. Then remove it with `git worktree remove <path>`. Use `git worktree prune` only to clear records of worktrees whose folders are already gone.
- Delete your own task branch with `git branch -d` once it is merged. For a local-only branch whose changes were ported rather than merged (for example cherry-picked in part), first confirm every intended change is on the working branch, then use `git branch -D`. Never delete remote branches unless the user asks.
- If you are unsure who created a worktree or branch, or whether it is still in use, leave it in place and mention it in the final handoff.
