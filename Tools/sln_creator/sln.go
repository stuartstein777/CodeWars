package main

import (
	"fmt"
	"os"

	"github.com/atotto/clipboard"
)

/*
Haskell: .hs
OCaml: .ml
Crystal: .cr
Racket: .rkt
Scala: .scala
Elixir: .ex (and .exs for script files)
Groovy: .groovy
Dart: .dart
Objective-C: .m (implementation) and .h (header)
CoffeeScript: .coffee
Julia: .jl
Swift: .swift
Haxe: .hx
Reason: .re (implementation) and .rei (interface)
Prolog: .pl
C#: .cs
C++: .cpp
C: .c
Rust: .rs
Go: .go
Java: .java
JavaScript: .js
TypeScript: .ts
PHP: .php
Python: .py
Ruby: .rb
Kotlin: .kt
Lua: .lua
Perl: .pl
PHP: .php
R: .r
Shell: .sh
Powershell: .ps1
NASM: .asm
Nim: .nim
D: .d
Fortran: .f90
Erlang: .erl
Elm: .elm
Clojure: .clj
Common Lisp: .lisp
Scheme: .scm
Pascal: .pas
Raku: .raku
Idris: .idr
Forth: .fs
Factor: .factor
COBOL: .cob
Agda: .agda
Solidity: .sol
Purescript: .purs
Swift: .swift
VB: .vb
CFML: .cfm
*/

var fileTypes = map[string]string{
	"haskell":    "hs",
	"ocaml":      "ml",
	"crystal":    "cr",
	"racket":     "rkt",
	"scala":      "scala",
	"elixir":     "ex",
	"groovy":     "groovy",
	"dart":       "dart",
	"objc":       "m",
	"coffee":     "coffee",
	"julia":      "jl",
	"swift":      "swift",
	"haxe":       "hx",
	"reason":     "re",
	"prolog":     "pl",
	"c#":         "cs",
	"f#":         "fs",
	"c++":        "cpp",
	"c":          "c",
	"rust":       "rs",
	"go":         "go",
	"java":       "java",
	"js":         "js",
	"typescript": "ts",
	"php":        "php",
	"python":     "py",
	"ruby":       "rb",
	"kotlin":     "kt",
	"lua":        "lua",
	"perl":       "pl",
	"r":          "r",
	"shell":      "sh",
	"powershell": "ps1",
	"nasm":       "asm",
	"nim":        "nim",
	"d":          "d",
	"fortran":    "f90",
	"erlang":     "erl",
	"elm":        "elm",
	"clojure":    "clj",
	"lisp":       "lisp",
	"scheme":     "scm",
	"pascal":     "pas",
	"raku":       "raku",
	"idris":      "idr",
	"forth":      "fs",
	"factor":     "factor",
	"cobol":      "cob",
	"agda":       "agda",
	"solidity":   "sol",
	"purescript": "purs",
	"vb":         "vb",
	"cfml":       "cfm",
}

func fileName(language string) string {
	fileExtension := fileTypes[language]
	return "solution." + fileExtension
}

func main() {
	slnType := os.Args[1:]

	fileName := fileName(slnType[0])

	//create solution.fileExtension
	file, err := os.Create(fileName)

	if err != nil {
		fmt.Println("Couldn't create file " + fileName)
		fmt.Println(err)
		os.Exit(-1)
	}

	defer file.Close()

	clipboardText, err := clipboard.ReadAll()

	if err != nil {
		fmt.Println("Couldn't copy text from clipboard")
		fmt.Println(err)

		file.Close()
		os.Exit(-2)
	}

	err = os.WriteFile(fileName, []byte(clipboardText), 0644)
	if err != nil {
		fmt.Println("Error writing file:", err)
		return
	}

	fmt.Println("Created file " + fileName + " and saved clipboard text")
}
