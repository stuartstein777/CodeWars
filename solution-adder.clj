(def languages 
  {"C"            ".c"
   "C++"          ".cpp"
   "C#"           ".cs"
   "JS"           ".js"
   "Typescript"   ".ts"
   "Ruby"         ".rb"
   "Python"       ".py"
   "CoffeeScript" ".coffee"
   "F#"           ".fs"
   "D"            ".d"
   "Java"         ".java"
   "Racket"       ".rkt"
   "Go"           ".go"
   "CommonLisp"   ".lisp"
   "Haskell"      ".hs"
   "Swift"        ".swift"
   "VB"           ".vb"
   "CFML"         ".cfml"
   "Rust"         ".rs"
   "R"            ".r"
   "PHP"          ".php"
   "Scala"        ".scala"
   "Crystal"      ".cr"
   "Prolog"       ".pl"
   "Dart"         ".dart"
   "Elixir"       ".ex"
   "Elm"          ".elm"
   "Julia"        ".jl"
   "Kotlin"       ".kt"
   "Erlang"       ".beam"
   "Groovy"       ".groovy"
   "Lua"          ".lua"
   "Objective-C"  ".m"
   "Nim"          ".nim"
   "Pascal"       ".pas"
   "Purescript"   ".purs"
   "Powershell"   ".ps"
   "Raku"         ".raku"
   "Haxe"         ".hx"
   "OCaml"        ".cma"
   "Reason"       ".rsn"
   "Solidity"     ".sol"})

(defn create-solution [lang]
  (println (str "solution" (languages lang)))
  (spit (str "solution" (languages lang)) ""))

(let [lang (first *command-line-args*)]
  (create-solution lang))

