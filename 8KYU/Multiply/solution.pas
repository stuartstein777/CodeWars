unit BugFixMultiply;

{$mode objfpc}{$H+}

interface

function Multiply(const A: Integer; const B: Integer): Integer;

implementation

function Multiply(const A: Integer; const B: Integer): Integer;
begin
  Result := A * B;
end;

end.