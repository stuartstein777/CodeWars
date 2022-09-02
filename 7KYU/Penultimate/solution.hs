module Penultimate where

penultimate :: [a] -> a
penultimate (x : _ : []) = x
penultimate (_ : xs) = penultimate xs