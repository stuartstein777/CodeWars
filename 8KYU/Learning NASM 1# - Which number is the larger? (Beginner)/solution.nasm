section .text
global whichIsLarger
whichIsLarger:            ; int whichIsLarger(int a, int b)
  cmp rdi, rsi 
  jl lessThan
  jg greaterThan
  ret
  
lessThan:
  mov eax, esi
  ret
  
greaterThan:
  mov eax, edi
  ret
