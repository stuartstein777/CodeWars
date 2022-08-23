unit Kata;

{$mode objfpc}{$H+}

interface

function RowSumOddNumbers(const N: Integer): Integer;

implementation

function RowSumOddNumbers(const N: Integer): Integer;
begin
  Result := N * N * N; 
  
end;

end.