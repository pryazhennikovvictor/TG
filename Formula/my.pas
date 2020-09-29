unit my;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;
type
  Calculation = record
    A, W, Z, q, e: Real;
  end;

function clc(A, W, Z, q, e: real):real;
procedure load_params(var s1, s2: real; filename: string);
procedure save_params(var s1, s2: real; filename: string);

implementation
function clc(A, W, Z, q, e: real):real;
begin
  W := 3*e-7;
  Z := 2*q-3;
  A := e*(q*(q*W-2*e+11))+q*Z+10*e+6;
 end;

procedure save_params(var s1, s2: real; filename: string);
 var
   f: text;
 begin
      assign(f, filename);
      rewrite(f);
      writeln(f, s1);
      writeln(f, s2);
      close(f);
 end;

procedure load_params(var s1, s2: real; filename: string);
 var
   f: text;
 begin
     assign(f, filename);
     reset(f);
     readln(f, s1);
     readln(f, s2);
     close(f);
 end;
end.

