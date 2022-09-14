#!/bin/bash
rm README.md
emacs codewars.org --batch --quick --eval "(require 'ox-md)" --eval "(org-export-to-file 'md \"README.md\")"
bb fixreadme.clj
git add -A
git commit -m "added solutions"
git push -u origin master
