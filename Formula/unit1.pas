unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, StdCtrls, Menus, Grids, my;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    MenuItem1: TMenuItem;
    MenuItem5: TMenuItem;
    MenuItem6: TMenuItem;
    MenuItem7: TMenuItem;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    StringGrid1: TStringGrid;
    vvodX: TEdit;
    vvodY: TEdit;
    vX: TLabel;
    vY: TLabel;
    Label3: TLabel;
    MainMenu1: TMainMenu;
    MenuItem4: TMenuItem;
    function DataFromForm:boolean;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure MenuItem1Click(Sender: TObject);
    procedure MenuItem2Click(Sender: TObject);
    procedure MenuItem3Click(Sender: TObject);
    procedure MenuItem4Click(Sender: TObject);
    procedure MenuItem6Click(Sender: TObject);
    procedure MenuItem7Click(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;
  row: integer;
  X,Y:real;

implementation

{$R *.lfm}

{ TForm1 }

function TForm1.DataFromForm:boolean;
var err:string;
flag:boolean;
begin
  result:=false; flag:=false;
  if TryStrToFloat(vvodX.Text,X) = false then
  begin
     err:=err+'Неверный ввод параметра X'+#10;
     vvodX.Color:=clRed; flag:=True;
  end
  else vvodX.Color:=clWhite;

  if TryStrToFloat(vvodY.Text,Y)=false then
    begin
    err:=err+'Неверный ввод параметра Y'+#10;
    vvodY.Color:=clRed; flag:=True;
    end
  else vvodY.Color:=clWhite;

  if flag = true then
  begin
  ShowMessage(err);
  exit;
  end;
  result:=true;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  If DataFromForm= false then exit;
  clc(A, W, Z, q, e);
  inc(row);
  StringGrid1.RowCount:=row+1;
  StringGrid1.Cells[0, row]:=IntToStr(row);
  StringGrid1.Cells[1, row] := FloatToStr(q);
  StringGrid1.Cells[2, row] := FloatToStr(e);
  StringGrid1.Cells[3, row] := FloatToStr(A);
end;

procedure TForm1.FormCreate(Sender: TObject);
begin

end;

procedure TForm1.MenuItem1Click(Sender: TObject);
begin
   ShowMessage('Автор: Пряженников Виктор'+#13#10+
  'Задача: 29. Даны действительные числа x, y.'+#13#10+
  '  Не пользуясь никакими другими операциями,'+#13#10+
  '  кроме умножения, сложения и вычитания, вычислить'+#13#10+
  '  3x2y2 - 2xy2 - 7x2y - 4y2 + 15xy + 2x2 - 3x + 10y + 6.'+#13#10+
  '  Разрешается использовать не более восьми умножений и'+#13#10+
  '  восьми сложений и вычитаний.'+#13#10+
  'ссылка на задачу:'+#13#10+
  '  http://bgu-chita.ru/zadachnik/Glava01/index01.htm#z29');
end;

procedure TForm1.MenuItem2Click(Sender: TObject);
begin
  If SaveDialog1.Execute then
 { Memo1.Lines.SaveToFile(SaveDialog1.Filename);}
end;


procedure TForm1.MenuItem4Click(Sender: TObject);
begin
  close;
end;

procedure TForm1.MenuItem6Click(Sender: TObject);
begin
  If OpenDialog1.Execute then
  {Memo1.Lines.LoadFromFile(OpenDialog1.Filename); }
end;

procedure TForm1.MenuItem7Click(Sender: TObject);
begin
  If SaveDialog1.Execute then
  {Memo1.Lines.SaveToFile(SaveDialog1.Filename);}
end;


end.

