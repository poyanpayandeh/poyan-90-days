Initial Setup:
- git config --global user.name "name"
- git config --global user.email "email"
- git config --global init.defaultBranch main

Create a new repo:
- mkdir project-name
- cd project name
- git init

Basic Workflow:
  Add a file:
  - git add filename
  
  Stage everything:
  - git add.

  Commit:
  - git commit -m "Commit-message"

  See status:
  - git status

  See history:
  - git log

Branching:
  Create new branch:
  - git checkout -b "branch-name"

  Switch branches:
  - get checkout main

  List all branches:
  - git branch

  Delete a branch:
  - git branch -d "branch-name"

Merging:
- git merge "branch-name"

Verify repo connection:
- git remote -v 

Pushing:
  First Push:
  - git-push -u origin main
  
   Push:
   - git push

   Push another branch:
   - git push -u origin "branch-name"

Pulling:
  Safe pull with rebase:
  - git pull --rebase

  Pull specific branch:
  - git pull --rebase origin "branch-name"

