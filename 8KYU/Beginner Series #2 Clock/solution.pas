unit Kata;

interface

function Past(H: Integer; M: Integer; S: Integer): Integer;

implementation

function Past(H: Integer; M: Integer; S: Integer): Integer;
begin
  Result := S * 1000 + M * 60000 + H * 3600000;
end;

end.