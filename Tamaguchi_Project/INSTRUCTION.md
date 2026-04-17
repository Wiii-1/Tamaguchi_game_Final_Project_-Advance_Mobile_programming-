# Instructions for Groupmates

Welcome to the `Tamaguchi_game_Final_Project_-Advance_Mobile_programming-` repo. Follow these steps to collaborate safely without breaking `main`.

## Branch Naming Convention

Always use this format:

`dev/YourName`

Replace `YourName` with your actual name.

Examples:

- `dev/wesley`
- `dev/john`
- `dev/maria`

This keeps branches organized and clearly identifies ownership.

## 1. Clone the Repo (First Time Only)

```bash
git clone https://github.com/yourusername/Tamaguchi_game_Final_Project_-Advance_Mobile_programming-.git
cd Tamaguchi_game_Final_Project_-Advance_Mobile_programming-
git lfs install  # Required for .fbx/.blend assets
```

## 2. Create Your Personal Branch

Never work on `main` directly.

```bash
# Ensure you're on main and up-to-date first
git checkout main
git pull origin main

# Create and switch to your branch
git checkout -b dev/YourName
```

Example:

```bash
git checkout -b dev/wesley
```

## 3. Make Changes and Commit

```bash
# Edit Unity files, Blender assets, etc.
git add .
git commit -m "feat: add player movement controller"
git push origin dev/YourName
```

## 4. Stay Updated (Pull from Main)

Before starting work each session:

```bash
# Switch to main
git checkout main

# Pull latest changes
git pull origin main

# Switch back to your branch
git checkout dev/YourName

# Merge main into your branch (keeps you current)
git merge main
```

## Never Do This

```text
git push origin main  # FORBIDDEN - will be rejected
git commit -m "..." --main  # Wrong usage
```

`main` is protected. Merge to `main` only through Pull Requests after review.

## 5. Create a Pull Request (When Ready)

1. Go to GitHub repo -> `Pull requests` -> `New pull request`.
2. Set `Base: main` and `Compare: dev/YourName`.
3. Add a description and click `Create pull request`.

## Quick Reference Commands

```bash
# Daily workflow
git checkout main && git pull origin main  # Update
git checkout dev/YourName                  # Your branch
# Make changes -> git add . -> git commit -m "" -> git push

# Check status
git status
git branch -a  # See all branches
```

## Unity-Specific Notes

- Open `Tamaguchi_Project/` folder in Unity Hub.
- `Library/` and `Temp/` folders auto-regenerate (ignored by `.gitignore`).
- Large `.fbx`/`.blend` files use Git LFS (`git lfs install` required).

Questions? Ask in issues or ping `@wii` (repo owner).