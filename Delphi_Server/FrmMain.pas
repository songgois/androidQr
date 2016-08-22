unit FrmMain;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, IdBaseComponent, IdComponent, IdTCPServer, StdCtrls;

type
  TFormMain = class(TForm)
    idtcpsrvr: TIdTCPServer;
    mmoReceive: TMemo;
    procedure idtcpsrvrExecute(AThread: TIdPeerThread);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FormMain: TFormMain;

implementation

{$R *.dfm}

procedure TFormMain.idtcpsrvrExecute(AThread: TIdPeerThread);
begin
  mmoReceive.Lines.Add(AThread.Connection.AllData);

end;

end.
